using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class SeasonChange : MonoBehaviour
{
    private int currSeason;
    private Player time;
    void Start() {
        time = GameObject.Find("Player(Clone)").GetComponent<Player>();

        currSeason = (time.falseDay == 6 ? 2 : time.falseDay / 2);
        for (int i = 0; i < 4; i++)
            transform.GetChild(i).gameObject.SetActive(false);
        transform.GetChild(currSeason).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if((time.falseDay == 6 ? 2 : time.falseDay/2) != currSeason)
        {
            currSeason = time.falseDay / 2;

            for (int i = 0; i < 4; i++)
                transform.GetChild(i).gameObject.SetActive(false);

            transform.GetChild(currSeason).gameObject.SetActive(true);

            if(currSeason == 3 && PlayerPrefs.GetInt("RAIN", 0) == 0)
            {
                PlayerPrefs.SetInt("RAIN", 1);
                if(SteamManager.Initialized)
                {
                    SteamUserStats.SetAchievement("RAIN");
                    SteamUserStats.StoreStats();
                }
            }
        }
    }
}
