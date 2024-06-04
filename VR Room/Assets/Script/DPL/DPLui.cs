using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DPLui : MonoBehaviour
{
    public TMP_InputField inputField;
    public string buttonText;
    public void OnButtonClick( )
    {
        if (inputField != null)
        {
            inputField.text = buttonText;
        }
    }

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
