using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discord : Window
{
    public override void clickedOn(bool type)
    {
        if (type && WindowManager.focused(this))
        {
            Application.OpenURL("https://discord.gg/Z6tkrAeXQn");
        }
        base.clickedOn(type);
    }
}
