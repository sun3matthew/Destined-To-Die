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
        localization.addLanguage("ทำไมคุณยังอยู่ที่นี่\nหยุดเล่นได้แล้ว\nมันไม่ได้มีค่าอะไรหรอก\nหยุดเล่นได้แล้ว\nทำไมคุณถึงยังเล่นอยู่นะ\nเกมมันจบลงแล้ว\nไปใช้ชีวิตของคุณเถอะ\nโลกใบนี้ไม่มีอะไรหลงเหลืออยู่แล้ว\nหยุดเถอะ\nคุณไม่มีเป้าหมายอะไรที่นี่อีกแล้ว\nออกเถอะ\nทิ้งโลกใบนี้ไว้ข้างหลัง\nแค่ออกไปเถอะ\nขอร้องหล่ะ", 1);
        transform.GetChild(0).GetChild(1).GetComponent<TextMesh>().text = localization.getLanguage();
    }
    private void Update()
    {
        text.sortingOrder = parentSR.sortingOrder + 1;
    }
}
