using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : Interactable
{
    protected override void Start()
    {
        base.Start();
        tcs[00] = "Stop playing games. I have other things to do right? I should be productive.";
        tcs[01] = "There's so much more that I could be doing, I shouldent be playing.";
        tcs[02] = "I feel so stupid, I'm wasting so much time playing right now.";
        tcs[03] = "I really need to stop. I should be studying, drawing... Just anything would be better";
        tcs[04] = "Do I play or not? I'm kinda bored. so I'll just play some games";
        tcs[05] = "I need to do work, I have things to do. But I'm not in the mood for that";
        tcs[06] = "Do I work, or play. I'm a bit tired right now anyways so I guess I'll play for a bit";
        tcs[07] = "I dont know if I should be playing right now. It'll be fun at least";
        tcs[08] = "This is fun, right? I should be working, but I'm playing";
        tcs[09] = "I should be studying, but I'll play a bit I guess.";
        tcs[10] = "This is fun I guess, I should stop soon. I should be more productive";
        tcs[11] = "Well last week was kinda hard I guess, I I'll take some time to chill";
        tcs[12] = "This is a fun game, I should probably do more work";
        tcs[13] = "I had was productive enought this week, I'll chill for a while.";
        tcs[14] = "This week was hard, I should take a break";
        tcs[15] = "Holy cow, I just spent to much time on this game. Welp it was fun at least";
        tcs[16] = "Man life sucks, but at least I get some time to just chill";
        tcs[17] = "This feels nice, I'm really tired so playing some games is nice.";
        tcs[18] = "Although I should probably work harder in school, I'll use this time to just chill";
        tcs[19] = "I'm so bored, this game is really fun though. Its nice to just chill";
        tcs[20] = "I guess I deserve this, right? I mean I've been working hard all week.";
    }
/*    public override void provoke()
    {
        tcsAt(player.emotions[2]);
        player.emotions[2].changeValue(-1 * Random.Range(0, 5));
        player.emotions[1].changeValue(Random.Range(0, 30));
        time.fastFowards(1);
    }*/
}
