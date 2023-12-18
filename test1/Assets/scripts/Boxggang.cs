using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Boxggang : MonoBehaviour
{
    public Button RandomBtn;
    public Button Random100Btn;
    public Text Rubysmessage;
    public Text GoldMessage;
    public Text EmeraldMessage;
    public Button ClearBtn;

    int _Count = 0;
    int _goldcount = 0;
    int _emeraldcount = 0;
    int _rubycount = 0;

    System.Random Count = new System.Random();
    System.Random Goods = new System.Random();

    public void Start()
    {
        Rubysmessage.text = "루비" + 0 + "개";
        GoldMessage.text = "골드" + 0 + "개";
        EmeraldMessage.text = "에메랄드" + 0 + "개";
    }
    public void ButtonClick()
    {
        int BoxRandomCount = Count.Next(1, 101);
        int BoxRandomGoods = Goods.Next(1, 4);
        switch(BoxRandomGoods)
        {
            case 1:
                _rubycount += BoxRandomCount;
                Rubysmessage.text = "루비" + _rubycount.ToString() + "개";
                break;
            case 2:
                _emeraldcount += BoxRandomCount;
                EmeraldMessage.text = "에메랄드" + _emeraldcount.ToString() + "개";
                break;
            case 3:
                _goldcount += BoxRandomCount;
                GoldMessage.text = "골드" + _goldcount.ToString() + "개";
                break;
        }
        
    }

    public void ButtonClick100()
    {
        for(_Count = 0;_Count < 101 ;)
        {
            int BoxRandomCount = Count.Next(1, 101);
            int BoxRandomGoods = Goods.Next(1, 4);
            switch (BoxRandomGoods)
            {
                case 1:
                    _rubycount += BoxRandomCount;
                    
                    break;
                case 2:
                    _emeraldcount += BoxRandomCount;
                    
                    break;
                case 3:
                    _goldcount += BoxRandomCount;
                    
                    break;
            }
            _Count++;
        }
        Rubysmessage.text = "루비" + _rubycount.ToString() + "개";
        EmeraldMessage.text = "에메랄드" + _emeraldcount.ToString() + "개";
        GoldMessage.text = "골드" + _goldcount.ToString() + "개";
    }

    public void ClearAll()
    {
        Rubysmessage.text = "루비" + 0 + "개";
        GoldMessage.text = "골드" + 0 + "개";
        EmeraldMessage.text = "에메랄드" + 0 + "개";
        _Count = 0;
        _goldcount = 0;
        _emeraldcount = 0;
        _rubycount = 0;

    }







}