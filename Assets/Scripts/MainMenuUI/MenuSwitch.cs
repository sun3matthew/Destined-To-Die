using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSwitch : MonoBehaviour
{
    private Transform switchSubMenu(int keep){
        for(int i = 2; i < transform.parent.childCount; i++)
            transform.parent.GetChild(i).gameObject.SetActive(false);
        transform.parent.GetChild(keep).gameObject.SetActive(true);
        return transform.parent.GetChild(keep);
    }
    public void main() => switchSubMenu(2);
    public void load() => transform.parent.gameObject.SetActive(false);
    public void contentSettings() => switchSubMenu(3);
    public void tips() => switchSubMenu(5);
    public void settings() => switchSubMenu(4);
    public void clickedOn()
    {
        try{
            Application.OpenURL("https://store.steampowered.com/app/2189970/Exhibitors/");
        }catch{}
    }
}
