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

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "Hello!|'What do you want?'|I'm just greeting you?|'Oh hey. I guess.'|How are you doing?|'Do you need something?'|No? I was just asking how your day went?|'Oh ok. I'll pass.'|Ok",
            "'Seeing your face makes me wish my day never started.'|Oh, sorry|'HAHAHA! I was just joking. You actually took that seriously!'|Hehehe... Right. I guess I did.",
            "How's it going?|'The weather sucks so much today.'|Oh, how so?|'It's so dang hot. And there's no wind at all.'|Oh, well I think it'll start cooling down soon?|'It better.'",
            "'Yo, why do you look so dead today. It's killing the mood.'|I'm sorry, I'll try to cheer up?|'It's whatever, I don't think people pay attention to you anyways'|Heh... Right.",
            "'Why are you so annoying?'|I'm sorry?|'Nevermind. I just got zero hours of sleep last night.'|Oh, that makes sense I guess.|'Yea, people are just pissing me off today.'",
            "'Why is it so cold today, it's so annoying.'|Yea it is pretty cold, I guess you can just wear more layers.|'What, you think I haven't tried that yet?'|Oh sorry, I was just suggesting it.",
            "How's it going?|'Why couldn't it snow here? It's so damn cold, but apparently not cold enough for snow.'|Yea, maybe it's not humid enough?|'Yea no. I don't think that's the reason.'",
            "'I'm so annoyed today.'|What happened?|'I don't want to talk about it today, I'll tell you some other day.'|Oh ok, sure!"
        }, 0);

        lang.addLanguage(new string[]{
            "你好！|'你想要什么？'|我只是在问候你？|'哦，嘿。'|你在做什么|'你需要什么吗？'|没有？ 我只是在问你今天过得怎么样？|'哦，好的。 别说了。'|好的",
            "'看到你的脸就想吐'|哦，对不起|'哈哈哈！ 我就是开个玩笑。 你真的把这当回事了！'|嘿嘿嘿...对。",
            "怎么样？|'今天天气真糟糕。'|哦？|'也太热了。 '|我想它很快就会开始降温。|'更好。",
            "'哟，你今天怎么看起来这么无聊。'|对不起。|'算了，反正人家不理你'|嘿...对。",
            "'你为什么这么烦人？'|对不起？|'没关系'",
            "'为什么今天这么冷，真烦人。'|是的，很冷，我想你可以多穿几件衣服。|'什么，你觉得我傻吗？'|哦对不起，我只是建议。",
            "怎么样？|'为什么这里不能下雪？ 太冷了，但显然还不够冷'|是的，也许还不够潮湿？|'不。 我不认为这是原因。'",
            "'我今天很生气。'|发生了什么事？|'我今天不想说，改天告诉你。'|哦，好的，当然！"
        }, 1);

        lang.addLanguage(new string[]{
            "你好！|'你想要什麼？'|我只是在問候你？|'哦，嘿。'|你在做什麼|'你需要什麼嗎？'|沒有？ 我只是在問你今天過得怎麼樣？|'哦，好的。 別說了。'|好的",
            "'看到你的臉就想吐'|哦，對不起|'哈哈哈！ 我就是開個玩笑。 你真的把這當回事了！'|嘿嘿嘿...對。",
            "怎麼樣？|'今天天氣真糟糕。'|哦？|'也太熱了。 '|我想它很快就會開始降溫。|'更好。",
            "'喲，你今天怎麼看起來這麼無聊。'|對不起。|'算了，反正人家不理你'|嘿...對。",
            "'你為什麼這麼煩人？'|對不起？|'沒關係'",
            "'為什麼今天這麼冷，真煩人。'|是的，很冷，我想你可以多穿幾件衣服。|'什麼，你覺得我傻嗎？'|哦對不起，我只是建議。",
            "怎麼樣？|'為什麼這裡不能下雪？ 太冷了，但顯然還不夠冷'|是的，也許還不夠潮濕？|'不。 我不認為這是原因。'",
            "'我今天很生氣。'|發生了什麼事？|'我今天不想說，改天告訴你。'|哦，好的，當然！"
        }, 2);


        tcsPos = lang.getLanguage();
    }
}
