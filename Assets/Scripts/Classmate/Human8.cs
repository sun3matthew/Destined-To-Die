using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human8 : Classmate
{
    protected override void initHumanNum() => humanNum = 8;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie-1] = "3 19 35 41";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "42";
        path[arrivalButNotTheMoviePartThree + 2] = "31 14 6 0";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#F59D78";

        tcsPos[0] = "'Hey!'|Hi?|'How was your day?'|Oh uh, pretty good|'Come on!! Keep going!'|Well I woke up pretty early so that was nice I guess?|'Okkkk, you should talk more!'|Right";
        tcsPos[1] = "'How was your day?'|I uh, It was pretty good|'How can you forget!'|What?|'Tell me more!!'|Well the sun looked nice today I guess|'Hey! That's basically what you said yesterday!'|Welp sucks to be you I guess";
        tcsPos[2] = "'Hellooooo~'|Heyo|'How was your day fine sir?'|Uhhhm It was good, I did some stuff I guess|'Okkkkkk, Keep going!'|Well my knee kinda hurts, but I think I can still run|'Awwww man that sucks!'";
        tcsPos[3] = "'Yoooohooooo!'|How do you keep coming up with these new greetings?|'Hmm? I just always say these things!'|I feel like this time it was new?|'Whaaat??? That's so rude!'|Wait it was a, it was a complement?|'Hmph! It doesn't sound like it!";
        tcsPos[4] = "Hello|'Hmph! Why can't you try a new greeting once in a while!'|I- wait I can't tell if you're actually mad at me?|'Hehe... Of course not! I was just playing with you~'|Oh ok, I thought I actually did a bad thing";
        tcsPos[5] = "Good afternoon?|'Goodbye'|Oh,... Ok? I'm sorry?|'Hehe, did I scare ya?'|Ah ok, well you did a little I guess.|'Hehe!'";
        tcsPos[6] = "'Howdy!'|That's a new one.|'Come on!! I said it to you last time we spoke!'|Oh, Whoops I guess I forgot. My memory sucks these days...|'Agreed! Well hopefully you remember next time you talk to me!'";
        tcsPos[7] = "Hey|'Hellooo!'|That's- How was your day?|'It was horrible! I woke up late to my first class, then my mommy yelled at me! Then I spilled boba all over my lap!'|Ah, that uh, that sucks|'Yea, it did.'";

    }
}
