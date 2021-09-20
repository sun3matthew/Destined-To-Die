using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Steamworks;

public class SteamAchivements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(SteamManager.Initialized);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //SteamUserStats.ResetAllStats(true);
            //print(SteamUserStats.SetAchievement("RAIN") + ":TEST");
            //SteamUserStats.StoreStats();
        }
    }
}
