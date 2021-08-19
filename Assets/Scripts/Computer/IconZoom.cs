using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconZoom : IconNotificationManage
{
    public override string badStatus()
    {
        LanguageLocalization<string> localization = new LanguageLocalization<string>();
        localization.addLanguage("Class has ended already.", 0);
        localization.addLanguage("คาบเรียนจบลงแล้ว", 1);
        return localization.getLanguage();
    }

    void Update()
    {
        if (time.timeDay > 5 && time.timeDay < 12)
            iconNotification.SetActive(true);
        else
            iconNotification.SetActive(false);
    }
}
