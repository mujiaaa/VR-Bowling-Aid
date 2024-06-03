using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class ballFriction : MonoBehaviour
{
    //public float dynamicFriction = 0.6f;
    //public float staticFriction = 0.6f;
    //public float drag = 0.5f;
    //public float angularDrag = 0.05f;
    //public LineRenderer lineRenderer;
    //public int numPoints = 50;
    //public float timeStep = 0.1f;

    //private XRGrabInteractable interactable;
    //void Start()
    //{
    //    Rigidbody rb = GetComponent<Rigidbody>();
    //    if (rb != null)
    //    {
    //        rb.drag = drag;
    //        rb.angularDrag = angularDrag;
    //    }

    //    Collider col = GetComponent<Collider>();
    //    if (col != null)
    //    {
    //        PhysicMaterial ballMaterial = new PhysicMaterial();
    //        ballMaterial.dynamicFriction = dynamicFriction;
    //        ballMaterial.staticFriction = staticFriction;
    //        ballMaterial.frictionCombine = PhysicMaterialCombine.Multiply;

    //        col.material = ballMaterial;
    //    }

    //    lineRenderer = GetComponent<LineRenderer>();
    //    lineRenderer.positionCount = 0;
    //    lineRenderer.startWidth = 0.05f;
    //    lineRenderer.endWidth = 0.05f;

    //    interactable = GetComponent<XRGrabInteractable>();
    //}

    //void Update()
    //{
    //    UpdateTrajectory();
    //}

    //void UpdateTrajectory()
    //{
    //    if (lineRenderer.positionCount == 0) return;
    //    Vector3[] positions = new Vector3[numPoints];
    //    Vector3 currentPosition = transform.position;
    //    Vector3 currentVelocity = GetComponent<Rigidbody>().velocity * interactable.throwVelocityScale;

    //    for (int i = 0; i < numPoints; i++)
    //    {
    //        positions[i] = currentPosition;
    //        currentVelocity += Physics.gravity * timeStep;
    //        currentPosition += currentVelocity * timeStep;
    //    }

    //    lineRenderer.SetPositions(positions);
    //}

    //public void OnGrabbed()
    //{
    //    lineRenderer.positionCount = numPoints;
    //}

    //public void OnDropped()
    //{
    //    lineRenderer.positionCount = 0;
    //}
}
