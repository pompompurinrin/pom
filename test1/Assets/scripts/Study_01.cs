using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;


// �ּ� �� ��
/* �ּ� ���� ��
 * �̰� �ּ� ���� ���̴�
 * ���� ���� �ִ�
 */



public class Study_01 : MonoBehaviour
{

/*
    list ����
    list<������ Ÿ��> ����Ʈ �̸� = new list<������ Ÿ��();
    ũ�⸦ �����ϰ� ����� ���� ����
    List<Datatype> name = new List <DataType>(new DataType[size])
    ��� size¥�� ����Ʈ�� ����
    List�� ������ ���ÿ� �ʱ�ȭ �ؼ� ���� ����
    List<struib> ssh = new List<string>() {"�ż�ȣ", "�ٺ�"};
    �̷��� ssh ����Ʈ �ȿ� 0��°�� "�ż�ȣ", 1��°�� "�ٺ�"
    ssh[0] = "�ż�ȣ", ssh[1] = "�ٺ�"
    ����Ʈ�� �ٸ� ����Ʈ�� �޾Ƽ� ������ �� ����
    List<string> yyw = new List<string>(ssh);
    yyw = ssh
    ����Ʈ�� ������ �߰��ϴ� ���
    Add �Լ� �̿�
    ��� ����Ʈ�� �� �ڿ� �߰��ϴ� �����
    */
    List<string> ssh = new List<string>();
    void Start()
    {
        ssh.Add("�� �� ȣ ��");
        //���⼭�� ssh �ʱ�ȭ �� ������ ���� �ȳ־��� size�� 0�� (�ƹ��͵� ����)
        //�׷��� "�� �� ȣ ��"�� ssh[0]�� ��4
        ssh.Add("�� �� ȣ ��");
        //�߰��� "�� �� ȣ ��"�� ssh[1]�� ��ġ

        //insert �Լ� �̿� ���
        //�� �״�� ���� �ִ� �����
        //���� �����ϱ� ������ �ִ� �ֵ��� �ڷ� �и�
        ssh.Insert(0, "�� �� �� ��");
        /* �̷��� ssh��?
        [�������, �ż�ȣ��, �ż�ȣ��]

        �迭, ����Ʈ�� ũ�⸦ ���ϴ� ���
        �迭�� ���
        �迭�̸�.Length;
        ����Ʈ�� ���
        ����Ʈ�̸�.Count;
        �迭�� ����Ʈ�� ũ�⸦ ���ϴ� ����� �ٸ�
        ����� �ٸ��� ����Ʈ�� �迭�� �̸��� ����ϰ� ������?
        �迭�̸�.Count; �̷��� �Ϸ��� �ؼ� ������ ���� ����

         ����Ʈ���� ������ �����ϴ� ���
        -Remove �Լ�
        ���ϴ� "��"�� ã�Ƽ� ����
        ���� ���� �������� �� ó�� ���� ����µ�

        ���� ID�� ������ 3���� �� 2��°�� ������ �ϴ� ��Ȳ������
        -RemoveAt �Լ� ���
        ��� �ε��� ������ ����
        �迭�� �����ϰ� 0���� ����

        �̰� ���� RemoveAll, Clear �Լ��� ����
        �ٵ� �Ⱦ�
        RemoveAll ���
        ����Ʈ�̸�.RemoveAll(x => x == "yyw");
        x => x== "yyh"�� ���ٽ��̶�� �ϴµ� ���� �ȴ�
        ������ x�� yyw�� �ָ� ��� ����ٴ� ����

         lua ������
        for i = 1,i <= 9 do
        for s = 1, s <= 9 do
        print i * s
        end

        C# �������� �߰�ȣ�� ������
        */
        for (int i = 0; i < 9; i++)
        {
            // int i : i�� 0���� ����
            // i < 9 : 9���� ���� ������ �ݺ�
            // i++ : i�� 1�� ����
            UnityEngine.Debug.Log(i);
        }

        int sum = 0; //�հ踦 ���� ������ ����
        int odd = 0;

        for (int i = 2; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                int result = i * j;
               
                UnityEngine.Debug.Log(i + "X" + j + "=" + result);
                sum += result;
                
                if(result % 2 ==1)
                    {
                        odd++;
                    }
            }
        }
        /*
        ����ġ
        �굵 ���ǿ� ���� ����� (if�� ���)
        �ٵ� ��� �ϳ��� ���� �����ؼ� ��ġ�ϴ� ��쿡�� �ش� ��ɾ �����ϴ� ���
        ��, �� ���� �Ұ�
        ��Ȯ�� ��ġ�ϴ� ���� �־�� �� �� ����

            switch(�񱳰�)
               {
                    case ��ġ��:
                        ������ ��ɾ�
                    break;
                    default:
                       ��ġ���� ���� �� ������ ����
                    break;
               }
        */
        int randValue;
        randValue = Random.Range(0, 9);
        //int �� �� ����(9) ���� �ȵ�
        //float�� ���� ���Ե�
       // randValue = (int)Random.RandomRange(0f, 9f);
        //
        

    }




}
