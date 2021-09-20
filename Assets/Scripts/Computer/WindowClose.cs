using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowClose : MonoBehaviour, Clickable
{
    public void clickedOn(bool type)
    {
        if (type)
            transform.parent.parent.gameObject.GetComponent<Window>().turnOff();//SetActive(false);
    }
}
