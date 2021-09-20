using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : Interactable
{
    protected override void Start()
    {
        base.Start();
        
        tcs[00] = "I don't think people like talking to me, I mean it makes sense I guess.";
        tcs[01] = "I like talking to other pepole right?";
        tcs[02] = "I should talk to them, it's for my own sake anyways.";
        tcs[03] = "Do I talk to them? Will they judge me?";
        tcs[04] = "How do I talk to them? Do I just say hi?";
        tcs[05] = "I feel weird talking, but this is enjoyable at least";
        tcs[06] = "I wonder if my friends will still like talking to me.";
        tcs[07] = "How do I make more friends, I mean its fun talking to my online friends";
        tcs[08] = "I shouldent overthing anything, we're just friends. I enjoy talking to her";
        tcs[09] = "I don't know how to respond to this message, should I be more happy?";
        tcs[10] = "I wonder what my friends are doing, I'll check the group chat";
        tcs[11] = "Maybe I should try to talk to her. Whats the worst that could happen";
        tcs[12] = "I really like talking to my friends, it's fun! Although I only talk to a few";
        tcs[13] = "Am I using too much time talking to my friends? I mean its really fun!";
        tcs[14] = "I love my friends so much. It's so fun talking to them";
        tcs[15] = "I wish they responded to me faster, but I guess they have things to do";
        tcs[16] = "I really like talking to her. but I don't know if I like her. Maybe?";
        tcs[17] = "My friends are awsome! I really enjoy talking to them";
        tcs[18] = "I'm probably going to lose them one day, but I'll cherish the time we have now";
        tcs[19] = "I wish I can get closer to some of my friends. But I don't know how";
        tcs[20] = "I love my friends so much. They make me feel so warm inside.";
    }
    /*public override void provoke()
    {
        tcsAt(player.abilities[3]);
        player.abilities[3].changeValue(Random.Range(0, 10));
        player.emotions[2].changeValue(Random.Range(0, 3));
        time.fastFowards(0.5f);
    }*/
}
