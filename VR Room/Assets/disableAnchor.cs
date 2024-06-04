using UnityEngine;

public class DisableAnchor : MonoBehaviour
{
    public GameObject teleportAnchor1;
    public GameObject teleportAnchor2;
    public GameObject player;
    public float activationDistance = 5.0f;
    public GameObject collider;

    private bool isWithinRange = false;

    public GameObject collider2;

    private bool isWithinRange2 = false;

    void Update()
    {
        // Calculate the distance between player and this GameObject every frame
        float distance = Vector3.Distance(player.transform.position, collider.transform.position);
        // Debug.Log("Distance: " + distance); // Optional, for debugging purposes

        // Check if the player is within the specified range
        if (distance < activationDistance)
        {
            if (!isWithinRange) // Only run once when player enters range
            {
                isWithinRange = true; // Set flag to true as player is now within range
                ManageAnchors(); // Call method to manage teleport anchors
            }
        }
        else if (isWithinRange) // Check if player was previously within range but now is not
        {
            isWithinRange = false; // Reset flag as player is no longer within range
        }

        float distance2 = Vector3.Distance(player.transform.position, collider2.transform.position);

        if (distance2 < activationDistance)
        {
            if (!isWithinRange) // Only run once when player enters range
            {
                isWithinRange2 = true; // Set flag to true as player is now within range
                teleportAnchor2.SetActive(false);
            }
        }
        else if (isWithinRange2) // Check if player was previously within range but now is not
        {
            isWithinRange2 = false; // Reset flag as player is no longer within range
        }
    }

    private void ManageAnchors()
    {
        // Determine which anchor to activate based on the current state of anchors
        if (teleportAnchor1 != null && teleportAnchor1.activeSelf) // If anchor 1 is active
        {
            teleportAnchor1.SetActive(false); // Disable anchor 1
            if (teleportAnchor2 != null)
                teleportAnchor2.SetActive(true); // Enable anchor 2
        }
        else if (teleportAnchor2 != null && teleportAnchor2.activeSelf) // If anchor 2 is active
        {
            teleportAnchor2.SetActive(false); // Disable anchor 2
        }
    }
}
