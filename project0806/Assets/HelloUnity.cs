using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 주석, 컴퓨터가 처리하지 않는 라인 - 메모로 사용

        /*
          여러줄을 걸친
          주석을
          남길 수 있다.
        */


        // 콘솔 출력
        Debug.Log("Hello World!");


        // 숫자형 변수

        int age = 23;
        int money = -1000;

        Debug.Log(age);
        Debug.Log(money);


        // floating point - float : 소수점을 가지는 실수 : 32비트
        // 소수점 아래 7자리까지만 정확
        float height = 169.12345f;

        // float의 두배의 메모리를 사용 64비트
        // 소수점 아래 15자리 까지만 정확
        double pi = 3.14159265359;


        // bool은 참 true 혹은 거짓 false
        bool isBoy = true;
        bool isGirl = false;

        // char character 는 한 문자
        char grade = 'A';

        // string 은 문장
        string movieTitle = "러브라이브!";

        Debug.Log("내 나이는! :" + age);

        Debug.Log("내가 가진 돈은! :" + money);

        Debug.Log("내 키는! :" + height);

        Debug.Log("원주율은! :" + pi);

        Debug.Log("내 성적은! :" + grade);

        Debug.Log("명작 영화! :" + movieTitle);

        Debug.Log("나는 남자인가? :" + isBoy);


        // var는 할당하는 값을 기준으로 타입을 결정
        var myName = "I_Jemin";
        // string myName = "I_Jemin";
        var myAge = 23;
        // int myAge = 23;

        Debug.Log("제민의 닉네임: " + myName);
    }

    
}
