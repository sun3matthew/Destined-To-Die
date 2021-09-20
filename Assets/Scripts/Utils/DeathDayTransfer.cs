using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDayTransfer : MonoBehaviour
{
    [SerializeField]
    private int day;
    private bool killMe;
    public GameObject setDay(int day)
    {
        this.day = day;
        return gameObject;
    }
    public int getDay()
    {
        killMe = true;
        if (day > 7)
            day = 7;
        return day;
    }
    private void Update()
    {
        if (killMe)
            Destroy(this.gameObject);
    }
}
