using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlingPinBehavior : MonoBehaviour
{
    
    public static int score;
    // int totalScore = 10;
    /*
    void AddScore(int amount)
    {
        score += amount;
        UIManager.instance.UpdateUI(score, totalScore);

    }
    */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HitPath")
        {
            UIManager.AddScore(1);
            // Destroy(gameObject, 2.0f);
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
