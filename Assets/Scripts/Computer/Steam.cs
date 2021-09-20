using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steam : InteractableWindow
{
    protected override void provoke()
    {
        player.emotions[1].changeValue(40);
        player.emotions[2].changeValue(-20);
    }
    protected override void initToggleMulti() => toggleMulti = 60;
}
