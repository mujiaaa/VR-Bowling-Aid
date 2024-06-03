using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectDPL : MonoBehaviour
{
    public float rotationSpeed = 10f; // 旋转速度

    // Update is called once per frame
    void Update()
    {
        // 根据时间增量和旋转速度旋转物体
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
}
