using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsInspector : MonoBehaviour
{
    [SerializeField]
    private int setTo;

    [ContextMenu("Print Prefs")]
    public void printAllPrefs()
    {
        print(PlayerPrefs.GetInt("GameWin", 0));
        print(PlayerPrefs.GetInt("CatPostcards", 0));
    }

    [ContextMenu("Set Win")]
    public void setWin() => PlayerPrefs.SetInt("GameWin", setTo);

    [ContextMenu("Set CatPS")]
    public void setCatPS() => PlayerPrefs.SetInt("CatPostcards", setTo);
}
