using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human5 : Classmate
{
    protected override void initHumanNum() => humanNum = 5;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "2 31 28 16";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "17";
        path[arrivalButNotTheMoviePartThree + 2] = "19 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#78CBB5";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "Hello|'Ayo, Need something lad?'|Oh I was just saying hi|'I gotchu bro, what's up fella?'|Nothing much, uh, how about you?|'I'm feeling awesome! I'm excited to get to know you more buddy!'",
            "'Whatcha doing lad?'|Uh, standing?|'Haha! I meant like in general, howz school, howz life?'|Oh ok, school's fine, and my life is okay too I guess|'Bro! You need to talk more man!'",
            "'Ya like music at all?'|Yea, I enjoy it for the most part I think?|'Nice! What kind of music?'|I don't really know what it's called, just lots of weird stuff, how about you?|'Rock!'",
            "'Ayo, you wanna follow me?'|I'm sorry what?|'I found a new running trail today! I need some buds to check it out with me!'|Hmm, sorry but I'll pass.|'Awwwwww man! Well I won't force you!",
            "'Hey, I need to ask you a question'|Yep?|'Are dinosaurs really birds? Like bro when I heard that, I remembered that they both lay eggs!'|I think it's the other way around, like the square rectangle thing.|'The what?'",
            "'Hey man, can you help me with a calc question?'|Uhhhhhhh, sure?|'So like the separation of variables crap, how does that work?'|Uhhhhhhhhh, listen, I honestly forgot how that stuff worked...",
            "'Ayo, there's a firework show soon! Me and my buddies are going to check it out! Wanna hop in?'|Uhhh, sorry, I'm kinda busy these days.|'Awww man, just one day brosky?'|Sorry, I really can't|'That sucks.'",
            "Heyo!|'Yo what's up fam!'|Uhm, nothing much, how about you?|'Pretty good!'|That's nice.|'Yea man!'"
        }, 0);

        lang.addLanguage(new string[]{
            "你好|'哎，需要什么吗？'|哦，我只是打个招呼|'我明白了，怎么样？'|没什么，你呢?|'我感觉棒极了！ 我很高兴见到你！'",
            "'你在做什么'|嗯，站着？|'哈哈！ 学校怎么样，生活怎么样？'|哦，好的，学校很好，我想我的生活也很好|'兄弟！ 你需要多说话！'",
            "'你喜欢音乐吗？'|是的，我最喜欢.|'好的！ 什么样的音乐？'|我不知道它叫什么，只是很多奇怪的东西，你呢？|'摇滚!'",
            "'哟，你要跟我走吗？'|什么?|'我今天发现了一条新的跑步路线！ 我需要一些朋友和我一起检查！'|嗯，对不起，我今天忙.|'啊啊啊！ 嗯，我不会强迫你!",
            "'嘿，我想问你一个问题'|好的?|'恐龙真的是鸟类吗？ 一听这话，我就想起来他们都下蛋!'|你在说什么？",
            "'嘿伙计，你能帮我解决一个微积分问题吗？'|呵呵，你确定要问我？|'还记得变量的分离吗'|嗯嗯，我也忘记了.",
            "'哎呀，马上就要有烟火表演了！ 我和我的小伙伴要去看看！ 要来吗？'|呃，对不起，我这几天有点忙。|'啊啊啊！就来一天？'|对不起，我真的不能",
            "嘿嘿!|'还好吗？'|嗯，我很好，你呢？|'非常好!'|那很好。|'是的！'"
        }, 1);

        lang.addLanguage(new string[]{
            "你好|'哎，需要什麼嗎？'|哦，我只是打個招呼|'我明白了，怎麼樣？'|沒什麼，你呢?|'我感覺棒極了！ 我很高興見到你！'",
            "'你在做什麼'|嗯，站著？|'哈哈！ 學校怎麼樣，生活怎麼樣？'|哦，好的，學校很好，我想我的生活也很好|'兄弟！ 你需要多說話！'",
            "'你喜歡音樂嗎？'|是的，我最喜歡.|'好的！ 什麼樣的音樂？'|我不知道它叫什麼，只是很多奇怪的東西，你呢？|'搖滾!'" ,
            "'喲，你要跟我走嗎？'|什麼?|'我今天發現了一條新的跑步路線！ 我需要一些朋友和我一起檢查！'|嗯，對不起，我今天忙.|'啊啊啊！ 嗯，我不會強迫你!",
            "'嘿，我想問你一個問題'|好的?|'恐龍真的是鳥類嗎？ 一聽這話，我就想起來他們都下蛋!'|你在說什麼？",
            "'嘿伙計，你能幫我解決一個微積分問題嗎？'|呵呵，你確定要問我？|'還記得變量的分離嗎'|嗯嗯，我也忘記了.",
            "'哎呀，馬上就要有煙火表演了！ 我和我的小伙伴要去看看！ 要來嗎？'|呃，對不起，我這幾天有點忙。|'啊啊啊！就來一天？ '|對不起，我真的不能",
            "嘿嘿!|'還好嗎？'|嗯，我很好，你呢？|'非常好!'|那很好。|'是的！'"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}