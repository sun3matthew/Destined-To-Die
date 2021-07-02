using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human12 : Classmate
{
    protected override void initHumanNum() => humanNum = 12;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "3 37 40";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "22";
        path[arrivalButNotTheMoviePartThree + 1] = "20 2";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#996FCA";

        tcsPos[0] = "How was school today?|'I hate it so much. My group is so useless, I do so much work, and when I showed them, they didn't like it!'|Ah I see, well it's just one project I guess, maybe you'll get a better group next time?";
        tcsPos[1] = "'Aw, maaaaaan'|Uh oh, what happened?|'I think I ate too late. I have a killer stomach cramp.'|That sucks, well, take it easy I guess, okay?|'Probably not, I'll go away soon, I know it.'";
        tcsPos[2] = "'Do you like books at all?'|Ehhhh, not really. I only like a few books.|'Oh, well I hate reading so much. It's just so boring!'|Yea, I agree, I hate reading too.";
        tcsPos[3] = "'I hate online classes so much!'|Oh really? I feel like it's easier at least?|'It's just so boring. The classes are just so horrible.'|Yea I guess, I still think I would prefer online though.";
        tcsPos[4] = "How's school?|'It is literally the worst thing to ever exist. Why do the teachers make group assignments during online classes?? The breakout rooms are so horrible and awkward!'|Heh, yea. I agree!";
        tcsPos[5] = "'Oh my god. Why does my teacher, NOT PUT UP THE ASSIGNMENT, AND GIVE EVERYONE A ZERO!!!'|Lmao, maybe your teacher just hates you guys?|'Sigh. Probably, school just sucks in general.'";
        tcsPos[6] = "What do you want to do in the future?|'I honestly have no idea, I think my parents want me to be a doctor.'|Heh, typical parents I guess. Do you want to?|'I don't hate the prospect, but I don't know.";
        tcsPos[7] = "'Do you enjoy listening to my random rants?'|Yea? It's pretty fun? Like it's very enjoyable?|'Ah okay, I always feel like I'm being annoying!'|Heh, not at all, I love it.";

    }
}
