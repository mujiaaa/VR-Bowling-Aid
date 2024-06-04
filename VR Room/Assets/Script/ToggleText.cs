
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ToggleText : MonoBehaviour
{
    public GameObject basic;
    public GameObject advanced;
    public Button toggleButton;

    void Start()
    {
        basic.SetActive(true);
        advanced.SetActive(false);
        if (toggleButton != null)
        {
            toggleButton.onClick.AddListener(Toggle);
        }
    }

    public void Toggle()
    {
        basic.SetActive(!basic.activeSelf);
        advanced.SetActive(!advanced.activeSelf);
    }
}
