using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeAttack : MonoBehaviour
{

    public Text monHP;
    public Text chrHP;
    public Button attackBtn;
    public Text _message;
    public Text turn;
    int clickNum = 1;
    public Sprite mon1;
    public Sprite mon2;
    public Image monImage;
    public Sprite chr1;
    public Sprite chr2;
    public Image chrImage;

    int chrAttack = 10;
    int monAttack = 20;
    int monHP1 = 100;
    int chrHP1 = 100;
    int criticalAttack = 25;

    System.Random critical = new System.Random();


    public void Attackclick()
    {
        if (clickNum % 2 == 1)
        {
            monImage.sprite = mon1;
            int A = critical.Next(1, 10);
            chrHP.text = "HP:"+ chrHP1.ToString();

            if (chrHP1 < 50)
            {
                chrImage.sprite = chr2;
                turn.text = clickNum.ToString() + "턴";
                chrHP1 = 100;
                chrHP.text = "HP:" + chrHP1.ToString();
                _message.text = "스노우미쿠의 자가회복!";
            }
            else if (A >= 7)
            {
                turn.text = clickNum.ToString() + "턴";
                monHP1 -= criticalAttack;
                monHP.text = "HP:" + monHP1.ToString();
                _message.text = "스노우미쿠가 카와미쿠에게" + criticalAttack.ToString() + "의 치명적인 데미지를 입혔다.";
            }
            else if (A < 7)
            {
                turn.text = clickNum.ToString() + "턴";
                monHP1 -= chrAttack;
                monHP.text = "HP:" + monHP1.ToString();
                _message.text = "스노우미쿠가 카와미쿠에게" + chrAttack.ToString() + "의 데미지를 입혔다.";
            }

            }
            else if (clickNum % 2 == 0)
            {
                 chrImage.sprite = chr1;
            turn.text = clickNum.ToString() + "턴";
                chrHP1 -= monAttack;
                chrHP.text = "HP:" + chrHP1.ToString();
                _message.text = "카와미쿠가 스노우 미쿠에게" + monAttack.ToString() + "의 데미지를 입혔다.";
            }


            if (monHP1 <= 0)
            {
                monImage.sprite = mon2;

                monHP.text = "HP:0";
                chrHP1 = 100;
                chrHP.text = "HP:" + chrHP1.ToString();
                _message.text = "카와미쿠를 처치했다!";
                clickNum = 0;
                turn.text = clickNum.ToString() + "턴";
                clickNum = 1;
                monHP1 = 100;

            }
            else
            {
                clickNum++;
            }

        }
    }

