using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Gatcha : MonoBehaviour
{
    public Button Btn100;
    public Button Btn1nujuck;
    public Button Clearall;
    public Text star1;
    public Text star2;
    public Text star3;
    public Text star4;
    public Text star5;
    int _count;

    System.Random Count = new System.Random();
    System.Random Star = new System.Random();

    int star1Count;
    int star2Count;
    int star3Count;
    int star4Count;
    int star5Count;

    public void ClearAll()
    {
        star1Count = 0;
        star2Count = 0;
        star3Count = 0;
        star4Count = 0;
        star5Count = 0;
        star1.text = "1��" + star1Count + "�� ȹ��";
        star2.text = "2��" + star2Count + "�� ȹ��";
        star3.text = "3��" + star3Count + "�� ȹ��";
        star4.text = "4��" + star4Count + "�� ȹ��";
        star5.text = "5��" + star5Count + "�� ȹ��";
    }
    public void click1Btn()
    {
        for (_count = 0; _count < 31; _count++)
        {
            int RandomStar = Star.Next(1, 101);
            if (RandomStar <= 20)
            {
                star1Count += Count.Next(20, 31);
            }
            else if (RandomStar <= 50)
            {
                star2Count += Count.Next(15, 26);
            }
            else if (RandomStar <= 90)
            {
                star3Count += Count.Next(10, 21);
            }
            else if (RandomStar <= 98)
            {
                star4Count += Count.Next(5, 11);
            }
            else if (RandomStar <= 100)
            {
                star5Count += Count.Next(1, 6);
            }
            
        }
        if (star5Count <= 1)
        {
            star5Count++;
        }

        star1.text = "1��" + star1Count + "�� ȹ��";
        star2.text = "2��" + star2Count + "�� ȹ��";
        star3.text = "3��" + star3Count + "�� ȹ��";
        star4.text = "4��" + star4Count + "�� ȹ��";
        star5.text = "5��" + star5Count + "�� ȹ��";
    }

    public void clicknujuckBtn()
    {
        for (_count = 0; _count < 31; _count++)
        {
            int RandomStar = Star.Next(1, 101);
            if (RandomStar <= 20)
            {
                star1Count += Count.Next(20, 31);
            }
            else if (RandomStar <= 50)
            {
                star2Count += Count.Next(15, 26);
            }
            else if (RandomStar <= 90)
            {
                star3Count += Count.Next(10, 21);
            }
            else if (RandomStar <= 98)
            {
                star4Count += Count.Next(5, 11);
            }
            else if (RandomStar <= 100)
            {
                star5Count += Count.Next(1, 6);
            }

        }
        if (star5Count <= 1)
        {
            star5Count++;
        }
        star1.text = "1��" + star1Count + "�� ȹ��";
        star2.text = "2��" + star2Count + "�� ȹ��";
        star3.text = "3��" + star3Count + "�� ȹ��";
        star4.text = "4��" + star4Count + "�� ȹ��";
        star5.text = "5��" + star5Count + "�� ȹ��";
        star1Count = 0;
        star2Count = 0;
        star3Count = 0;
        star4Count = 0;
        star5Count = 0;
    }
   
}
