using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human6 : Classmate
{
    protected override void initHumanNum() => humanNum = 6;
    protected override void initPersonality() => personalityType = 1;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "1 21 44";//to school base
        path[arrivalButNotTheMoviePartTwo] = "41";
        path[arrivalButNotTheMoviePartThree + 2] = "19 1";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#F6AFD3";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'I love to yak!'|I can tell, I feel like you're the only person I know who uses the word yak|'No way! Back from my town, we say it all the time! Do you people really not use it?'|Nope, maybe it's too, uhhh, I don't know. Weird?|'Haha! Well I'll just keep saying it!'|It makes you unique I guess?",
            "'DID YOU CLONE YOURSELF??'|What?|'I saw you so many times today!'|Well uh, I did not clone myself|'I doooon't believe you~!'|I mean like, I don't think it was me but maybe I just moved fast?|'NO! You had different shirts!'|...So how did you know it was me?|'The way you walk! You have a terrible slouch!'|Ah. Are you high?",
            "'Oh my gosh, you again!'|This is the first time we saw each other- Are you on about the cloning thing again?|'I promise! They look just like you!!!'|I really can't tell if you're joking...|'I promiseeeeeee! Why would I lie to you!'|I'll just conclude that you're blind.",
            "'Hello again!'|What's your vision?|'Huh? 20 20?'|I don't understand...|'I don't know what you're referring to. Anyways, isn't the sun super nice today!'|Ehhhh, I don't really like the sun, it's just too bright and too hot.|'Awwwww man! But the sun rays! They're so nice!'",
            "'I'm so sleepy today...'|When did you sleep?|'Oh My Gosh, like 1 am or something!'|Ah, what were you doing until then?|'Well I just could not fall asleep! My mind was constantly running!'|What were you thinking about?|'Ha! I don't think I'll tell you~'",
            "'Gah! Oh it's just you. Do you go shopping much?'|Uhhh, not often. Why?|'Oh I was just wondering! When was the last time you went shopping?'|Like not recent? Maybe like a year- Wait like for clothing right?|'What else would you buy?'|Uhhh, wood?",
            "'I wish the sun was up for longer!'|Well maybe you should wake up earlier, than you can see the sun from sunrise to sunset!|'Noooooo! I don't like the sun that much... I can't wake up early!'",
            "'I think I might be moving soon'|Wait what? really? When?|'Hey, calm down! It's not anything you have to stress about! It's not that soon and we can still talk online!'|Yea I guess..."
        }, 0);

        lang.addLanguage(new string[]{
            "'我爱谈天!'|我觉得你是我认识的唯一个用谈天这个词的人|'决不！ 在我的老家，我们一直在说！ 你们真的不会用吗？'|不，只是有点奇怪？|'哈哈！ 那我就继续说吧！'|它让你独一无二!",
            "'你克隆了自己吗??'|什么?|'我今天见到你很多次了！'|嗯，我没有克隆自己|'我不信你~！'|我的意思是，我不认为是我?|'不！ 你穿着不同的衬衫！'|...那你怎么知道是我?|'你走路的样子！ 你总是弯着腰！'|啊。 你还好吗？",
            "'天哪，你又来了！'|这是我们第一次见面。 你又在谈论克隆的事情了吗？|'我答应！ 他们看起来和你一样!!!'|我真的不知道你是不是在开玩笑...|'我答应～！！ 我为什么要骗你!'|我只能断定你是瞎子.",
            "'你好！'|你的愿景是什么？|'嗯？ 20 20？'|我不明白...|'我不知道你指的是什么。 不管怎样，今天的太阳是不是超级好！'|我真的不喜欢太阳，太亮太热了。|'啊 但是太阳光！ 挺好的！'",
            "'我今天好困...'|你什么时候睡的?|'哦，我的天哪，像凌晨 1 点之类的！'|啊，直到1点你在做什么？|'我就是睡不着！ 我的脑子一直在运转！'|你在想什么?|'哈！ 不告诉你~'",
            "'你经常去购物吗？'|嗯，不经常。 为什么？|'哦，我只是想知道！ 你上次去购物是什么时候?'|买衣服对吗？|'你还能买什么？'|嗯，木头?",
            "'我希望太阳升起的时间更长！'|你应该早点醒来!|'不！ 我不太喜欢太阳……我不能早起！'",
            "'我可能要搬家了'|真的吗？ 什么时候？|'嘿，冷静下来！ 我们还是可以在线交流的！'|是的..."
        }, 1);

        lang.addLanguage(new string[]{
            "'我愛談天!'|我覺得你是我認識的唯一個用談天這個詞的人|'決不！ 在我的老家，我們一直在說！ 你們真的不會用嗎？'|不，只是有點奇怪？|'哈哈！ 那我就繼續說吧！'|它讓你獨一無二!",
            "'你克隆了自己嗎??'|什麼?|'我今天見到你很多次了！'|嗯，我沒有克隆自己|'我不信你~！'|我的意思是，我不認為是我?|'不！ 你穿著不同的襯衫！'|...那你怎麼知道是我?|'你走路的樣子！ 你總是彎著腰！'|啊。 你還好嗎？",
            "'天哪，你又來了！'|這是我們第一次見面。 你又在談論克隆的事情了嗎？|'我答應！ 他們看起來和你一樣!!!'|我真的不知道你是不是在開玩笑...|'我答應～！！ 我為什麼要騙你!'|我只能斷定你是瞎子.",
            "'你好！'|你的願景是什麼？|'嗯？ 20 20？'|我不明白...|'我不知道你指的是什麼。 不管怎樣，今天的太陽是不是超級好！ '|我真的不喜歡太陽，太亮太熱了。|'啊但是太陽光！ 挺好的！'",
            "'我今天好困...'|你什麼時候睡的?|'哦，我的天哪，像凌晨1 點之類的！'|啊，直到1點你在做什麼？|'我就是睡不著！ 我的腦子一直在運轉！'|你在想什麼?|'哈！ 不告訴你~'",
            "'你經常去購物嗎？'|嗯，不經常。 為什麼？|'哦，我只是想知道！ 你上次去購物是什麼時候?'|買衣服對嗎？|'你還能買什麼？ '|嗯，木頭?",
            "'我希望太陽升起的時間更長！'|你應該早點醒來!|'不！ 我不太喜歡太陽……我不能早起！'",
            "'我可能要搬家了'|真的嗎？ 什麼時候？|'嘿，冷靜下來！ 我們還是可以在線交流的！'|是的..."
        }, 2);

        tcsPos = lang.getLanguage();
    }
}


