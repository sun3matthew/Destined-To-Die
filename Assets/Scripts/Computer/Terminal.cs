using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : InteractableWindow
{
    protected override void provoke()
    {
        player.abilities[1].changeValue(5);
    }
    protected override void initToggleMulti() => toggleMulti = 60;
}
