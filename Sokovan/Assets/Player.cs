using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody playerRigidbody;


    // 게임이 처음 시작되었을때 한번
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // 화면이 한번 깜빡일때 한번 실행
    // 1초에 대략 60번 단, 사양에 따라 다르다.
    // 몇번 실행되는지는 정해져 있지는 않다.
    void Update()
    {
        // A <-                      -> D        
        // -1.0  -0.5    0   +0.5    +1.0
        
        // 조이스틱에도 자동으로 대응됨
        // 숫자로 받는 이유는 조이스틱을 살살 미는 정도를 알기 위해
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
  