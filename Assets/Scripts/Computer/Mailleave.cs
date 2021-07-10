using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mailleave : MonoBehaviour
{
    private MeshRenderer text;
    private SpriteRenderer parentSR;
    void Start()
    {
        text = transform.GetChild(0).GetChild(1).GetComponent<MeshRenderer>();
        if (PlayerPrefs.GetInt("CatPostcards", 0) == 17 && PlayerPrefs.GetInt("GameWin", 0) == 1)
        {
            text.enabled = true;
            transform.GetChild(1).gameObject.SetActive(true);
        }
        text.sortingLayerName = "7OSWindow";
        parentSR = transform.GetChild(0).GetComponent<SpriteRenderer>();
        LanguageLocalization<string> localization = new LanguageLocalization<string>();
        localization.addLanguage("Why are you still here.\nStop playing\nThere is no point\nStop playing\nWhy do you keep playing\nThe game is finished\nMove on to your life\nThere is nothing else left in this world\nQuit\nYou have no more purpose here\nleave\nLeave this world behind\nJust leave\nPlease.", 0);
        localization.addLanguage("为什么你还在这里。\n停止玩\n没有意义\n停止玩\n你为什么继续玩\n游戏结束\n继续你的生活\n这个世界上没有其他东西了\n退出\n你没有更多了 目的在这里\n离开\n离开这个世界\n离开\n我求您。", 1);
        localization.addLanguage("為什麼你還在這裡。\n停止玩\n沒有意義\n停止玩\n你為什麼繼續玩\n遊戲結束\n繼續你的生活\n這個世界上沒有其他東西了\n退出\n你沒有更多了目的在這裡\n離開\n離開這個世界\n離開\n我求您。", 2);
        transform.GetChild(0).GetChild(1).GetComponent<TextMesh>().text = localization.getLanguage();
    }
    private void Update()
    {
        text.sortingOrder = parentSR.sortingOrder + 1;
    }
}
