using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System;

public class MenuNewGame : MonoBehaviour//* Content Settings
{
    [SerializeField]
    private Text DiffText;
    [SerializeField]
    private Text ContentText;
    [SerializeField]
    private Text SpeedText;

    private static string[] diffToString = new string[]{
        "Easy",
        "Normal",
        "Hard"
    };
    private void Start() {
        DiffText.text = "Difficulty: " + diffToString[PlayerPrefs.GetInt("Difficulty", 1)];
        ContentText.text = "Triggering Content: " + (PlayerPrefs.GetInt("Censored", 0) == 0 ? "Yes" : "No");
        SpeedText.text = "Game Speed: " + (PlayerPrefs.GetInt("Speed", 1) == 0 ? "Normal" : "Fast");
    }
    public void UpdateDiff(){
        int currDiff = PlayerPrefs.GetInt("Difficulty", 1);
        currDiff++;
        if(currDiff > 2)
            currDiff = 0;
        PlayerPrefs.SetInt("Difficulty", currDiff);
        DiffText.text = "Difficulty: " + diffToString[PlayerPrefs.GetInt("Difficulty", 1)];
    }
    public void UpdateContent(){
        int currDiff = PlayerPrefs.GetInt("Censored", 0);
        currDiff++;
        if(currDiff > 1)
            currDiff = 0;
        PlayerPrefs.SetInt("Censored", currDiff);
        ContentText.text = "Triggering Content: " + (PlayerPrefs.GetInt("Censored", 0) == 0 ? "Yes" : "No");
    }
    
    public void UpdateSpeed(){
        int currDiff = PlayerPrefs.GetInt("Speed", 1);
        currDiff++;
        if(currDiff > 1)
            currDiff = 0;
        PlayerPrefs.SetInt("Speed", currDiff);
        SpeedText.text = "Game Speed: " + (PlayerPrefs.GetInt("Speed", 1) == 0 ? "Normal" : "Fast");
    }

}
