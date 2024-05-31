
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ToggleText : MonoBehaviour
{
    public TextMeshPro textMesh1;
    public TextMeshPro textMesh2;
    private int currentText = 0;

    public void ToggleTextDisplay()
    {
        if (currentText == 0)
        {
            textMesh1.gameObject.SetActive(true);
            textMesh2.gameObject.SetActive(false);
            currentText = 1;
        }
        else
        {
            textMesh1.gameObject.SetActive(false);
            textMesh2.gameObject.SetActive(true);
            currentText = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
