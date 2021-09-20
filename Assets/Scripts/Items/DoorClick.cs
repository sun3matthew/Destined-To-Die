using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClick : MonoBehaviour, Clickable
{
    public void clickedOn(bool type)
    {
        if (type)
            GameObject.Find("Door").GetComponent<RoomDoor>().provoke();
    }
}
