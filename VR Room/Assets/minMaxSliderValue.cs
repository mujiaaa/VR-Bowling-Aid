using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class minMaxSliderValue : MonoBehaviour
{
    public Slider minMaxSlider;
    public TMP_InputField inputField; 
    // Start is called before the first frame update
    void Start()
    {
        // Add a listener to the slider that calls the UpdateInputField method whenever the slider value changes
        minMaxSlider.onValueChanged.AddListener(UpdateInputField);
    }

    // This method will be called whenever the slider's value changes
    private void UpdateInputField(float value)
    {
        // Update the TMP_InputField text to show the slider's current value
        inputField.text = Mathf.RoundToInt(value).ToString();; // Formats the float to 2 decimal places
    }
}
