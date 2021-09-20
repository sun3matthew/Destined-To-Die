using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet : Interactable
{
    protected override void Start()
    {
        base.Start();
        tcs[00] = "Is this fun? I suck at drawing so much. It looks like shit";
        tcs[01] = "It looks like shit. Why do I do this, I give up.";
        tcs[02] = "I need to work on other things, I'm a lost cause when it comes to art";
        tcs[03] = "I hate it so much, why am I drawing. It's fun though, I guess";
        tcs[04] = "Everyone's is so much better then mine, I wish I never stopped drawing for such a long time";
        tcs[05] = "I was so good at art when I was small, what happened? Man I suck.";
        tcs[06] = "Why does it look so bad, It's too colorful, the composition sucks, the idea sucks.";
        tcs[07] = "I need to get better at drawing, it's been a while";
        tcs[08] = "This is probably good enough, it looks okay I guess";
        tcs[09] = "It looks so weird, man I was so good before";
        tcs[10] = "I don't know what I want to draw, maybe some random landscape?";
        tcs[11] = "I want to try a new style, it looks cool";
        tcs[12] = "Hey, thats not bad I guess, maybe I could fix the colors a bit.";
        tcs[13] = "I should try to improve my sketching skills, I mean its fun anyways";
        tcs[14] = "Damn! Thats so bad, I'm satisfied with this";
        tcs[15] = "Drawing is so fun, although it's time consuming. Worth it!";
        tcs[16] = "I should try to hone in my skills, I need to make my own style";
        tcs[17] = "Hmmm maybe I can improve on my composition, but I mean, it looks good!";
        tcs[18] = "Holy, that looks awsome!!! That'll be my new wallpaper";
        tcs[19] = "I should print this and frame it, it looks really nice";
        tcs[20] = "I love the colors! Wow, this is really cool.";
    }
    /*public override void provoke()
    {
        if (player.emotions[3].getValue() < -30)
        {
            tcsAt("I'm a bit too tired to draw right now|I'm way to tired to do anything");
            return;
        }
        player.abilities[0].changeValue(Random.Range(0, 5));
        tcsAt(player.abilities[0]);
        player.emotions[0].changeValue(Random.Range(-3, 5));
        player.emotions[2].changeValue(Random.Range(-1, 2));
        player.emotions[3].changeValue(-15);
        time.fastFowards(4);
    }*/
}
