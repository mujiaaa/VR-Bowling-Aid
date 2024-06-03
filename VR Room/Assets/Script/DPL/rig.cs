using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class rig : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent @event;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Ball"))
        {
            Debug.Log("Æ«ÏòÄÄÀï");
            if (@event!=null)
            {
                @event.Invoke();
            }
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
