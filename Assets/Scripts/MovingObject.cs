using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position += new Vector3(2, 0, 3); // ������Ʈ �̵�
        //float distance = Vector3.Distance(transform.position, Vector3.zero);
        // Vector3.zero : Vector3(0,0,0)�� �����մϴ�.
        // Vector3.Dsitance(A,B) : A�� B�� ������ �Ÿ��� ��ȯ�մϴ�. 
        //Debug.Log($"�Ÿ��� : {distance}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
