using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class recommendUI : MonoBehaviour
{
    public TMP_Text tMP_Text;
    public TMP_InputField inputField; // TMP InputField
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void showText() 
    {

        if (inputField.text == "light")
        {
            tMP_Text.text = "It is recommended that you use red and yellow";


        }
        else
        if (inputField.text == "medium")
        {
            tMP_Text.text = "It is recommended that you use black and gray";

        }
        else
        if (inputField.text == "heavy")
        {

            tMP_Text.text = "It is recommended that you use blue";
        }
        else 
        {

            int mnu = int.Parse(inputField.text);
            if (mnu < 90)
            {

                tMP_Text.text = "It is recommended that you use red and yellow";

            }
            else if (mnu >= 90 && mnu < 100)
            {
                tMP_Text.text = "It is recommended that you use black and gray";

            }
            else if (mnu >= 130)
            {
                tMP_Text.text = "It is recommended that you use blue";

            }

        }

       

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
