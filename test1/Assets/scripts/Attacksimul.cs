using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Attacksimul : MonoBehaviour
{
    public Text monHP;
    public Text chrHP;
    public Button attackBtn;
    public Text _message;
    public Text turn;
    int clickNum = 1;

    int chrAttack = 10;
    int monAttack = 20;
    int monHP1 = 100;
    int chrHP1 = 100;
    int criticalAttack = 25;

    System.Random critical = new System.Random();
    

    public void Attackclick()
    {
        if (clickNum >= 0)
        {
            int A = critical.Next(1, 10);

            if(A >= 7)
            {
                turn.text = clickNum.ToString() + "��";
                chrHP1 -= monAttack;
                monHP1 -= criticalAttack;
                monHP.text = monHP1.ToString();
                chrHP.text = chrHP1.ToString();
                _message.text = "�������� ī�͹�����" + criticalAttack.ToString() + "�� ġ������ �������� ������." +
                    "ī�͹��� ����������" + monAttack.ToString() + "�� �������� ������.";
            }
            else
            {
                turn.text = clickNum.ToString() + "��";
                chrHP1 -= monAttack;
                monHP1 -= chrAttack;
                monHP.text = monHP1.ToString();
                chrHP.text = chrHP1.ToString();
                _message.text = "�������� ī�͹�����" + chrAttack.ToString() + "�� �������� ������." +
                    "ī�͹��� ����������" + monAttack.ToString() + "�� �������� ������.";
            }
        }
        
            if (chrHP1 <= 50)
            {
                chrHP1 = 100;
                chrHP.text = chrHP1.ToString();
            _message.text = "�������� ī�͹�����" + chrAttack.ToString() + "�� �������� ������." +
                "ī�͹��� ����������" + monAttack.ToString() + "�� �������� ������." + "���������� �ڰ�ȸ��!";
            }

             if (monHP1 <= 0)
             {
            monHP.text = "0";
            chrHP1 = 100;
            chrHP.text = chrHP1.ToString();
            _message.text = "ī�͹��� óġ�ߴ�!";
            clickNum = 0;
            turn.text = clickNum.ToString() + "��";
            clickNum = 1;
            monHP1 = 100;
               
              }
             else
              {
            clickNum++;
             }
            
        }
    }
   