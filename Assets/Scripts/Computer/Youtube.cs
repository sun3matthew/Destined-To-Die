using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Youtube : InteractableWindow
{
    protected override void provoke()
    {
        player.emotions[1].changeValue(3);
        player.emotions[2].changeValue(-2);
    }
    protected override void initToggleMulti() => toggleMulti = 30;
}
