using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �ּ�, ��ǻ�Ͱ� ó������ �ʴ� ���� - �޸�� ���

        /*
          �������� ��ģ
          �ּ���
          ���� �� �ִ�.
        */


        // �ܼ� ���
        Debug.Log("Hello World!");


        // ������ ����

        int age = 23;
        int money = -1000;

        Debug.Log(age);
        Debug.Log(money);


        // floating point - float : �Ҽ����� ������ �Ǽ� : 32��Ʈ
        // �Ҽ��� �Ʒ� 7�ڸ������� ��Ȯ
        float height = 169.12345f;

        // float�� �ι��� �޸𸮸� ��� 64��Ʈ
        // �Ҽ��� �Ʒ� 15�ڸ� ������ ��Ȯ
        double pi = 3.14159265359;


        // bool�� �� true Ȥ�� ���� false
        bool isBoy = true;
        bool isGirl = false;

        // char character �� �� ����
        char grade = 'A';

        // string �� ����
        string movieTitle = "������̺�!";

        Debug.Log("�� ���̴�! :" + age);

        Debug.Log("���� ���� ����! :" + money);

        Debug.Log("�� Ű��! :" + height);

        Debug.Log("��������! :" + pi);

        Debug.Log("�� ������! :" + grade);

        Debug.Log("���� ��ȭ! :" + movieTitle);

        Debug.Log("���� �����ΰ�? :" + isBoy);


        // var�� �Ҵ��ϴ� ���� �������� Ÿ���� ����
        var myName = "I_Jemin";
        // string myName = "I_Jemin";
        var myAge = 23;
        // int myAge = 23;

        Debug.Log("������ �г���: " + myName);
    }

    
}
