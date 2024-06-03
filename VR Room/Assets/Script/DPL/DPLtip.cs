using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPLtip : MonoBehaviour
{
    public float closeDelay = 2f;

    void OnEnable()
    {
        
        Invoke("Close", closeDelay);
    }

    void Close()
    {
        
        gameObject.SetActive(false);
    }
}
