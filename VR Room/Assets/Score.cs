using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public List<Vector3> postions;
    public List<Transform> balls;
    public int score;

    public TextMeshProUGUI texts;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            balls.Add(child);
            postions.Add(child.position);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in balls)
        {
         Debug.Log(item.eulerAngles.x);
            if (item.eulerAngles.x > 50&& item.eulerAngles.x < 90 || item.eulerAngles.x <320&& item.eulerAngles.x >270|| item.eulerAngles.z > 50 && item.eulerAngles.z < 90 || item.eulerAngles.z < 320 && item.eulerAngles.z > 270) 
            {
                Debug.Log(item.localEulerAngles.x);
                balls.Remove(item);
                Destroy(item.gameObject, 2);
                score++;
                texts.text = $"Score:{score}/10";
            }
        }
    }
}
