using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : Interactable
{
    protected override void Start()
    {
        base.Start();  
        tcs[00] = "I'm so lost, school is so hard, I'm a lost cause.";
        tcs[01] = "What am I doing, I'll probably fail the test anyways";
        tcs[02] = "Theres other things I could be doing, but I'm just here trying to find the signifigance of a stupid book";
        tcs[03] = "I don't want to work anymore, this assignment is to hard";
        tcs[04] = "My grades are low... I really don't want my parents to yell at me";
        tcs[05] = "I don't want to do anything, I suck enough already.";
        tcs[06] = "This sucks so much, I'll never even use these things in real life";
        tcs[07] = "I'm really not in the mood for this. I'm really tired.";
        tcs[08] = "I'll just do the homework, I'll get it over with";
        tcs[09] = "Why do I even need to learn these things. This is so boring.";
        tcs[10] = "Man stem courses are actually hard. I need to study more for them";
        tcs[11] = "Math sucks, but I guess it's useful? I mean when will I need to find where a function is positive in real life";
        tcs[12] = "I'm doing this for myself, I want better grades, I'll work harder in school";
        tcs[13] = "What am I doing? I have no idea what I'm doing, I'll just BS this assignment";
        tcs[14] = "I really don't want to take that test tommarow, I'll probably fail it.";
        tcs[15] = "I mean this cass isn't that hard anymore I guess. But I should still study, but just not as much";
        tcs[16] = "There's so much stuff I need to do. It'll take me a while to do.";
        tcs[17] = "This is for my future, I need good grades for a good collage.";
        tcs[18] = "I hate school so much, but its not that bad. I'll just finish the work.";
        tcs[19] = "I'm doing this for my own good right? I should try to bring my grades even higher";
        tcs[20] = "Do I really need to study more? I mean I guess my grades could go higher.";
    }
    /*public override void provoke()
    {
        if (player.emotions[3].getValue() < -50)
        {
            tcsAt("I'm a bit too tired to work right now|I'm way to tired to do anything");
            return;
        }
        tcsAt(player.abilities[2]);
        player.abilities[2].changeValue(Random.Range(0, 10));
        player.emotions[2].changeValue(Random.Range(-2, 9));
        player.emotions[3].changeValue(-50);
        time.fastFowards(2);
    }*/
}
