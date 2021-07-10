using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human13 : Classmate
{
    protected override void initHumanNum() => humanNum = 13;
    protected override void initPersonality() => personalityType = 2;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "0 20 25";//to school base
        path[arrivalButNotTheMoviePartTwo+1] = "26";
        path[arrivalButNotTheMoviePartThree - 1] = "9 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#65E2E2";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'I simply adore this weather, not too hot, not too cold!'|Yea, I agree, the weather is pretty nice today.|'I do think there is too much wind today'|Hmm, yea.",
            "Have you thought about which college you want to go to?|'I plan to head to an Ivy League establishment, I believe I should be able to make it!'|Oh wow! Big plans I guess?|Indeed it is.",
            "'You're a very pleasant person to talk to!'|Oh, thank you!|'Do you not think about being that way?'|Huh? I really like talking to you too!|'That's good.",
            "'Making the most of today?'|Uh, yea. I was able to get some work done I guess? How about you?|'Well, I did lot's of work today, I was also able to acquire a job!'|Whoa! That's so cool!",
            "What's your favorite food?|'Well, I think chocolate is lovely!'|Hmmm, I don't think that's... Well it's more of a dessert?|'So you want an Entrée?'|Uh, yea|'Hmmm, I don't think I've quite found one yet?",
            "'How nice to see you today!'|Oh, did something happen?|'Hm? I think I just find conversations with you especially pleasurable!'|Heh, thanks I guess!",
            "'Oh, I love the weather so much. It's so blissful!'|Oh, isn't it just a little gloomy though?|'I think I like the cold and gloomy weather. I love it so much.'|That's good, I like the weather too!",
            "'It's such a lovely today, don't you think so my friend?'|Hm? Yea I guess today is pretty good|'I think today cannot get worse! It's almost perfect!"
        }, 0);

        lang.addLanguage(new string[]{
            "'我喜欢这样的天气，不热不冷！'|是的，我同意，今天天气很好。|'但是今天风太大了'|嗯，是的。",
            "想好要上哪所大学了吗？|'我打算考上一流大学，我相信我应该能考上！'|哇哇！ 大计划？|确实如此。",
            "'我真的很喜欢和你说话'|哦，谢谢你！|'我呢？'|我也很喜欢和你说话！|'那很好。'",
            "'你今天做事了吗？'|呃，是的。 我想我能够完成一些事情。 你呢？|'我今天干了很多事，我也找到了工作！'|哇！ 这太酷了！",
            "你最喜欢什么食物？|'我觉得巧克力很好吃！'|嗯，我不认为那是......它更像是一种甜点？|'所以你想要一个主菜？'|是的|'嗯， 我想我还没有找到一个。'",
            "'今天见到你真高兴！'|哦，发生什么事了吗？|'嗯？ 我想我只是觉得和你的谈话特别愉快！'|嘿，谢谢！",
            "“我非常喜欢今天的天气。 真好！'|是不是有点阴沉？|'我喜欢阴冷的天气。'|很好，我也喜欢！",
            "“今天真是个好日子，你不觉得吗？”|嗯？ 是啊，今天很不错|'这几乎是完美的！'"
        }, 1);

        lang.addLanguage(new string[]{
            "'我喜歡這樣的天氣，不熱不冷！'|是的，我同意，今天天氣很好。|'但是今天風太大了'|嗯，是的。",
            "想好要上哪所大學了嗎？|'我打算考上一流大學，我相信我應該能考上！'|哇哇！ 大計劃？|確實如此。",
            "'我真的很喜歡和你說話'|哦，謝謝你！|'我呢？'|我也很喜歡和你說話！|'那很好。'",
            "'你今天做事了嗎？'|呃，是的。 我想我能夠完成一些事情。 你呢？|'我今天干了很多事，我也找到了工作！'|哇！ 這太酷了！ ",
            "你最喜歡什麼食物？|'我覺得巧克力很好吃！'|嗯，我不認為那是......它更像是一種甜點？|'所以你想要一個主菜？' |是的|'嗯， 我想我還沒有找到一個。'",
            "'今天見到你真高興！'|哦，發生什麼事了嗎？|'嗯？ 我想我只是覺得和你的談話特別愉快！'|嘿，謝謝！",
            "“我非常喜歡今天的天氣。真好！ '|是不是有點陰沉？ |'我喜歡陰冷的天氣。 '|很好，我也喜歡！ ",
            "“今天真是個好日子，你不覺得嗎？ ”|嗯？ 是啊，今天很不錯|'這幾乎是完美的！'"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
