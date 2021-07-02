using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class SeasonChange : MonoBehaviour
{
    private int currSeason = -1;
    private TimeDay time;
    void Start() => time = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();

    // Update is called once per frame
    void Update()
    {
        if(time.day/2 != currSeason)
        {
            currSeason = time.day / 2;
            for (int i = 0; i < 4; i++)
                transform.GetChild(i).gameObject.SetActive(false);

            if(currSeason > 3)
                transform.GetChild(3).gameObject.SetActive(true);
            else
                transform.GetChild(currSeason).gameObject.SetActive(true);

            if(currSeason == 3)
            {
                if(SteamManager.Initialized)
                {
                    SteamUserStats.SetAchievement("RAIN");
                    SteamUserStats.StoreStats();
                }
            }
        }
    }
}
