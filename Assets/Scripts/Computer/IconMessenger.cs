using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconMessenger : IconNotificationManage
{
    public override string badStatus() {
        LanguageLocalization<string> localization = new LanguageLocalization<string>();
        localization.addLanguage("There's no one online.", 0);
        localization.addLanguage("网上没人。", 1);
        localization.addLanguage("網上沒人。", 2);
        return localization.getLanguage();
    }

    // Update is called once per frame
    void Update()
    {
        if (time.timeDay > 9 && time.timeDay < 23.5)
            iconNotification.SetActive(true);
        else
            iconNotification.SetActive(false);
    }

}
