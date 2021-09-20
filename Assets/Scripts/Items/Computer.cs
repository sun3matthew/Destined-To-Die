using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour, Clickable
{

    public void clickedOn(bool type)
    {
        if(type)
            transform.GetChild(0).gameObject.SetActive(true);
    }
}
