using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconZoom : IconNotificationManage
{
    public override string badStatus() => "Class has ended already.";

    void Update()
    {
        if (time.timeDay > 5 && time.timeDay < 12)
            iconNotification.SetActive(true);
        else
            iconNotification.SetActive(false);
    }
}
