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
        Rubysmessage.text = "���" + 0 + "��";
        GoldMessage.text = "���" + 0 + "��";
        EmeraldMessage.text = "���޶���" + 0 + "��";
    }
    public void ButtonClick()
    {
        int BoxRandomCount = Count.Next(1, 101);
        int BoxRandomGoods = Goods.Next(1, 4);
        switch(BoxRandomGoods)
        {
            case 1:
                _rubycount += BoxRandomCount;
                Rubysmessage.text = "���" + _rubycount.ToString() + "��";
                break;
            case 2:
                _emeraldcount += BoxRandomCount;
                EmeraldMessage.text = "���޶���" + _emeraldcount.ToString() + "��";
                break;
            case 3:
                _goldcount += BoxRandomCount;
                GoldMessage.text = "���" + _goldcount.ToString() + "��";
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
        Rubysmessage.text = "���" + _rubycount.ToString() + "��";
        EmeraldMessage.text = "���޶���" + _emeraldcount.ToString() + "��";
        GoldMessage.text = "���" + _goldcount.ToString() + "��";
    }

    public void ClearAll()
    {
        Rubysmessage.text = "���" + 0 + "��";
        GoldMessage.text = "���" + 0 + "��";
        EmeraldMessage.text = "���޶���" + 0 + "��";
        _Count = 0;
        _goldcount = 0;
        _emeraldcount = 0;
        _rubycount = 0;

    }







}