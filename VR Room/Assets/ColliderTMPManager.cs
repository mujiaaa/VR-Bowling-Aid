using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTMPManager : MonoBehaviour
{
    public GameObject colliderLeft;
    public GameObject colliderRight;
    public GameObject colliderMiddle;
    public GameObject colliderOut1;
    public GameObject colliderOut2;

    public GameObject displayLeft;
    public GameObject displayRight;
    public GameObject displayMiddle;
    public GameObject displayOut1;
    public GameObject displayOut2;

    public float activateTime = 5f;

    private void OnTriggerEnter(Collider other)
    {
        // Determine which collider was triggered and enable the corresponding display
        if (other.gameObject == colliderLeft)
        {
            StartCoroutine(EnableDisplayForTime(displayLeft));
        }
        else if (other.gameObject == colliderRight)
        {
            StartCoroutine(EnableDisplayForTime(displayRight));
        }
        else if (other.gameObject == colliderMiddle)
        {
            StartCoroutine(EnableDisplayForTime(displayMiddle));
        }
        else if (other.gameObject == colliderOut1)
        {
            StartCoroutine(EnableDisplayForTime(displayOut1));
        }
        else if (other.gameObject == colliderOut2)
        {
            StartCoroutine(EnableDisplayForTime(displayOut2));
        }
    }

    private IEnumerator EnableDisplayForTime(GameObject display)
    {
        // First disable all displays to ensure only one is active at a time
        DisableAllDisplays();
        // Then enable the specific display
        display.SetActive(true);
        // Wait for the specified activate time
        yield return new WaitForSeconds(activateTime);
        // Disable the display again
        display.SetActive(false);
    }

    private void DisableAllDisplays()
    {
        displayLeft.SetActive(false);
        displayRight.SetActive(false);
        displayMiddle.SetActive(false);
        displayOut1.SetActive(false);
        displayOut2.SetActive(false);
    }

    
}
