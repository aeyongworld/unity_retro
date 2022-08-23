using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody playerRigidbody;


    // ������ ó�� ���۵Ǿ����� �ѹ�
    void Start()
    {
        
    }

    // ȭ���� �ѹ� �����϶� �ѹ� ����
    // 1�ʿ� �뷫 60�� ��, ��翡 ���� �ٸ���.
    // ��� ����Ǵ����� ������ ������ �ʴ�.
    void Update()
    {

        // �����Է��� ����
        if (Input.GetKey(KeyCode.W))
        {
            playerRigidbody.AddForce(0, 0, speed);

        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRigidbody.AddForce(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(speed, 0, 0);
        }

    }
}
  