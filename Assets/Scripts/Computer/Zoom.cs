using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : InteractableWindow
{
    protected override void provoke()
    {
        player.wentToClass = true;
        player.abilities[2].changeValue(14);
    }
    protected override void initToggleMulti() => toggleMulti = 60;
}
