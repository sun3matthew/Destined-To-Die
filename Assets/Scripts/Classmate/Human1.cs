using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human1 : Classmate
{
    protected override void initHumanNum() => humanNum = 1;
    protected override void initPersonality() => personalityType = 1;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "0 9 19 17 22";//to school base
        path[arrivalButNotTheMoviePartTwo] = "23";
        path[arrivalButNotTheMoviePartThree + 1] = "20 2";
    }
    protected override void initHome() => house = new Vector2(74.50f, 4.36f);
    protected override void initConvos()
    {
        humanName = "#9E9C66";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "What's up?|'You're so chatty!'|Lmao, I guess I'm just in a good mood today?|'Awesome! What did you do?'|Uhhh, I don't know, I guess I had lots of sleep?|'Ha! I can't sleep early, I have too much energy! I just dance through the night!'|Dance?|'Oh, it was an exaggeration! I don't actually dance that much~'|Oh I see.",
            "Did you sleep well?|'Well I took a few melatonin pills I knocked out early.'|Oh, how many did you take?|'Hmm? One?'|Oh I see|'Hmmm? Why'd you ask?'|Oh I just remembered that if you take too much you get nightmares.|'Haha, that's a weird thing to know!'|Yea...my friend told me about it once",
            "'I'm so stressed right now!'|Uh Oh, what happened?|'I failed my chem quiz!!'|Like fail fail? Or like, did you just get a B?|'I got a 69!!'|Heh, 69.|'Hey! I'm having a crisis right now!!'|Well maybe you can just retake it?|'I know, But I'm still super stressed!'|Welp, hopefully you feel better soon?",
            "'Would you rather swim as fast as a fish or fly as fast as a bird?'|Why would anyone choose to swim?|'Hmmm. Oh! You can also breathe underwater?'|Like both freshwater and saltwater?|'Um... Yes?'|I feel like flying is just much more practical, like for traveling, or getting places without a ladder.",
            "'I think I might move...'|Oh no! Why?|'I don't really know, but I'm super sad about it...'|That really sucks, well come to visit us after you move!|'Probably, I think I'm going to live pretty far away, but I'll try by best!'",
            "I probably should have eaten earlier, or maybe I ate too much.|'What?! You're already so skinny! You need to eat more!'|Well I'm cramping right now, and I feel so full|'What? Hmmmm... Then you should eat early!'|That...That's the goal?",
            "'Hey! Remember when I said that I was moving? Well my parents changed their minds!'|Ah, I've been scammed|'WHAT?! Were you excited that I would go???'|I was kidding! Of course I'm glad that you're staying!|'Hehe, I'm so happy!'",
            "'I'm so tired today...'|Oh, did you get enough sleep?|'Well I took some more sleeping pills but I still couldn't sleep!'|Oh, well hopefully you can sleep better soon..|'Yep!'"
        }, 0);

        lang.addLanguage(new string[]{
            "还好吗？|'你真健谈'|了猫, 我想我今天心情不错？|'太棒了！ 你做了什么？'|嗯，我不知道，我想我睡了很多吧？|'哈！我不能早睡，我精力太充沛了！我整夜跳舞!'|跳舞？|'哦,我夸张！我其实不跳舞呢么多~'|哦，我明白了。",
            "你睡的好吗？|'我吃了几粒褪黑激素药，所以我睡得很早。'|哦，你吃了几个？|'唔？ 一粒？'|哦，我明白了。|'嗯？ 你为什么问？'|哦，我只记得如果你吃得太多，你会做恶梦。|'哈哈，你怎么知道的！'|我朋友告诉我的。",
            "'我现在压力好大！'|怎么了？|'我失败我的化学考试!'|真的失败? 或者，你得到了 80 分?|'我得了 69 分！！'|呵呵，69。|'嘿！ 我现在有危机！!'|好吧,也许你可以重新考吗？|'我知道，但我还是压力很大！'|嗯，那你就放松一下 ！｜'...谢谢。'",
            "'你愿意游得像鱼一样快，还是飞得像鸟一样快？'|谁会选择游泳?|'哦！ 你也可以在水下呼吸？'|淡水和咸水？|'嗯...是的。'|我觉得飞行更实用，比如旅行。",
            "'我想我可能会搬家...'|哎呦！为什么？|'我其实不知道, 但我非常难过...'|真糟糕，搬家后别忘了我！|'我想我要搬到很远的地方，但我会尽量回来看你们！'",
            "我应该早点吃, 或者我吃太多了。|'什么？！ 你已经很瘦了！ 你需要多吃点！'|但是我现在肚子很痛，而且我也觉得很饱。|'嗯……那你早点吃吧！'|我不就是这么说的吗?",
            "'嘿！ 还记得我说过我要搬家吗？ 我的父母改变了主意！'|啊我被骗了|'什么？！ 你真的要我搬家吗？？？'|我是开玩笑的！ 我当然很高兴你没有搬家！|'我好开心！'",
            "'我今天好累...'|你睡够了吗？|'我也吃了一些安眠药，但还是睡不着！'|哦，希望你能早点睡得更好..|'是的!'"
        }, 1);

        lang.addLanguage(new string[]{
            "還好嗎？ |'你真健談'|了貓, 我想我今天心情不錯？ |'太棒了！你做了什麼？ '|嗯，我不知道，我想我睡了很多吧？ |'哈！我不能早睡，我精力太充沛了！我整夜跳舞!'|跳舞？ |'哦,我誇張！我其實不跳舞呢麼多~'|哦，我明白了。",
            "你睡的好嗎？ |'我吃了幾粒褪黑激素藥，所以我睡得很早。 '|哦，你吃了幾個？ |'唔？一粒？ '|哦，我明白了。 |'嗯？你為什麼問？ '|哦，我只記得如果你吃得太多，你會做惡夢。 |'哈哈，你怎麼知道的！ '|我朋友告訴我的。",
            "'我現在壓力好大！ '|怎麼了？ |'我失敗我的化學考試!'|真的失敗? 或者，你得到了 80 分?|'我得了 69 分！ ！ '|呵呵，69。 |'嘿！我現在有危機！ !'|好吧,也許你可以重新考嗎？ |'我知道，但我還是壓力很大！ '|嗯，那你就放鬆一下 ！ ｜'...謝謝。 '",
            "'你願意游得像魚一樣快，還是飛得像鳥一樣快？ '|誰會選擇游泳?|'哦！你也可以在水下呼吸？ '|淡水和鹹水？ |'嗯...是的。 '|我覺得飛行更實用，比如旅行。",
            "'我想我可能會搬家...'|哎呦！為什麼？ |'我其實不知道, 但我非常難過...'|真糟糕，搬家後別忘了我！ |'我想我要搬到很遠的地方，但我會盡量回來看你們！ '",
            "我應該早點吃, 或者我吃太多了。 |'什麼？ ！你已經很瘦了！你需要多吃點！ '|但是我現在肚子很痛，而且我也覺得很飽。 |'嗯……那你早點吃吧！ '|我不就是這麼說的嗎?",
            "'嘿！還記得我說過我要搬家嗎？我的父母改變了主意！ '|啊我被騙了|'什麼？ ！你真的要我搬家嗎？ ？ ？ '|我是開玩笑的！我當然很高興你沒有搬家！ |'我好開心！'",
            "'我今天好累...'|你睡夠了嗎？ |'我也吃了一些安眠藥，但還是睡不著！ '|哦，希望你能早點睡得更好..|'是的!'"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
/*
lang.addLanguage(new string[]{
    "",
    "",
    "",
    "",
    "",
    "",
    "",
    ""
}, 0);
            */
