using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human4 : Classmate
{
    protected override void initHumanNum() => humanNum = 4;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "3 14 37 30";//to school base
        path[arrivalButNotTheMoviePartTwo+1] = "30";
        path[arrivalButNotTheMoviePartThree] = "21 0";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#CEE465";

        tcsPos[0] = "'*Yawn* I woke up way to early'|How many hours of sleep did you get?|'eight'|That's pretty normal, how much do you usually sleep?|'Nine and a half'|That's honestly pretty impressive|'I have mastered the art of sleeping!'";
        tcsPos[1] = "'I think I might have caught a cold'|What happened?|'I'm just feeling totally under the weather.'|Did you just not sleep enough?|'I can never get enough sleep, but it might be part of the problem'|Well I hope you get better soon?";
        tcsPos[2] = "'Why is it always so bright in the morning, my eyes hurt.'|Do you enjoy sleeping in?|'Of course!! It's soooooo nice!'|Wait, how much do you sleep in during the weekends?|'...Um... I don't know, maybe 3?'|I'm sorry what?";
        tcsPos[3] = "Why do you like eating so much?|'I've been on the hunt for the best tasting food! You have to find it somehow!'|I see, well what's the best right now?|'I've forgotten'|Doesn't that defeat the whole quest?|'What??? I'll know it when I taste it!'|Well let me know when you find it.";
        tcsPos[4] = "How often do you eat out?|'Well...Maybe once or twice a day?'|Wait, how do you fit two in a day? And doesn't it cost lots?|'Guess what? Once I even had 5 in a day!'|I'm both impressed, and concerned.|'I guess it costs a lot too, but it's well worth it!";
        tcsPos[5] = "'Oh, good! I've been looking all over for you!'|Really? why?|'*Yawn* But first, why do we need to get up so early in the morning all the time?'|Because education is important?|'Hmmm... Why can't it all be just shifted back a few hours!|Well not everyone sleeps in as much as you";
        tcsPos[6] = "'Oh, hiya!'|That's new|'You think? It's something I heard in a tv commercial'|What kind of ad was it?|'Hey, what are you implying here?'|Was it a food commercial?|'I was going to offer you a snack, but not anymore!'|Oh ok, well I guess sucks to be me.|'Aw, I was hoping you would beg!'|Lmao, I'll pass";
        tcsPos[7] = "'Hey! Something about today feels weird'|Oh really?|'*Yawn* I think I just didn't sleep or eat enough'|Oh, makes sense I guess|'Anyways I have to get going now! Goodbye!'";
    }
}
