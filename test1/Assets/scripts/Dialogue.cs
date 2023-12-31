using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Dialogue : MonoBehaviour
{
    int descNum;
    public TextMeshProUGUI descTextName;
    public TextMeshProUGUI descTextTalk;
    public Button Btn1;
    public Sprite DefaultBG;
    public Sprite changeBG;
    public Image BG;

    public Image snow;
    public Image kawa;
    public Sprite snow1;
    public Sprite snow2;
    public Sprite kawa1;
    public Sprite kawa2;


    public void ChangeDesc()
    {
        if (descNum == 0)
        {
            BG.sprite = DefaultBG;
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "尽姥幻";
            Btn1.gameObject.SetActive(true);
            kawa.sprite = kawa1;
            snow.sprite = snow1;
        }
        else if (descNum == 1)
        {
            descTextName.text = "什葛酔耕庭";
            descTextTalk.text = "益掘 尽陥";
            
        }
        else if (descNum == 2)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "神潅 更馬叔?";
            kawa.sprite = kawa2;
        }
        else if (descNum == 3)
        {
            descTextName.text = "什葛酔耕庭";
            descTextTalk.text = "剛股切軒";
            
        }
        else if (descNum == 4)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "しせしせ";
            kawa.sprite = kawa1;
        }
        else if (descNum == 5)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "更股生叔?";
            kawa.sprite = kawa2;
        }
        else if (descNum == 6)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "原虞伝 股生叔?";
            
        }
        else if (descNum == 7)
        {
            descTextName.text = "什葛酔耕庭";
            descTextTalk.text = "焼;; 拭郊汽什;;";
            snow.sprite = snow2;
        }
        else if (descNum == 8)
        {
            descTextName.text = "什葛酔耕庭";
            descTextTalk.text = "原虞伝 鯵 駅曝汽什;;";
            
        }
        else if (descNum == 9)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "あげあげ";
            kawa.sprite = kawa1;
        }
        else if (descNum == 10)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "益軍 更股聖闇汽 艦亜 舛背";
            kawa.sprite = kawa2;
        }
        else if (descNum == 11)
        {
            descTextName.text = "什葛酔耕庭";
            descTextTalk.text = "製.. 娠怯 ぁ?";
            snow.sprite = snow1;
        }
        else if (descNum == 12)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "しせしせ.";
            kawa.sprite = kawa1;
        }
        else if (descNum == 13)
        {
            descTextName.text = "什葛酔耕庭";
            descTextTalk.text = "娠怯殖 社爽走";
            
        }
        else if (descNum == 14)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "紬. 察均 佐蟹降 嬢橋?";
            kawa.sprite = kawa2;
        }
        else if (descNum == 15)
        {
            descTextName.text = "什葛酔耕庭";
            descTextTalk.text = "慨今球走";
            
        }
        else if (descNum == 16)
        {
            BG.sprite = changeBG;
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "焼 ぉし 昼馬革 せせ";
            kawa.sprite = kawa1;
        }

        else if (descNum == 17)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "綬極 繕走君 亜醤畏陥";
            
        }
        else if (descNum == 18)
        {
            descTextName.text = "什葛酔耕庭";
            descTextTalk.text = "希君錘 歯晦. 陥橿神疾";
            snow.sprite = snow2;
        }
        else if (descNum == 19)
        {
            descTextName.text = "朝人戚耕庭";
            descTextTalk.text = "しし";
            
        }
        else
        {
            Btn1.gameObject.SetActive(true);
            
        }
        if (descNum == 19)
        {
            descNum = 0;
        }
        else
        {
            descNum++;
        }


    }
}
