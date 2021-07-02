using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour, Clickable
{
    public void clickedOn(bool type)
    {
        if(type)
        {
            transform.parent.gameObject.SetActive(false);
            WindowManager.closeAllToggle();
        }
    }
}
