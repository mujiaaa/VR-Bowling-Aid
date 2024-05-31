using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class guidePlus : MonoBehaviour
{
    public TextMeshPro textMesh;
    public string[] sentences = new string[]
    {
        "Here’s some advanced guidance for becoming a better bowler:",
        "1. Advanced Ball Selection:",
        "Choose a ball with the right coverstock for the lane conditions.",
        "Reactive resin balls are good for oily lanes as they provide more hook potential, whereas urethane balls might be better for dryer lanes.",
        "2. Fine-Tuning Your Grip: Advanced bowlers often use a fingertip grip,",
        "where only the tips of the middle and ring fingers are inserted into the ball, allowing for greater control and stronger revolutions.",
        "3. Release: Work on adjusting your release technique to control the ball’s spin and angle.",
        "Learning to manipulate your wrist position and release timing can help you master hooks and curves.",
        "Now it's your turn to try! Remember, practice makes perfect, so don't get discouraged if you don't strike every time."
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

