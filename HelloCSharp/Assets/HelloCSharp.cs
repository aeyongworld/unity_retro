using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // ����ȯ ĳ����
        int height = 170;
        float heightDetail = 170.3f;

        // �ڵ� ����ȯ (�Ҿ������ ������ ������) 
        heightDetail = height;

        // ���� ����ؾ� �ϴ� ��� (�Ҿ������ ������ ������)
        height = (int)heightDetail;


        // ���ǹ� if��
        bool isBoy = false;

        if(isBoy != true)
        {
            Debug.Log("���� ���ڴ�");
        }
        
        if(isBoy != false)
        {
            Debug.Log("���� ���ڴ�");
        }

        if(isBoy)
        {
            Debug.Log("���� ���ڴ�");
        }

        if (!isBoy)
        {
            Debug.Log("���� ���ڴ�");
        }



        // == != < > <= >=

        int love = 40;

        if(love > 50)
        {
            Debug.Log("���忣��");
        }
        else
        {
            Debug.Log("���ǿ���");
        }

        int age = 17;

        // or || Ȥ��
        // A || B, A Ȥ�� B ���߿� �ϳ��� ���̸� => ��
        if(age >= 60 || age <= 17)
        {
            Debug.Log("���� �ϸ� �ȵȴ�");
        }


        // AND && �׸���
        // A && B, A �׸��� B, �ΰ��� ��� �� => ��
        if(age > 17 && age < 60)
        {
            Debug.Log("���� ����");
        }


        if(age <= 7)
        {
            Debug.Log("��ġ���� ����");
        }
        else if(age < 12)
        {
            Debug.Log("�ʵ��б��� ����");
        } // age >= 12 �׸��� age < 15
        else if(age < 15)
        {
            Debug.Log("���б��� ����");
        }
        else if (age < 18)
        {
            Debug.Log("����б��� ����");
        }
        else
        {
            Debug.Log("����");
        }

        Debug.Log("!true = " + (!true));

    }

   
}
