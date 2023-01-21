using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGShifter : MonoBehaviour
{
    [SerializeField]
    private Sprite[] backgrounds;
    [SerializeField]
    private Sprite[] backgrounds2;

    void Start(){
        if(PlayerPrefs.GetInt("CatPostcards", 0) >= 17){
            backgrounds = backgrounds2;
        }
        gameObject.GetComponent<Image>().sprite = backgrounds[Random.Range(0, backgrounds.Length)];   
    }
}
