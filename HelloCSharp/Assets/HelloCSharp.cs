using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // 형변환 캐스팅
        int height = 170;
        float heightDetail = 170.3f;

        // 자동 형변환 (잃어버리는 정보가 없으면) 
        heightDetail = height;

        // 직접 명시해야 하는 경우 (잃어버리는 정보가 있으면)
        height = (int)heightDetail;


        // 조건문 if문
        bool isBoy = false;

        if(isBoy != true)
        {
            Debug.Log("나는 여자다");
        }
        
        if(isBoy != false)
        {
            Debug.Log("나는 남자다");
        }

        if(isBoy)
        {
            Debug.Log("나는 남자다");
        }

        if (!isBoy)
        {
            Debug.Log("나는 여자다");
        }



        // == != < > <= >=

        int love = 40;

        if(love > 50)
        {
            Debug.Log("베드엔딩");
        }
        else
        {
            Debug.Log("해피엔딩");
        }

        int age = 17;

        // or || 혹은
        // A || B, A 혹은 B 둘중에 하나라도 참이면 => 참
        if(age >= 60 || age <= 17)
        {
            Debug.Log("일을 하면 안된다");
        }


        // AND && 그리고
        // A && B, A 그리고 B, 두개가 모두 참 => 참
        if(age > 17 && age < 60)
        {
            Debug.Log("일할 나이");
        }


        if(age <= 7)
        {
            Debug.Log("유치원에 간다");
        }
        else if(age < 12)
        {
            Debug.Log("초등학교로 간다");
        } // age >= 12 그리고 age < 15
        else if(age < 15)
        {
            Debug.Log("중학교로 간다");
        }
        else if (age < 18)
        {
            Debug.Log("고등학교로 간다");
        }
        else
        {
            Debug.Log("성인");
        }

        Debug.Log("!true = " + (!true));

    }

   
}
