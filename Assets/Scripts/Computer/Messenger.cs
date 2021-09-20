using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messenger : InteractableWindow
{
    protected override void provoke()
    {
        player.abilities[3].changeValue(10);
    }
    protected override void initToggleMulti() => toggleMulti = 25;
}
