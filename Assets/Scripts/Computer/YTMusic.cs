using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YTMusic : InteractableWindow
{
    protected override void provoke()
    {
        player.emotions[1].changeValue(player.emotions[1].getValue()*0.1f);
    }
    protected override void initToggleMulti() => toggleMulti = 5;
}
