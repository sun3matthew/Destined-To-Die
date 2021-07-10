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

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'The sun's really bright today, don't you think?'|Uhm, it looks fairly...Normal?|'You know you should look up more, you'll get back pains if you keep looking down'|Well I already have back pains|'Do you want a massage?'|What? No",
            "'Hey! How's it going?'|How do I actually respond to that?|'You know, \"Good\", \"Bad\", things like that?'|Good|'And... Keep going'|Not really in the mood|'Whaaa... thats too bad'|Sucks to be you I guess",
            "'I had a super weird dream last night, but it's a little embarrassing'|What is it?|'Nooooooo, it's too embarrassing!'|Okay, then don't say it|'Noooo you're supposed to keep asking!'|Uhh, W-Whats the dream?|'Nevermind, now I feel like I just forced you'|Uhh, how do I respond now|'...Just, Nevermind'",
            "'What up!'|What... up?|'It's going to rain soon!'|Oh, really?|'Yeah, well rainy days are special!'|So you like it when it rains?|'mHm!'|Yea, I like the rain too, and I love running in the rain.|'Running? Do you want to get a cold? Don't do that!'",
            "'I need some good prank ideas!'|Why?|'Geez, it's my final year here! I want to have some fun!'|Why do I think you're going to do something dangerous|'Whaa? You're the one that's going to hurt yourself!'|Right... Since you're the more responsible one|'I don't like the tone of your voice!~",
            "'Perfect Timing! I was just thinking about you!'|You were... What?|'I had another dream, you were in it!'|What was I doing in your dream?|'I won't tell you~'|I'm concerned|'Fineee, I'll tell you, but just make sure you don't laugh!'",
            "'Do you ever shop?'|Huh? I guess I buy stuff online, but not really in real life|'There's a farmer market tomorrow! Wanna come? I have a group of friends coming'|Oh. Uh, I'll be busy tomorrow|'All day? You should take some time to relax a little! If you don't get enough rest, you'll get wrinkles and white hair!'|Thanks for your concern",
            "Hey, How have you been doing?|'Great! The weather is really nice today! Don't you think?'|Yea I guess..|'You look so gloomy today, cheer up!'|I'll try, talk to you later."
        }, 0);

        lang.addLanguage(new string[]{
            "'今天的太阳真好，你不觉得吗？'|嗯，看起来很……正常？|'你应该多抬头，如果你一直低头，你会背痛'|我已经背痛了|'要我给你按摩吗？'|什么？ 我不需要",
            "'嘿！ 怎么样?'|我该如何回应？|'比如, \"好\", \"坏\", 之类的？'|好|'还有……继续'|我懒得说|'好吧'",
            "'我昨晚做了一个超级奇怪的梦'|什么梦?|'不行，这个梦太狼狈了！'|好吧，那就不说了|'什么？ 你应该继续问！！'|嗯, 你昨晚做了什么梦？|'算了, 现在我觉得我只是强迫你问'|嗯, 我现在应该说什么|'就... 算了'",
            "'还好吗!'|还好... 吗?|'这几天要下雨了！'|真的吗？|'是的，下雨天很特别！'|你喜欢下雨天吗？|'当然!'|我也喜欢下雨天，我喜欢在雨中跑步。|'跑步？ 你想感冒吗？ 下雨天别跑！'",
            "'我需要一些恶作剧的好主意！'|为什么?|'什么，这是我的最后一年！ 我想玩得开心！'|为什么我觉得你会做一些危险的事情|'什么？ 伤害自己的是你！'|对...因为你是比较负责任的人|'我不喜欢你的语气！~",
            "'多么巧合！ 一整天都在想你！'|你... 什么?|'我昨晚做了个梦，你在里面！'|我在你梦里做什么？|'不告诉你~'|请告诉我!|'好吧，我告诉你，这很有趣！'",
            "'你经常购物吗？'|嗯？ 我喜欢在网上买东西|'明天有农贸市场！ 要来吗？ 我和我的朋友会去!'|哦。 嗯，明天我会很忙|'一整天？ 你应该花点时间放松一下！ 如果你没有得到足够的休息，你会长出白头发！'|感谢你的关心...",
            "嘿，你最近好吗？|'好! 今天的天气真的很好！ 你不觉得吗？'|还好吧...|'你今天看起来好阴郁，振作起来！'|好的"
        }, 1);

        lang.addLanguage(new string[]{
            "'今天的太陽真好，你不覺得嗎？'|嗯，看起來很……正常？|'你應該多抬頭，如果你一直低頭，你會背痛'|我已經背痛了|'要我給你按摩嗎？'|什麼？ 我不需要",
            "'嘿！ 怎麼樣?'|我該如何回應？|'比如, \"好\", \"壞\", 之類的？'|好|'還有……繼續'|我懶得說| '好吧'",
            "'我昨晚做了一個超級奇怪的夢'|什麼夢?|'不行，這個夢太狼狽了！'|好吧，那就不說了|'什麼？ 你應該繼續問！！'|嗯, 你昨晚做了什麼夢？|'算了, 現在我覺得我只是強迫你問'|嗯, 我現在應該說什麼|'就... 算了'",
            "'還好嗎!'|還好... 嗎?|'這幾天要下雨了！'|真的嗎？|'是的，下雨天很特別！'|你喜歡下雨天嗎？| '當然!'|我也喜歡下雨天，我喜歡在雨中跑步。|'跑步？ 你想感冒嗎？ 下雨天別跑！'",
            "'我需要一些惡作劇的好主意！'|為什麼?|'什麼，這是我的最後一年！ 我想玩得開心！'|為什麼我覺得你會做一些危險的事情|'什麼？ 傷害自己的是你！'|對...因為你是比較負責任的人|'我不喜歡你的語氣！~",
            "'多麼巧合！ 一整天都在想你！'|你... 什麼?|'我昨晚做了個夢，你在裡面！'|我在你夢裡做什麼？|'不告訴你~'|請告訴我!|'好吧，我告訴你，這很有趣！'",
            "'你經常購物嗎？'|嗯？ 我喜歡在網上買東西|'明天有農貿市場！ 要來嗎？ 我和我的朋友會去!'|哦。 嗯，明天我會很忙|'一整天？ 你應該花點時間放鬆一下！ 如果你沒有得到足夠的休息，你會長出白頭髮！'|感謝你的關心...",
            "嘿，你最近好嗎？|'好! 今天的天氣真的很好！ 你不覺得嗎？'|還好吧...|'你今天看起來好陰鬱，振作起來！'|好的"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
