using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Import the UI namespace
using UnityStandardAssets.CrossPlatformInput;

public class ForcedReset : MonoBehaviour
{
    private Image resetImage; // Reference to the Image component

    private void Awake()
    {
        // Get the Image component attached to the same GameObject
        resetImage = GetComponent<Image>();

        // Ensure there's an Image component attached
        if (resetImage == null)
        {
            Debug.LogError("No Image component found on this GameObject.");
        }
    }

    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
