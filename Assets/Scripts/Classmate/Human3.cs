using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human3 : Classmate
{
    protected override void initHumanNum() => humanNum = 3;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "3 5 31 28";//to school base
        path[arrivalButNotTheMoviePartTwo] = "29";
        path[arrivalButNotTheMoviePartThree] = "23 25 2";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#F3B87E";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'Do you want to accompany me to a movie sometime?'|Sure! Sounds pretty fun!|'I'll be sure to include one more seat!'",
            "Why are the days so boring...|'I fancy you just don't have a purpose in life'|Oh.|'Just be sure to find a purpose and you will be much more happy!'",
            "'I cannot wait for the fireworks this year!'|Oh really? I guess they are super pretty.|'The sounds too, the loud booms, the crackles. Oh I love it so much!'",
            "'Why are so many people crazy?'|Huh?|'People sleep so late, sleeping at 11pm is already too extreme for me.'|Oh, well I think some people are just night owls? Like maybe they're more productive at night?",
            "Hello|'Sorry, I kinda have something something on my mind right now, and I do not think I can hold a conversation right now'|Oh ok, I'll talk to you later.",
            "'Do you enjoy watching movies?'|Uhhh, actually I don't exactly like them, they're too long I guess?|'Oh really? I'm surprised you don't'|Well I don't hate them, just not my favorite I guess.",
            "'I'm going to the farmer's market tomorrow? Do you want to tag along?'|Uhhhhh, I'm a little busy tomorrow, so probably not.|'Oh ok, that's fine!'",
            "'Can you come to my birthday party next week?'|Uhh, yea sure! I'll try to be there.|'Awesome! I'll be expecting you!'"
        }, 0);

        lang.addLanguage(new string[]{
            "'有时间陪我看电影吗？'|当然！ 听起来很有趣！|'我一定会再加一个座位！'",
            "日子怎么这么无聊...|'我想你只是没有人生目标'|也许.|'一定要找到一个目的，你会更快乐！'",
            "'我等不及今年的烟花了！'|如果我记得他们是超级漂亮的。|'声音也很棒，响亮的轰鸣声，噼啪声。 哦，我太喜欢了！'",
            "'为什么这么多人疯了？'|什么?|'大家都睡得很晚，11点睡觉对我来说已经太晚了。'|我觉得有些人就是喜欢晚睡？ 也许他们在晚上更有效率？",
            "你好|'对不起，我现在太忙了，不能说话。'|哦，好的，那我明天再和你谈谈。",
            "'你喜欢看电影吗？'|嗯，其实我并不完全喜欢电影，电影太长了？|'哦真的吗？ 我很惊讶你不喜欢电影'|好吧，我不讨厌他们，只是不是我最喜欢的。",
            "'我明天去农贸市场？ 你要来吗？'|嗯，我明天有点忙，所以我不能去.|'哦，好的，没关系！'",
            "'你下周能来参加我的生日聚会吗？'|当然！ 我一定会去的。|'我会等你的！'"
        }, 1);

        lang.addLanguage(new string[]{
            "'有時間陪我看電影嗎？'|當然！ 聽起來很有趣！|'我一定會再加一個座位！'",
            "日子怎麼這麼無聊...|'我想你只是沒有人生目標'|也許.|'一定要找到一個目的，你會更快樂！'",
            "'我等不及今年的煙花了！'|如果我記得他們是超級漂亮的。|'聲音也很棒，響亮的轟鳴聲，劈啪聲。 哦，我太喜歡了！'",
            "'為什麼這麼多人瘋了？'|什麼?|'大家都睡得很晚，11點睡覺對我來說已經太晚了。'|我覺得有些人就是喜歡晚睡？ 也許他們在晚上更有效率？",
            "你好|'對不起，我現在太忙了，不能說話。'|哦，好的，那我明天再和你談談。",
            "'你喜歡看電影嗎？'|嗯，其實我並不完全喜歡電影，電影太長了？|'哦真的嗎？ 我很驚訝你不喜歡電影'|好吧，我不討厭他們，只是不是我最喜歡的。",
            "'我明天去農貿市場？ 你要來嗎？'|嗯，我明天有點忙，所以我不能去.|'哦，好的，沒關係！'",
            "'你下週能來參加我的生日聚會嗎？'|當然！ 我一定會去的。|'我會等你的！'"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
