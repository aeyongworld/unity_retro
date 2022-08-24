using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update�� �뷫 1�ʿ� 60��
    void Update()
    {
        // 1���� 60��
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);

        // Time.deltaTime �� ȭ���� �ѹ� �����̴� �ð� = �� �������� �ð�
        // ȭ���� 60�� �����̸� (�ʴ� 60������) 1/60
        // ȭ���� 200�� �����̸� (�ʴ� 200������) 1/200
        // 60/200 * 200 = 60 
    }

    // 60 x 60 = 3600

    // �ϵ� �� ���ǵ� - �����ڽ� �ܼ�/PC��
    // 1�� 30������ ������ ��

    // ������ �� ���� ���α׷�
    // 1�ʿ� 60�� �̻� �����̵��� ����
    // => ��� ������ �ӵ��� 2���̻� ������


    // 1�ʿ� 1m
    // Update { �ѹ��� 1/30m; }
    // 1/30m * 30 => 1m

    // �����Ӷ��� ���� �ʴ� 30������ => �ʴ� 60������
    // 1/30m * 60 => 2m


    // Update �Լ��� ȭ���� �ѹ� �����̸� �����
    // Update { �ѹ��� 1m }

    // 1�ʿ� �� 1m


    // ������ : 1�ʿ� 30��
    // �ѹ��� 1m * 30 = 30 * (1/30) = 1m


    // 1m�� �����̴� Ƚ�� (30)�� �ɰ��� -> 1/30m
    // 1/30m �� 30�� �������� �ݺ��ؼ� �����ϸ� = 1m

    // ���� ��ǻ�� : 1�ʿ� 60��
    // �ѹ��� 1m * 60 = 60 * (1/60) = 1m
    // 1m * (1/60) * 60 = 1m
}
