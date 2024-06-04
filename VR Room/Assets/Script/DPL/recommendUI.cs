using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class recommendUI : MonoBehaviour
{
    public TMP_Text tMP_Text;
    public TMP_InputField inputField; // TMP InputField

    void Start()
    {
        
    }

    public void showText() 
    {
        float weight;
        if (float.TryParse(inputField.text, out weight)){
            string ballRecommendation = GetBallRecommendation(weight);
            tMP_Text.text = $"Based on the 10% weight rule, we recommend the {ballRecommendation} balls.";
        }

    }

       

    
    // Update is called once per frame
    private string GetBallRecommendation(float weight)
    {
        if (weight < 80)
        {
            return "orange and purple";
        }
        else if (weight < 115)
                {
            return "blue and white";
        }
        else if (weight < 140)
                {
            return "yellow and red";
        }
        else
        {
            return "black and grey";
        }
    }
    void Update()
    {
        
    }
}

