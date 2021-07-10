using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human8 : Classmate
{
    protected override void initHumanNum() => humanNum = 8;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie-1] = "3 19 35 41";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "42";
        path[arrivalButNotTheMoviePartThree + 2] = "31 14 6 0";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#F59D78";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'Hey!'|Hi?|'How was your day?'|Oh uh, pretty good|'Come on!! Keep going!'|Well I woke up pretty early so that was nice I guess?|'Okkkk, you should talk more!'|Right",
            "'How was your day?'|I uh, It was pretty good|'How can you forget!'|What?|'Tell me more!!'|Well the sun looked nice today I guess|'Hey! That's basically what you said yesterday!'|Welp sucks to be you I guess",
            "'Hellooooo~'|Heyo|'How was your day fine sir?'|Uhhhm It was good, I did some stuff I guess|'Okkkkkk, Keep going!'|Well my knee kinda hurts, but I think I can still run|'Awwww man that sucks!'",
            "'Yoooohooooo!'|How do you keep coming up with these new greetings?|'Hmm? I just always say these things!'|I feel like this time it was new?|'Whaaat??? That's so rude!'|Wait it was a, it was a complement?|'Hmph! It doesn't sound like it!",
            "Hello|'Hmph! Why can't you try a new greeting once in a while!'|I- wait I can't tell if you're actually mad at me?|'Hehe... Of course not! I was just playing with you~'|Oh ok, I thought I actually did a bad thing",
            "Good afternoon?|'Goodbye'|Oh,... Ok? I'm sorry?|'Hehe, did I scare ya?'|Ah ok, well you did a little I guess.|'Hehe!'",
            "'Howdy!'|That's a new one.|'Come on!! I said it to you last time we spoke!'|Oh, Whoops I guess I forgot. My memory sucks these days...|'Agreed! Well hopefully you remember next time you talk to me!'",
            "Hey|'Hellooo!'|That's- How was your day?|'It was horrible! I woke up late to my first class, then my mommy yelled at me! Then I spilled boba all over my lap!'|Ah, that uh, that sucks|'Yea, it did.'"
        }, 0);

        lang.addLanguage(new string[]{
            "'嘿!'|嘿?|'你今天过得怎么样？'|哦，不错|'继续说!'|嗯，我今天起得很早？|'你应该多说话！'|好的",
            "'你今天过得怎么样？'|嗯，很不错|'怎么能忘记！'|什么?|'继续说!!'|嗯，今天的太阳看起来不错|'这基本上就是你昨天说的!'|对不起",
            "'你好~'|嘿|'先生，你今天过得好吗？'|先生? 今天还好，我做了一些事情|'继续说!!!'|我的膝盖有点痛，但我想我还能跑|'希望你会很快好转!'",
            "'哈罗'|你从哪里得到这些新的问候？|'唔？ 这些话我一直都在说！'|我觉得这次是新的？|'哇哦？？？ 那太粗鲁了！'|等等，它是一个...它是一个补充？|'哼！ 听起来不像！",
            "你好|'哼！ 为什么不能偶尔尝试一下新的问候语！'|等等我不知道你是不是真的生我的气？|'呵呵……当然不是！ 我就是跟你玩~'|哦，好吧，我以为我真的做了坏事",
            "下午好?|'再见'|哦...再见? 对不起?|'嘿嘿，吓到你了吗?'|嗯, 一点|'呵呵!'",
            "'您好伙伴!'|那是一个新的。|'什么！！ 上次我们说话的时候我就跟你说过了！'|哦，我想我忘记了。 这些天我的记忆力很差...|'同意！ 希望你下次跟我说话的时候记得！'",
            "嘿|'你好!'|你今天过得怎么样？|'那太差了！ 我第一节课迟到了，然后我妈妈冲我大喊大叫！ 然后我把奶茶洒在我的衣服上！!'|哎呀，真糟糕|'是的.'"
        }, 1);

        lang.addLanguage(new string[]{
            "'嘿!'|嘿?|'你今天過得怎麼樣？'|哦，不錯|'繼續說!'|嗯，我今天起得很早？|'你應該多說話！'|好的" ,
            "'你今天過得怎麼樣？'|嗯，很不錯|'怎麼能忘記！'|什麼?|'繼續說!!'|嗯，今天的太陽看起來不錯|'這基本上就是你昨天說的!'|對不起",
            "'你好~'|嘿|'先生，你今天過得好嗎？'|先生? 今天還好，我做了一些事情|'繼續說!!!'|我的膝蓋有點痛，但我想我還能跑|'希望你會很快好轉!'",
            "'哈羅'|你從哪裡得到這些新的問候？|'唔？ 這些話我一直都在說！'|我覺得這次是新的？|'哇哦？？？ 那太粗魯了！' |等等，它是一個...它是一個補充？|'哼！ 聽起來不像！",
            "你好|'哼！ 為什麼不能偶爾嘗試一下新的問候語！'|等等我不知道你是不是真的生我的氣？|'呵呵……當然不是！ 我就是跟你玩~'|哦，好吧，我以為我真的做了壞事",
            "下午好?|'再見'|哦...再見? 對不起?|'嘿嘿，嚇到你了嗎?'|嗯, 一點|'呵呵!'",
            "'您好夥伴!'|那是一個新的。|'什麼！！ 上次我們說話的時候我就跟你說過了！'|哦，我想我忘記了。 這些天我的記憶力很差...|'同意！ 希望你下次跟我說話的時候記得！'",
            "嘿|'你好!'|你今天過得怎麼樣？|'那太差了！ 我第一節課遲到了，然後我媽媽沖我大喊大叫！ 然後我把奶茶灑在我的衣服上！!'|哎呀，真糟糕|'是的.'"
        }, 2);

        tcsPos = lang.getLanguage();


    }
}
