using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconMessenger : IconNotificationManage
{
    public override string badStatus() => "There's no one online.";

    // Update is called once per frame
    void Update()
    {
        if (time.timeDay > 9 && time.timeDay < 23.5)
            iconNotification.SetActive(true);
        else
            iconNotification.SetActive(false);
    }

}
