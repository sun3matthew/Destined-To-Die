using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human11 : Classmate
{
    protected override void initHumanNum() => humanNum = 11;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "6 15 34";//to school base
        path[arrivalButNotTheMoviePartTwo] = "24";
        path[arrivalButNotTheMoviePartThree - 1] = "25 10 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#A0C1EE";

        tcsPos[0] = "'Heya! Thanks for helping me out over the summer!'|Oh, it was no big deal|'I still have trouble keeping the edges clean, but I think I'm getting better!'|That's good, at least you're doing something|'Yessss! I'm going to keep being more productive!!'";
        tcsPos[1] = "When did you sleep?|'*Sniff* I got sick again'|I assume you already took your medicine?|'It tasted gross, why did my mom force me take chinese medicine...'|It's probably good for you to some extent|'Wahhhhhhhh not you too- *Ahchoo*'|Although I do think western medicine probably works better.";
        tcsPos[2] = "Are you feeling better?|'no.'|...|Did it get worse?|'yes- Actually maybe it stayed the same.'|I think that's still a good sign|'That's hard for me to believe, it hurts so much'|I guess it's more like you probably reached the worst that it can get?|'Really? But I feel sooo horrible.'|Hang in there.";
        tcsPos[3] = "How are you feeling today?|'I think I feel better.'|That's good|'Ugh... the awful taste of medicine is still in my mouth.'|Do you have water?|'I already tried that, but I can't wash the taste out!'|Well it'll come out eventually|'It's just soo bitter'";
        tcsPos[4] = "'*Ahchoo*'|You good?|'Wahhhhhh I think it got worse again, I'm sore all over'|Did anything change?|'Wait. Have you not noticed? It's so much colder!!!'|It has? I guess so... I guess the mornings are more cold these days.";
        tcsPos[5] = "'It's s-so c-cold... w-why d-did it get so c-c-cold.'|I think you should stay home for the day.|'I told my mom that I felt so s-sick, but she won't let me!'|Well take it easy today I guess, do you want my jacket?|'Hmmmm, I'll be fine once I get into a room and also won't you be cold?|'Well if you need it, you can ask.";
        tcsPos[6] = "'Heyaa!!'|Oh, I see you have gotten better?|'It's so weird! It was just like I was never sick!'|I guess medicine does help-|'Please please please don't bring it up again. I can still taste it whenever I think about it!|Oh lmao, whoops.|'I'm so excited to resume life normally!'";
        tcsPos[7] = "'OK, if you could have anything you want, what would you want?'|Huh? Why?|'Just answer it!'|Uhhh, I don't know|'Aww that's so boring!'|Yea, well I have to get going, see you.";
    }
}
