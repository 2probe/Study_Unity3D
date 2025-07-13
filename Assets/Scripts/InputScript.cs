using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Animator AniCon_Pico;

    // Update is called once per frame
    void Update()
    {
        // �Է�
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ).normalized;

        // �̵�
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // ȸ��
        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }

        // ����
        Input.GetMouseButtonDown(0);// GetMouseButtonDown(0) : ���콺 ���� ��ư�� ������ �� True�� ��ȯ�մϴ�.
        
        bool isAttack = Input.GetMouseButtonDown(0);// GetMouseButtonDown(0) : ���콺 ���� ��ư�� ������ �� True�� ��ȯ�մϴ�.

        AniCon_Pico.SetBool("ISATTACK", isAttack);

        // ����
        Input.GetKeyDown(KeyCode.Space);
        
        bool isJump = Input.GetKeyDown(KeyCode.Space);

        AniCon_Pico.SetBool("ISJUMP", isJump);

        //��
        Input.GetKeyDown(KeyCode.T);

        bool isTwerk = Input.GetKeyDown(KeyCode.T);
        AniCon_Pico.SetBool("ISTWERK", isTwerk);





        // �ִϸ�����
        bool isWalk = 0 < moveDirection.magnitude;
        // moveDirection.magnitude : ������ ���̸� ��ȯ�մϴ�.
        // �Է� ���� ������ ������ ���̰� 0���� Ŀ���鼭 True�� ��ȯ�մϴ�.
        AniCon_Pico.SetBool("ISWALK", isWalk);
        // anicon_PicoChan�̶�� �ִϸ����͸� ���� ������ �����մϴ�.
        // Bool Ÿ���� Parameter�� �����Ͽ��⿡ SetBool�Լ��� ����մϴ�.


    }
}
