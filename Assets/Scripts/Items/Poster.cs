using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : Interactable, Clickable
{
    protected override void Start()
    {
        base.Start();
        tcs[00] = "Fly high, I want to fly as high as I can and close my eyes.";
        tcs[01] = "I'll fly away, I'll do it, I'll fly far away. Far Far away.";
        tcs[02] = "I'm not sad. I just want to leave. Far away.";
        tcs[03] = "Fly. Fly. I have to leave. Fly away.";
        tcs[04] = "Stop caring about me, let me go. I want to go, I want to run away.";
        tcs[05] = "I want to run, run far far away, far far away...";
        tcs[06] = "Let me leave, let me run, take me.";
        tcs[07] = "Please, take me there, let me go.";
        tcs[08] = "I want to go there, I really do.";
        tcs[09] = "Why does it look so pretty";
        tcs[10] = "It looks so pretty.";
        tcs[11] = "I want to go there, It's so pretty.";
        tcs[12] = "I'll visit there, one day, when I'm older and free.";
        tcs[13] = "When I make enough money to stop caring, I'll go there.";
        tcs[14] = "It looks so pretty, I'll take someone with me if I go.";
        tcs[15] = "I'll go there when I'm a adult, when I can actually do things.";
        tcs[16] = "I need to make money, I want to move out as soon as I can.";
        tcs[17] = "I want to live alone, make my own choices, and just do what ever I want.";
        tcs[18] = "When I grow up, I'll probably travel the world, visit many places.";
        tcs[19] = "Maybe I'll have someone to go with when I grow up, that would be nice.";
        tcs[20] = "If I ever get into a relationship, I'll bring them here.";
    }
    public void clickedOn(bool type)
    {
        tcsAt(player.emotions[1]);
    }
}
