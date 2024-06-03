using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DPLui : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField inputField; // TMP InputField
    public string buttonText;
    public void OnButtonClick( )
    {
        // ����ť�����ʱ������ť�ı���ӵ�TMP InputField��
        if (inputField != null)
        {
            inputField.text = buttonText;
        }
    }

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
