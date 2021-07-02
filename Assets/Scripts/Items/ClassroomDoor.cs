using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassroomDoor : Interactable
{
    public bool onTimeActive = true;

    private Sprite refH;
    protected override void Start()
    {
        base.Start();
        tcs[00] = "Why? Why do I do this. I'm so scared. I don't want to die, right? I hate myself so much";
        tcs[01] = "I don't want to die, why dosen't it hurt? Just. Hurt. Why don't you hurt.";
        tcs[02] = "The blood, it's so red. I just want to see the blood. Stop. Just stop. I can't...";
        tcs[03] = "I'm so scared, so much blood. It hurts, I don't wan't to die.";
        tcs[04] = "I need this, it hurts so so much, why? Why do I do this. Why.|It hurts, blood, I want to see it.";
        tcs[05] = "I'll stop in the future, but I need this. Not enough blood, more... more...|I hate this so much, I hate it. But I need it, I just want to feel pain.";
        tcs[06] = "I don't want to, I don't think I should do this|Why do I want this, I'm fine, I'm fine. It hurts so much, it stings.";
        tcs[07] = "Why, I shoulden't... No, no, no, no... it hurts so much|I just want to feel something, just something. I want... I don't know...";
        tcs[08] = "I don't want to, I'm not sad right? Maybe? This is bad, it hurts.|It stings so much, why, why...|I hate everything so much, what is happening, it hurts so much";
        tcs[09] = "I.. I... Am I sad? I but the last few days were so good. I can't I wont|No, I don't... Just... I don't want to.";
        tcs[10] = "Fuck school lmao";
        tcs[11] = "Today is so good, why? I'm not sad, am I? Am I sad?";
        tcs[12] = "I'm not sad, I'm not sad. I'm not sad, no. I'm fine.";
        tcs[13] = "I don't want to, I'm not sad.";
        tcs[14] = "Why now? My life is amazing right now, right?";
        tcs[15] = "I'm happy, right? I don't need this";
        tcs[16] = "I'm good, I think I'll pass";
        tcs[17] = "This knife was a gift, man it's been a few years";
        tcs[18] = "I should sharpen my knife sometime, it's getting dull";
        tcs[19] = "I need a new knife, it's too dull";
        tcs[20] = "It's a nice knife, I need to sharpen it again. Its too dull";
        //refH = high;
    }
    /*public override void provoke()
    {
        if (!onTimeActive)
        {
            Cutscene.cutscene("It's not class yet");
            return;
        }
        tcsAt(player.emotions[6]);
        time.fastFowards(0.75f);
    }*/
    public void enableClassRoom()
    {
        onTimeActive = true;
        //high = refH;
    }
    public void disableClassRoom()
    {
        onTimeActive = false;
        //high = uhigh;
    }
}
