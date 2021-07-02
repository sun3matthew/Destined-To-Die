using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procreate : InteractableWindow
{
    protected override void provoke()
    {
        player.abilities[0].changeValue(8);
    }
    protected override void initToggleMulti() => toggleMulti = 75;
}
