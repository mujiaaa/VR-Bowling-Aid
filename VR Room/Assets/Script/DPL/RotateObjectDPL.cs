using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectDPL : MonoBehaviour
{
    public float rotationSpeed = 10f; // ��ת�ٶ�

    // Update is called once per frame
    void Update()
    {
        // ����ʱ����������ת�ٶ���ת����
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
}
