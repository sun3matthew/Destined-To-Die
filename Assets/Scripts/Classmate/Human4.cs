using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human4 : Classmate
{
    protected override void initHumanNum() => humanNum = 4;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "3 14 37 30";//to school base
        path[arrivalButNotTheMoviePartTwo+1] = "30";
        path[arrivalButNotTheMoviePartThree] = "21 0";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#CEE465";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'*Yawn* I woke up way too early'|How many hours of sleep did you get?|'eight'|That's pretty normal, how much do you usually sleep?|'Nine and a half'|That's honestly pretty impressive|'I have mastered the art of sleeping!'",
            "'I think I might have caught a cold'|What happened?|'I'm just feeling totally under the weather.'|Did you just not sleep enough?|'I can never get enough sleep, so it might be part of the problem'|Well I hope you get better soon?",
            "'Why is it always so bright in the morning, my eyes hurt.'|Do you enjoy sleeping in?|'Of course!! It's soooooo nice!'|Wait, how much do you sleep in during the weekends?|'...Um... I don't know, maybe 3?'|I'm sorry what?",
            "Why do you like eating so much?|'I've been on the hunt for the best tasting food! You have to find it somehow!'|I see, well what's the best right now?|'I've forgotten'|Doesn't that defeat the whole quest?|'What??? I'll know it when I taste it!'|Well let me know when you find it.",
            "How often do you eat out?|'Well...Maybe once or twice a day?'|Wait, how do you fit two in a day? And doesn't it cost lots?|'Guess what? Once I even had 5 in a day!'|I'm both impressed, and concerned.|'I guess it costs a lot too, but it's well worth it!",
            "'Oh, good! I've been looking all over for you!'|Really? why?|'*Yawn* But first, why do we need to get up so early in the morning all the time?'|Because education is important?|'Hmmm... Why can't it all be just shifted back a few hours!|Well not everyone sleeps in as much as you",
            "'Oh, hiya!'|That's new|'You think? It's something I heard in a tv commercial'|Was it a food commercial?|'Hey, what are you implying here?'|Was it a food commercial?|'I was going to offer you a snack, but not anymore!'|Oh ok, well I guess sucks to be me.|'Aw, I was hoping you would beg!'|Lmao, I'll pass",
            "'Hey! Something about today feels weird'|Oh really?|'*Yawn* I think I just didn't sleep or eat enough'|Oh, makes sense I guess|'Anyways I have to get going now! Goodbye!'"
        }, 0);

        lang.addLanguage(new string[]{
            "'我很困，我醒得太早了'|你睡了几个小时？|'八小时'|还行吧, 你通常睡多少？|'九个半小时'|哇，睡的真多!|'我真的很喜欢睡觉！'",
            "'我想我可能感冒了'|你没事吗？|'我只是觉得有点不舒服。'|你睡够了吗？|'这些天我确实睡得少，所以你可能是对的'|希望你快点好起来!",
            "'为什么早上总是那么亮，我的眼睛很痛。'|你喜欢赖床吗？|'当然!! 太舒服了!'|等等，你周末什么时候起床?|'嗯......我不知道，下午 1 点？'|什么？?",
            "你为什么那么喜欢吃？|'我一直在寻找最好吃的食物！ 所以我当然要吃很多！'|那么现在最好吃的食物是什么？|'我忘了'|这不是打败了整个任务吗？|'什么! 我只是忘记了'|当你想起它的时候告诉我",
            "你吃外卖吗？|'我一天吃两次!'|等等，你怎么一天吃两个？ 而且不是很贵吗？|'有一次我一天吃了五个！'|我很惊讶，也很担心。|'虽然也花了不少钱，但还是很值得的！",
            "'好的！ 我一直在找你！'|真的? 为什么？|'但首先，为什么我们需要一直这么早起？'|因为学习很重要？?|'嗯……为什么不能把学校推迟几个小时！|不是每个人都像你一样睡得那么香",
            "'哦，嗨！'|那是新的|'我在电视广告里听到的'|是食品广告吗？|'嘿，你在这里暗示什么？'|是食品广告吗？|'我本来打算给你一些食物，但现在不行了！'|哦，好吧|'啊，我还以为你会难过呢！'|了猫",
            "'嘿！ 不知道为什么，今天感觉怪怪的'|哦真的吗？|'我想我只是没有睡好或吃得不够'|有道理哦|'不管怎样，我现在得走了！ 再见！'"
        }, 1);

        lang.addLanguage(new string[]{
            "'我很困，我醒得太早了'|你睡了幾個小時？|'八小時'|還行吧, 你通常睡多少？|'九個半小時'|哇，睡的真多!|'我真的很喜歡睡覺！'",
            "'我想我可能感冒了'|你沒事嗎？|'我只是覺得有點不舒服。'|你睡夠了嗎？|'這些天我確實睡得少，所以你可能是對的'|希望你快點好起來!",
            "'為什麼早上總是那麼亮，我的眼睛很痛。'|你喜歡賴床嗎？|'當然!! 太舒服了!'|等等，你周末什麼時候起床?|'嗯.... ..我不知道，下午1 點？'|什麼？?",
            "你為什麼那麼喜歡吃？|'我一直在尋找最好吃的食物！ 所以我當然要吃很多！'|那麼現在最好吃的食物是什麼？|'我忘了'|這不是打敗了整個任務嗎？|'什麼! 我只是忘記了'|當你想起它的時候告訴我",
            "你吃外賣嗎？|'我一天吃兩次!'|等等，你怎麼一天吃兩個？ 而且不是很貴嗎？|'有一次我一天吃了五個！'|我很驚訝，也很擔心。|'雖然也花了不少錢，但還是很值得的！",
            "'好的！ 我一直在找你！'|真的? 為什麼？|'但首先，為什麼我們需要一直這麼早起？'|因為學習很重要？?|'嗯……為什麼不能把學校推遲幾個小時！|不是每個人都像你一樣睡得那麼香",
            "'哦，嗨！'|那是新的|'我在電視廣告裡聽到的'|是食品廣告嗎？|'嘿，你在這裡暗示什麼？'|是食品廣告嗎？|'我本來打算給你一些食物，但現在不行了！'|哦，好吧|'啊，我還以為你會難過呢！'|了貓",
            "'嘿！ 不知道為什麼，今天感覺怪怪的'|哦真的嗎？|'我想我只是沒有睡好或吃得不夠'|有道理哦|'不管怎樣，我現在得走了！ 再見！'"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
