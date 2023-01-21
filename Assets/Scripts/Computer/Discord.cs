using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discord : Window
{
    public override void clickedOn(bool type)
    {
        if (type && WindowManager.focused(this))
        {
            try{
                Application.OpenURL("https://discord.gg/Z6tkrAeXQn");
            }catch{}
            //Application.OpenURL("https://discord.gg/yhFQS2kUQu");
        }
        base.clickedOn(type);
    }
}
