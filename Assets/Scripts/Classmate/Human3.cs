using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human3 : Classmate
{
    protected override void initHumanNum() => humanNum = 3;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "3 5 31 28";//to school base
        path[arrivalButNotTheMoviePartTwo] = "29";
        path[arrivalButNotTheMoviePartThree] = "23 25 2";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#F3B87E";

        tcsPos[0] = "'Do you want to accompany me to a movie sometime?'|Sure! Sounds pretty fun!|'I'll be sure to include one more seat!'";
        tcsPos[1] = "Why are the days so boring...|'I fancy you just don't have a purpose in life'|Oh.|'Just be sure to find a purpose and you will be much more happy!'";
        tcsPos[2] = "'I cannot wait for the fireworks this year!'|Oh really? I guess they are super pretty.|'The sounds too, the loud booms, the crackles. Oh I love it so much!'";
        tcsPos[3] = "'Why are so many people crazy?'|Huh?|'People sleep so late, sleeping at 11pm is already too extreme for me.'|Oh, well I think some people are just night owls? Like maybe they're more productive at night?";
        tcsPos[4] = "Hello|'Sorry, I kinda have something something on my mind right now, and I do not think I can hold a conversation right now'|Oh ok, I'll talk to you later.";
        tcsPos[5] = "'Do you enjoy watching movies?'|Uhhh, actually I don't exactly like them, they're too long I guess?|'Oh really? I'm surprised you don't'|Well I don't hate them, just not my favorite I guess.";
        tcsPos[6] = "'I'm going to the farmer's market tomorrow? Do you want to tag along?|Uhhhhh, I'm a little busy tomorrow, so probably not?|'Oh ok, that's fine!'";
        tcsPos[7] = "'Can you come to my birthday party next week?'|Uhh, yea sure! I'll try to be there.|'Awesome! I'll be expecting you!'";
    }
}
