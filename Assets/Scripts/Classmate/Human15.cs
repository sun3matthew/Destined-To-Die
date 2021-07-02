using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human15 : Classmate
{
    protected override void initHumanNum() => humanNum = 15;
    protected override void initPersonality() => personalityType = 2;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie+1] = "2 13 35";//to school base
        path[arrivalButNotTheMoviePartTwo] = "36";
        path[arrivalButNotTheMoviePartThree + 1] = "21 0";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#7ED887";

        tcsPos[0] = "Hello!|'What do you want?'|I'm just greeting you?|'Oh hey. I guess.'|How are you doing?|'Do you need something?'|No? I was just asking how your day went?|'Oh ok. I'll pass.'|Ok";
        tcsPos[1] = "'Seeing your face makes me wish my day never started.'|Oh, sorry|'HAHAHA! I was just joking. You actually took that seriously!'|Hehehe... Right. I guess I did.";
        tcsPos[2] = "How's it going?|'The weather sucks so much today.'|Oh, how so?|'It's so dang hot. And there's no wind at all.'|Oh, well I think it'll start cooling down soon?|'It better.'";
        tcsPos[3] = "'Yo, why do you look so dead today. It's killing the mood.'|I'm sorry, I'll try to cheer up?|'It's whatever, I don't think people pay attention to you anyways'|Heh... Right.";
        tcsPos[4] = "'Why are you so annoying?'|I'm sorry?|'Nevermind. I just got zero hours of sleep last night.'|Oh, that makes sense I guess.|'Yea, people are just pissing me off today.'";
        tcsPos[5] = "'Why is it so cold today, it's so annoying.'|Yea it is pretty cold, I guess you can just wear more layers.|'What, you think I haven't tried that yet?'|Oh sorry, I was just suggesting it.";
        tcsPos[6] = "How's it going?|'Why couldn't it snow here? It's so damn cold, but apparently not cold enough for snow.'|Yea, maybe it's not humid enough?|'Yea no. I don't think that's the reason.'";
        tcsPos[7] = "'I'm so annoyed today.'|What happened?|'I don't want to talk about it today, I'll tell you some other day.'|Oh ok, sure!";
    }
}
