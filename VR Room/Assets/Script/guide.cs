using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class guide : MonoBehaviour
{
    public TextMeshPro textMesh;
    public string[] sentences = new string[]
    {
    };
    private int currentSentence = 0;

    void Start()
    {
        StartCoroutine(ShowGuidance());
    }

    IEnumerator ShowGuidance()
    {
        while (currentSentence < sentences.Length)
        {
            textMesh.text = sentences[currentSentence];
            currentSentence++;
            yield return new WaitForSeconds(5);
            textMesh.text = ""; // Clears the text after 5 seconds
        }
    }
}

