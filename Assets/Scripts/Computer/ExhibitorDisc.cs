using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitorDisc : Window
{
    public override void clickedOn(bool type)
    {
        if (type && WindowManager.focused(this))
        {
            try{
                Application.OpenURL("https://discord.gg/yhFQS2kUQu");
            }catch{}
        }
        base.clickedOn(type);
    }
}
