using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human2 : Classmate
{
    protected override void initHumanNum() => humanNum = 2;
    protected override void initPersonality() => personalityType = 1;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie+1] = "1 13 37";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "38";
        path[arrivalButNotTheMoviePartThree+2] = "19 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#95E9BF";

        tcsPos[0] = "'The sun's really bright today, don't you think?'|Uhm, it looks fairly...Normal?|'You know you should look up more, you'll get back pains if you keep looking down'|Well I already have back pains|'Do you want a massage?'|What? No";
        tcsPos[1] = "'Hey! How's it going?'|How do I actually respond to that?|'You know, \"Good\", \"Bad\", things like that?'|Good|'And... Keep going'|Not really in the mood|'Whaaa... thats too bad'|Sucks to be you I guess";
        tcsPos[2] = "'I had a super weird dream last night, but it's a little embarrassing'|What is it?|'Nooooooo, it's too embarrassing!'|Okay, then don't say it|'Noooo you're supposed to keep asking!'|Uhh, W-Whats the dream?|'Nevermind, now I feel like I just forced you'|Uhh, how do I respond now|'...Just, Nevermind'";
        tcsPos[3] = "'What up!'|What... up?|'It's going to rain soon!'|Oh, really?|'Yeah, well rainy days are special!'|So you like it when it rains?|'mHm!'|Yea, I like the rain too, and I love running in the rain.|'Running? Do you want to get a cold? Don't do that!'";
        tcsPos[4] = "'I need some good prank ideas!'|Why?|'Geez, it's my final year here! I want to have some fun!|Why do I think you're going to do something dangerous|'Whaa? You're the one that's going to hurt yourself!'|Right... Since you're the more responsible one|'I don't like the tone of your voice!~";
        tcsPos[5] = "'Perfect Timing! I was just thinking about you!'|You were... What?|'I had another dream, you were in it!'|What was I doing in your dream?|'I won't tell you~'|I'm concerned|'Fineee, I'll tell you, but just make sure you don't laugh!'";
        tcsPos[6] = "'Do you ever shop?'|Huh? I guess I buy stuff online, but not really in real life|'There's a farmer market tomorrow! Wanna come? I have a group of friends coming'|Oh. Uh, I'll be busy tomorrow|'All day? You should take some time to relax a little! If you don't get enough rest, you'll get wrinkles and white hair!'|Thanks for your concern";
        tcsPos[7] = "Hey, How have you been doing?|'Great! The weather is really nice today! Don't you think?'|Yea I guess..|'You look so gloomy today, cheer up!'|I'll try, talk to you later.";
    }
}
