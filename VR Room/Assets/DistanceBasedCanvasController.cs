using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class DistanceBasedCanvasController : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    public Canvas canvasObject; // Reference to the Canvas
    public float activationDistance = 5f; // Distance at which the Canvas should be activated
    public float fadeDuration = 1f; // Duration of the fade in/out

    public GameObject recommendationPrompt; // Parent GameObject containing the first prompt
    public GameObject weightPrompt; // Panel containing the second prompt
    public TextMeshProUGUI recommendationResult; // Text to display the recommendation result

    public Button yesButton; // Reference to the Yes button
    public Button noButton; // Reference to the No button
    public Button submitButton; // Reference to the Submit button
    public TextMeshProUGUI weightInputField; // Reference to the Input Field for weight

    private bool isFading = false;
    private bool isWithinRange = false;
    public Graphic[] graphics; // Array to hold all UI elements

    private void Start()
    {
        // Ensure the canvas is initially inactive
        canvasObject.gameObject.SetActive(false);

        // Get all Graphic components (e.g., Text, Image) in the Canvas
        graphics = canvasObject.GetComponentsInChildren<Graphic>();

        // Set initial alpha to 0 (invisible)
        SetCanvasAlpha(0f);

        // Add listeners to the buttons
        yesButton.onClick.AddListener(OnYesButtonClicked);
        noButton.onClick.AddListener(OnNoButtonClicked);
        submitButton.onClick.AddListener(OnSubmitButtonClicked);

        // Initially hide weight prompt and recommendation result
        weightPrompt.SetActive(false);
        recommendationResult.gameObject.SetActive(false);
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.transform.position, canvasObject.transform.position);

        if (distance <= activationDistance && !isWithinRange)
        {
            isWithinRange = true;
            if (!isFading)
            {
                canvasObject.gameObject.SetActive(true); // Activate the Canvas
                StartCoroutine(FadeCanvas(1f)); // Fade in
            }
        }
        else if (distance > activationDistance && isWithinRange)
        {
            isWithinRange = false;
            if (!isFading)
            {
                StartCoroutine(FadeCanvas(0f)); // Fade out
            }
        }
    }

    private IEnumerator FadeCanvas(float targetAlpha)
    {
        isFading = true;
        float startAlpha = graphics[0].color.a;
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / fadeDuration);

            foreach (Graphic graphic in graphics)
            {
                Color color = graphic.color;
                color.a = newAlpha;
                graphic.color = color;
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the final alpha is set
        foreach (Graphic graphic in graphics)
        {
            Color color = graphic.color;
            color.a = targetAlpha;
            graphic.color = color;
        }

        isFading = false;

        // Deactivate the Canvas if the target alpha is 0
        if (targetAlpha == 0)
        {
            canvasObject.gameObject.SetActive(false);
        }
    }

    private void SetCanvasAlpha(float alpha)
    {
        foreach (Graphic graphic in graphics)
        {
            Color color = graphic.color;
            color.a = alpha;
            graphic.color = color;
        }
    }

    private void OnYesButtonClicked()
    {
        Debug.Log("Yes button clicked");
        recommendationPrompt.SetActive(false);
        weightPrompt.SetActive(true); // Show the weight prompt
    }

    private void OnNoButtonClicked()
    {
        Debug.Log("No button clicked");
        StartCoroutine(FadeCanvas(0f)); // Fade out the canvas
        // Disable the script to prevent further activation
        enabled = false;
    }

    private void OnSubmitButtonClicked()
    {
        Debug.Log("Submit button clicked");
        float weight;
        if (float.TryParse(weightInputField.text, out weight))
        {
            // Determine ball recommendation based on weight
            string ballRecommendation = GetBallRecommendation(weight);
            recommendationResult.text = $"Based on the 10% weight rule, we recommend the {ballRecommendation} balls.";
            weightPrompt.SetActive(false);
            recommendationResult.gameObject.SetActive(true); // Show the recommendation result
        }
        else
        {
            Debug.LogError("Invalid weight input.");
        }
    }

    private string GetBallRecommendation(float weight)
    {
        if (weight < 80)
        {
            return "orange and purple";
        }
        else if (weight < 115)
                {
            return "blue and white";
        }
        else if (weight < 140)
                {
            return "yellow and red";
        }
        else
        {
            return "black and grey";
        }
    }
}

