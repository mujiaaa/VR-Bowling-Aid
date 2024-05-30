using UnityEngine;

public class BallDisplayController : MonoBehaviour
{
    public Canvas displayCanvas; // Reference to the Canvas
    public string triggeringTag = "MainCamera"; // Change this to the tag you want to use

    private void Awake()
    {
        Debug.Log("BallDisplayController Awake");
    }

    private void Start()
    {
        Debug.Log("BallDisplayController Start");
        if (displayCanvas != null)
        {
            displayCanvas.enabled = false; // Initially disable the Canvas
            Debug.Log("Canvas has been disabled at start.");
        }
        else
        {
            Debug.LogError("DisplayCanvas is not assigned.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called");
        if (other.CompareTag(triggeringTag))
        {
            if (displayCanvas != null)
            {
                displayCanvas.enabled = true; // Enable the Canvas when the object with the triggering tag enters the trigger
                Debug.Log("Canvas enabled on trigger enter.");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit called");
        if (other.CompareTag(triggeringTag))
        {
            if (displayCanvas != null)
            {
                displayCanvas.enabled = false; // Disable the Canvas when the object with the triggering tag leaves the trigger
                Debug.Log("Canvas disabled on trigger exit.");
            }
        }
    }
}
