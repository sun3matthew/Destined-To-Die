using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MenuSettings : MonoBehaviour
{
    [SerializeField]
    private Text volumeText;
    [SerializeField]
    private Text resText;
    [SerializeField]
    private Text languageText;
    private int idx;

    private static string[] languageToString = new string[]{
        "english",
        "ภาษาไทย\nby Tidamard Malaithong",
        "français\nby Dorian"
    };
    private void Start() {
        volumeText.text = "Volume: " + (int)(AudioListener.volume * 100);
        resText.text = Screen.currentResolution.width + ":" + Screen.currentResolution.height;
        languageText.text = "Language: " + languageToString[PlayerPrefs.GetInt("Language", 0)];

        idx = Screen.resolutions.Length - 1;
        for(int i = 0; i < Screen.resolutions.Length; i++){
            if(Screen.resolutions[i].width == Screen.currentResolution.width && Screen.resolutions[i].height == Screen.currentResolution.height){
                idx = i;
                i = Screen.resolutions.Length;
            }
        }
    }
    
    public void DeleteSave(){
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }

    public void increaseVolume(){
        AudioListener.volume += 0.1f;
        if(AudioListener.volume > 1.0f)
            AudioListener.volume = 1.0f;
        volumeText.text = "Volume: " + (int)(AudioListener.volume * 100);
        PlayerPrefs.SetFloat("Volume", AudioListener.volume);
    }

    public void decreaseVolume(){
        AudioListener.volume -= 0.1f;
        if(AudioListener.volume < 0f)
            AudioListener.volume = 0f;
        volumeText.text = "Volume: " + (int)(AudioListener.volume * 100);
        PlayerPrefs.SetFloat("Volume", AudioListener.volume);
    }

    public void NextRes(){
        idx--;
        if(idx < 0)
            idx = 0;
        resText.text = Screen.resolutions[idx].width + ":" + Screen.resolutions[idx].height;
    }

    public void lastRes(){
        idx++;
        if(idx >= Screen.resolutions.Length)
            idx = Screen.resolutions.Length - 1;
        resText.text = Screen.resolutions[idx].width + ":" + Screen.resolutions[idx].height;
    }

    public void nextQuality(){
        int currQ = PlayerPrefs.GetInt("Language", 0);
        currQ++;
        if(currQ >= Language.languageAmt)
            currQ = 0;
        PlayerPrefs.SetInt("Language", currQ);
        languageText.text = "Language: " + languageToString[PlayerPrefs.GetInt("Language", 0)];

    }
    public void setRes(){
        PlayerPrefs.SetInt("ResX", Screen.resolutions[idx].width);
        PlayerPrefs.SetInt("ResY", Screen.resolutions[idx].height);
        Screen.SetResolution(PlayerPrefs.GetInt("ResX", 1920), PlayerPrefs.GetInt("ResY", 1080), true);
    }
}
