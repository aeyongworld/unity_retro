using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        

        // �������� ���� �ϳ��� ������ �ٷ�� ���ش�
        int[] scores = new int[10];

        // scores [0] [1] [2] [3] [4] [5] [6] [7] [8] [9]

        scores[0] = 90;
        scores[1] = 45;
        scores[2] = 60;
        scores[3] = 70;
        scores[4] = 56;
        scores[5] = 80;
        scores[6] = 90;
        scores[7] = 100;
        scores[8] = 45;
        scores[9] = 14;


        for(int i=0; i<10; i++)
        {
            Debug.Log("�л�" + i +"��°�� ����: " + scores[i]);
        }

   

    }

    
}
