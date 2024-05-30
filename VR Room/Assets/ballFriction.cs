using UnityEngine;

public class ballFriction : MonoBehaviour
{
    public float dynamicFriction = 0.6f;
    public float staticFriction = 0.6f;
    public float drag = 0.5f;
    public float angularDrag = 0.05f;

    void Start()
    {
        // Get the Rigidbody component
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.drag = drag;
            rb.angularDrag = angularDrag;
        }

        // Get the Collider component
        Collider col = GetComponent<Collider>();
        if (col != null)
        {
            // Create a new Physics Material
            PhysicMaterial ballMaterial = new PhysicMaterial();
            ballMaterial.dynamicFriction = dynamicFriction;
            ballMaterial.staticFriction = staticFriction;
            ballMaterial.frictionCombine = PhysicMaterialCombine.Multiply;

            // Assign the Physics Material to the Collider
            col.material = ballMaterial;
        }
    }
}
