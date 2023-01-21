using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;
public class MainMenuUtilities : MonoBehaviour
{
    [SerializeField]
    GameObject shit;
    private void Awake(){
        if(PlayerPrefs.GetInt("ShownContent", 0) == 0){
            PlayerPrefs.SetInt("ShownContent", 1);
            GameObject.Find("MainMenu").transform.GetChild(0).GetComponent<MenuSwitch>().contentSettings();
        }
        shit.SetActive(false);

        QualitySettings.vSyncCount = 1;

        AudioListener.volume = PlayerPrefs.GetInt("volume", 50)/100f;
        Screen.SetResolution(PlayerPrefs.GetInt("ResX", 1920), PlayerPrefs.GetInt("ResY", 1080), true);

        if(DontDestroyOnLoadManager.endType)
            transform.parent.gameObject.SetActive(false);
        DontDestroyOnLoadManager.endType = false;
        DontDestroyOnLoadManager.becomeMortal();
    }
    public void exitGame(){
        Application.Quit();
    }
}
