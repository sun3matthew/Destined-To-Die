using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : InteractableWindow
{
    protected override void provoke()
    {
        player.abilities[2].changeValue(4);
    }
    protected override void initToggleMulti() => toggleMulti = 75;
}
