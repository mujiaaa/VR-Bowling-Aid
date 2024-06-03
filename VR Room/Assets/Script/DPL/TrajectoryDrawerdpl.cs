using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using static UnityEngine.GraphicsBuffer;

public class TrajectoryDrawerdpl : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private Transform target;
 
    public int positionCount = 500;
    private LineRenderer lineRenderer;
    private Vector3[] positions;

    Coroutine drawCoroutine;
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(OnGrabbed);
        grabInteractable.selectExited.AddListener(OnReleased);
        target = transform;
        lineRenderer = GetComponent<LineRenderer>();
        positions = new Vector3[positionCount];
        lineRenderer.enabled = false;

      
    }

    private void OnGrabbed(SelectEnterEventArgs arg0)
    {
        lineRenderer.enabled = true;
        positions = new Vector3[positionCount];
        if (drawCoroutine != null)
        {
            StopCoroutine(drawCoroutine);
            drawCoroutine = null;
        }


    }

    private IEnumerator<WaitForSeconds> DrawTrajectory()
    {

      
        yield return new WaitForSeconds(0.2f);
        for (int i = 0; i < positions.Length; i++)
        {
            positions[i] = target.position;
        }
        while (true)
        {

            for (int i = positionCount - 1; i > 0; i--)
            {
                positions[i] = positions[i - 1];
            }
            positions[0] = target.position;

            // LineRenderer
            lineRenderer.positionCount = positionCount;
            lineRenderer.SetPositions(positions);


            yield return new WaitForSeconds(0.05f); // 


        }

      
    }
   
    public void OnReleased(SelectExitEventArgs args) 
    {


        if (drawCoroutine == null)
        {
            drawCoroutine = StartCoroutine(DrawTrajectory());
        }

    }

    void Update()
    {
    
    }
}
