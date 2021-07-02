using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IconNotificationManage : MonoBehaviour
{
    // Start is called before the first frame update
    protected TimeDay time;
    protected GameObject iconNotification;
    void Start()
    {
        time = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();
        iconNotification = transform.GetChild(1).gameObject;
    }
    public abstract string badStatus();
}
