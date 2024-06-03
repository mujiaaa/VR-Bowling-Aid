using UnityEngine;
using TMPro;  // Ensure you're using TMPro to access TextMeshProUGUI
using System.Collections.Generic;

public class ResetPinsAndScore : MonoBehaviour
{
    public List<Transform> pins = new List<Transform>();
    public Score scoreScript;        // Reference to the Score script
    // public List<Transform> pins;     // List of pins to reset
    public List<Vector3> initialPositions;  // List to store initial positions of pins

    void Start()
    {
        // Store the initial positions of pins
        foreach (Transform pin in pins)
        {
            initialPositions.Add(pin.position);
        }
    }

    // Method to be called by the button to reset pins and score
    public void ResetGame()
    {
        // Reset each pin to its initial position
        for (int i = 0; i < pins.Count; i++)
        {
            pins[i].position = initialPositions[i];
            pins[i].rotation = Quaternion.identity;
            Rigidbody rb = pins[i].GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.isKinematic = false;
            }
            pins[i].gameObject.SetActive(true);
        }

        
        if (scoreScript != null)
        {
            scoreScript.score = 0;
            scoreScript.texts.text = $"Score: {scoreScript.score}/10";
        }
    }
}
