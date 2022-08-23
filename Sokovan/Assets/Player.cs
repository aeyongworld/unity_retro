using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody playerRigidbody;


    // 게임이 처음 시작되었을때 한번
    void Start()
    {
        
    }

    // 화면이 한번 깜빡일때 한번 실행
    // 1초에 대략 60번 단, 사양에 따라 다르다.
    // 몇번 실행되는지는 정해져 있지는 않다.
    void Update()
    {

        // 유저입력을 넣자
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
  