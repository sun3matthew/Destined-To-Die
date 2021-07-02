using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human10 : Classmate
{
    protected override void initHumanNum() => humanNum = 10;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie-1] = "2 25 45 43";//to school base
        path[arrivalButNotTheMoviePartTwo] = "43";
        path[arrivalButNotTheMoviePartThree + 2] = "1";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#79FFFB";

        tcsPos[0] = "'Hey! Are you new here?'|Uhhhh, I'm a Junior this year. But do I get that often|'Heh heh... I'm still getting used to this area. And I guess you also looked new'|Freshmen?|'Yeah, I'm suuuuuper nervous!'|Oh well don't be, it'll be fun- well I don't know if fun is the right word. Maybe exciting?|'I mean exciting is good, right?'|Right..";
        tcsPos[1] = "How's freshman year so far?|'I really enjoy it here! It's much more exciting than my old town!'|That's good, are you having fun too?|'Totally! It's so much more fun here too!'|That's good.|'How about you? Are you having fun?'|It's been good|'Oh. Is that all?'|Yep|'You should talk more!'|Right, I'll try";
        tcsPos[2] = "'I love the sounds of rain, the ambience of it while it hits the roof is amazing!'|Yea, do you like the rain?|'Totally! Isn't it obvious? I love the rain!'|Me too.|'It gets annoying sometimes since everything is always wet'|I guess it does get annoying, but I think it's worth it|'Agreed!'";
        tcsPos[3] = "'Yo! There's a festival tomorrow! You coming?'|I tend to sleep in over the weekends|'Just wake up early this one time! How hard can it be!'|You'd be surprised, I usually sleep till noon|'Noon??? You need to take care of yourself more!'|I think I do, just not physically|'Are you still eating frozen foods?'|It's possible|'You're hopeless.";
        tcsPos[4] = "'Maybe you should try to get better at cooking!'|I've tried a few times, but it seem I only know how to use a microwave|'If you keep eating frozen foods, you'll get sick!'|It's already been a few years, I'll be fine|'A few years?! Is that why you're so short?'|Hey, I'm taller than you";
        tcsPos[5] = "'I feel like such a grown up!'|What did you do?|'I bought my own groceries yesterday!'|Oh ok, I was expecting something more..|'OK, I guess I'll just stop telling you stuff~'|I mean I'm in no place to judge I guess, I only leave the house to go to school anyways.|'You should be my role model!'|I guess you should find another upperclassmen";
        tcsPos[6] = "'Is your room messy?'|No, why?|'Ooooh nothing~'|It sure doesn't seem like nothing|'Ok Ok I'll tell you!'|mhm?|'You just don't seem like the type to have a clean room, I was curious!'|Well I guess sometimes it does get a little messy when I get busy.|'So I was right!'|I said sometimes, but I am fairly busy these days...|'See!!!'";
        tcsPos[7] = "'I like you.'|...|...|..I-|'It's a joke!!'|Oh okay, I didn't know how to respond|'That was fun'|Sure... Why-|'I'll get going, see you later!'|Right, bye.";

    }
}
