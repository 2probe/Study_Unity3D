using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    [SerializeField] GameObject Cube;



    private void OnEnable() // ������Ʈ�� ����������
    {
        transform.position = new Vector3(Random.Range(0f, 10f), 0f, Random.Range(0f, 10f)); // ������ ��ġ�� �̵�    

    }
}
