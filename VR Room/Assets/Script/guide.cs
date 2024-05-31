using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class guide : MonoBehaviour
{
    public TextMeshPro textMesh;
    public string[] sentences = new string[]
    {
        "Welcome!",
        "Bowling can be a fun and enjoyable activity, whether you're a beginner or looking to improve your game. Here are some basic guidelines to help you get started:",
        "1. Choose the Right Ball: Typically, a good starting point is a ball that is roughly 10% of your body weight.",
        "2. Basic Stance and Approach:",
        "Begin by standing with your feet shoulder-width apart, facing the pins. ",
        "Take four to five steps towards the foul line as you prepare to release the ball.",
        "As you reach the foul line, bend your knees slightly. Swing the ball out and down in a smooth arc. ",
        "Release the ball as it comes forward on the final swing, aiming to let go when it reaches your ankle for the most control and power.",
        "3. Aiming: Beginners might find it helpful to aim 15 feet from the foul line rather than the pins themselves.",
        "So you can have a more manageable target to help guide your throw.",
        "Now it's your turn to try! Your goal is to get a strike!",
        "Remember, practice makes perfect, so don't get discouraged if you don't strike every time."
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

