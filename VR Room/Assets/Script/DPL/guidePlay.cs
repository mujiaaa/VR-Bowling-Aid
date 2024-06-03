using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidePlay : MonoBehaviour
{
    public GameObject[] objects;
    public float displayTime = 2f;

    private int currentIndex = 0;

    void Start()
    {
        
        StartCoroutine(abcd());
    }

    IEnumerator abcd()
    {
        while (true)
        {
            
            objects[currentIndex].SetActive(true);

            
            yield return new WaitForSeconds(displayTime);

            
            objects[currentIndex].SetActive(false);

            
            currentIndex = (currentIndex + 1) % objects.Length;
        }
    }
}
