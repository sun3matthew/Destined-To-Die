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

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "How was school today?|'I hate it so much. My group is so useless, I do so much work, and when I showed them, they didn't like it!'|Ah I see, well it's just one project I guess, maybe you'll get a better group next time?",
            "'Aw, maaaaaan'|Uh oh, what happened?|'I think I ate too late. I have a killer stomach cramp.'|That sucks, well, take it easy I guess, okay?|'Probably not, it'll go away soon, I know it.'",
            "'Do you like books at all?'|Ehhhh, not really. I only like a few books.|'Oh, well I hate reading so much. It's just so boring!'|Yea, I agree, I hate reading too.",
            "'I hate online classes so much!'|Oh really? I feel like it's easier at least?|'It's just so boring. The classes are just so horrible.'|Yea I guess, I still think I would prefer online though.",
            "How's school?|'It is literally the worst thing to ever exist. Why do the teachers make group assignments during online classes?? The breakout rooms are so horrible and awkward!'|Heh, yea. I agree!",
            "'Oh my god. Why does my teacher, NOT PUT UP THE ASSIGNMENT, AND GIVE EVERYONE A ZERO!!!'|Lmao, maybe your teacher just hates you guys?|'Sigh. Probably, school just sucks in general.'",
            "What do you want to do in the future?|'I honestly have no idea, I think my parents want me to be a doctor.'|Heh, typical parents I guess. Do you want to?|'I don't hate the prospect, but I don't know.",
            "'Do you enjoy listening to my random rants?'|Yea? It's pretty fun? Like it's very enjoyable?|'Ah okay, I always feel like I'm being annoying!'|Heh, not at all, I love it."
        }, 0);

        lang.addLanguage(new string[]{
            "学校怎么样？|'我非常讨厌。 我的组太没用了，我做了这么多工作，当我展示给他们时，他们不喜欢它！'|我明白了，也许下次你会得到一个更好的组？",
            "'好痛...'|哦哦，发生了什么事？|'我想我吃得太晚了。 我的胃疼。'|真糟糕，放松一点，好吗？|'我会没事的，很快就会好的'",
            "'你喜欢书吗？'|呃，不是真的。 我只喜欢几本书。|'哦，我太讨厌读书了。 太无聊了！'|是的，我同意，我也讨厌阅读。",
            "“我非常讨厌在线课程！”|哦，真的吗？ 我觉得至少更容易些？|'太无聊了。'|是的, 但我仍然认为我更喜欢在线课程。",
            "学校怎么样？|'学校糟透了！ 为什么老师在线上课时要进行小组作业？？ 分组讨论室是如此可怕和尴尬！'|嘿，是的。 我同意！",
            "'我的天啊。 为什么我的老师不告诉我们作业，而是给每个人的作业打零分！！！'| 或许你的老师只是讨厌你们？|'可能'",
            "你以后想做什么？|'我不知道，我父母希望我成为一名医生。'|呵呵，典型的父母。 你想吗？|'我不讨厌它，但我不知道。'",
            "'你喜欢听我的咆哮吗？'|是的，这很有趣。 非常享受。|'啊好吧，我总觉得我很烦人！'|嘿，一点也不，我喜欢它。"
        }, 1);

        lang.addLanguage(new string[]{
            "學校怎麼樣？|'我非常討厭。 我的組太沒用了，我做了這麼多工作，當我展示給他們時，他們不喜歡它！'|我明白了，也許下次你會得到一個更好的組？",
            "'好痛...'|哦哦，發生了什麼事？|'我想我吃得太晚了。 我的胃疼。'|真糟糕，放鬆一點，好嗎？|'我會沒事的，很快就會好的'",
            "'你喜歡書嗎？'|呃，不是真的。 我只喜歡幾本書。|'哦，我太討厭讀書了。 太無聊了！'|是的，我同意，我也討厭閱讀。" ,
            "“我非常討厭在線課程！ ”|哦，真的嗎？ 我覺得至少更容易些？|'太無聊了。'|是的, 但我仍然認為我更喜歡在線課程。",
            "學校怎麼樣？|'學校糟透了！ 為什麼老師在線上課時要進行小組作業？？ 分組討論室是如此可怕和尷尬！'|嘿，是的。 我同意！",
            "'我的天啊。 為什麼我的老師不告訴我們作業，而是給每個人的作業打零分！！！'| 或許你的老師只是討厭你們？|'可能'",
            "你以後想做什麼？|'我不知道，我父母希望我成為一名醫生。'|呵呵，典型的父母。 你想嗎？|'我不討厭它，但我不知道。'",
            "'你喜歡聽我的咆哮嗎？'|是的，這很有趣。 非常享受。|'啊好吧，我總覺得我很煩人！'|嘿，一點也不，我喜歡它。"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
