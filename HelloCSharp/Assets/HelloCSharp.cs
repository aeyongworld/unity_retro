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


        // switch �б⹮

        int year = 2017;

        switch (year)
        {
            case 2012:
                Debug.Log("���������");
                break;
            case 2015:
                Debug.Log("������̺�");
                break;
            case 2016:
                Debug.Log("�");
                break;
            case 2017:
                Debug.Log("Ʈ��������5");
                break;
            default:
                Debug.Log("�⵵�� �ش���� ����");
                break;
        }

        // ������ Loop �ݺ�����

        // for��
        // �ʱ�ȭ; ����; ������Ʈ
        // i > 0,1,2,3,4,5,6,7,8,9
       
        for(int i=0; i<10; i++)
        {
            Debug.Log("���� ����: " + i);

        }
        Debug.Log("���� ��");


        bool isShot = false;
        int index = 0;
        int luckyNumber = 4;

        while(isShot == false)
        {
            index = index + 1;
            Debug.Log("���� �õ�: " + index);
            if(index == luckyNumber)
            {
                Debug.Log("�Ѿ˿� �¾Ҵ�!");
                isShot = true;
            }
            else
            {
                Debug.Log("�Ѿ˿� ���� �ʾҴ�");
            }
        }

        do
        {
            Debug.Log("Do-While");
        } while (isShot == false);
    }

   
}
