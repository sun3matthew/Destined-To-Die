using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human6 : Classmate
{
    protected override void initHumanNum() => humanNum = 6;
    protected override void initPersonality() => personalityType = 1;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "1 21 44";//to school base
        path[arrivalButNotTheMoviePartTwo] = "41";
        path[arrivalButNotTheMoviePartThree + 2] = "19 1";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#F6AFD3";

        tcsPos[0] = "'I love to yak!'|I can tell, I feel like you're the only person I know who uses the word yak|'No way! Back from my town, we say it all the time! Do you people really not use it?'|Nope, maybe it's too, uhhh, I don't know. Weird?|'Haha! Well I'll just keep saying it!'|It makes you unique I guess?";
        tcsPos[1] = "'DID YOU CLONE YOURSELF??'|What?|'I saw you so many times today!'|Well uh, I did not clone myself|'I doooon't believe you~!'|I mean like, I don't think it was me but maybe I just moved fast?|'NO! You had different shirts!'|...So how did you know it was me?|'The way you walk! You have a terrible slouch!'|Ah. Are you high?";
        tcsPos[2] = "'Oh my gosh, you again!'|This is the first time we saw each other- Are you on about the cloning thing again?|'I promise! They look just like you!!!'|I really can't tell if you're joking...|'I promiseeeeeee! Why would I lie to you!'|I'll just conclude that you're blind.";
        tcsPos[3] = "'Hello again!'|What's your vision?|'Huh? 20 20?'|I don't understand...|'I don't know what you're referring to. Anyways, isn't the sun super nice today!'|Ehhhh, I don't really like the sun, it's just too bright and too hot.|'Awwwww man! But the sun rays! They're so nice!'";
        tcsPos[4] = "'I'm so sleepy today...'|When did you sleep?|'Oh My Gosh, like 1 am or something!'|Ah, what were you doing until then?|'Well I just could not fall asleep! My mind was constantly running!'|What were you thinking about?|'Ha! I don't think I'll tell you~'";
        tcsPos[5] = "'Gah! Oh it's just you. Do you go shopping much?'|Uhhh, not often. Why?|'Oh I was just wondering! When was the last time you went shopping?'|Like not recent? Maybe like a year- Wait like for clothing right?|'What else would you buy?'|Uhhh, wood?";
        tcsPos[6] = "'I wish the sun was up for longer!'|Well maybe you should wake up earlier, then you can see the sun from sunrise to sunset!|'Noooooo! I don't like the sun that much... I can't wake up early!'";
        tcsPos[7] = "'I think I might be moving soon'|Wait what? really? When?|'Hey, calm down! It's not anything you have to stress about! It's not that soon and we can still talk online!'|Yea I guess...";
    }
}
