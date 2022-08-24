using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody playerRigidbody;


    // ������ ó�� ���۵Ǿ����� �ѹ�
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // ȭ���� �ѹ� �����϶� �ѹ� ����
    // 1�ʿ� �뷫 60�� ��, ��翡 ���� �ٸ���.
    // ��� ����Ǵ����� ������ ������ �ʴ�.
    void Update()
    {
        // A <-                      -> D        
        // -1.0  -0.5    0   +0.5    +1.0
        
        // ���̽�ƽ���� �ڵ����� ������
        // ���ڷ� �޴� ������ ���̽�ƽ�� ��� �̴� ������ �˱� ����
        float inputX = Input.GetAxis("Horizontal");


        // S v         ^ W
        // -1.0   0    +1.0
        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputZ);

        
        velocity = velocity * speed;

        velocity.y = fallSpeed;

        // (inputX * speed, fallSpeed, inputZ * speed)
        
        playerRigidbody.velocity = velocity;

    }
}
  