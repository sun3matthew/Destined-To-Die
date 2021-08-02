using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesText : MonoBehaviour
{
    private MeshRenderer text;
    private SpriteRenderer parentSR;
    void Start()
    {
        text = GetComponent<MeshRenderer>();
        text.sortingLayerName = "7OSWindow";
        parentSR = transform.parent.GetComponent<SpriteRenderer>();
        LanguageLocalization<string> localization = new LanguageLocalization<string>();
        localization.addLanguage("This is another test\n\nOnline School 6am to 12pm\nRunning Practice at 12:30pm\n\nPasswords:\nEmail: NcAt3$%^\nMesg: NcAt3$%^asdf\nPortal: gHast341\n\nStudent ID: 5201229\nSSN: 260-02-1931\n\nRelationship Status: Single till I die\n\tAlso virgin for life...\n\nBut at least I have friends? Honestly\nbeing single is not bad.\n\nWhich is what a single person would say", 0);
        localization.addLanguage("这是一个测试\n\n在线学校早上 6 点到中午 12 点\n中午 12:30 跑步练习\n\n密码：\nEmail: NcAt3$%^\nMesg: NcAt3$%^asdf\nPortal: gHast341\n\n学生号码: 5201229\n\n感情状态：单身到死\n\n但至少我有朋友？\n其实单身也不错。", 1);
        localization.addLanguage("這是一個測試\n\n在線學校早上6 點到中午12 點\n中午12:30 跑步練習\n\n密碼：\nEmail: NcAt3$%^\nMesg: NcAt3$%^asdf\nPortal: gHast341 \n\n學生號碼: 5201229\n\n感情狀態：單身到死\n\n但至少我有朋友？ \n其實單身也不錯。", 2);
        GetComponent<TextMesh>().text = localization.getLanguage();
    }
    private void Update()
    {
        text.sortingOrder = parentSR.sortingOrder + 1;
    }
}
