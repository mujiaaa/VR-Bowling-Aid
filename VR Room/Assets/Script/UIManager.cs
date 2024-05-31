using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    public static UIManager instance;
    public static int score = 0;
    public static int totalScore = 10;
    
    void Awake()
    {
        instance = this;
    }

    
    public static void AddScore(int amount)
    {
        score += amount;
        UIManager.instance.UpdateUI();

    }
    
    public void UpdateUI() 
    {
        scoreText.text = "Score: " + score + "/" + totalScore;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
