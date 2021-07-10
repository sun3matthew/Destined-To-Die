using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human10 : Classmate
{
    protected override void initHumanNum() => humanNum = 10;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie-1] = "2 25 45 43";//to school base
        path[arrivalButNotTheMoviePartTwo] = "43";
        path[arrivalButNotTheMoviePartThree + 2] = "1";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#79FFFB";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'Hey! Are you new here?'|Uhhhh, I'm a Junior this year. But do I get that often|'Heh heh... I'm still getting used to this area. And I guess you also looked new'|Freshmen?|'Yeah, I'm suuuuuper nervous!'|Oh well don't be, it'll be fun- well I don't know if fun is the right word. Maybe exciting?|'I mean exciting is good, right?'|Right..",
            "How's freshman year so far?|'I really enjoy it here! It's much more exciting than my old town!'|That's good, are you having fun too?|'Totally! It's so much more fun here too!'|That's good.|'How about you? Are you having fun?'|It's been good|'Oh. Is that all?'|Yep|'You should talk more!'|Right, I'll try",
            "'I love the sounds of rain, the ambience of it while it hits the roof is amazing!'|Yea, do you like the rain?|'Totally! Isn't it obvious? I love the rain!'|Me too.|'It gets annoying sometimes since everything is always wet'|I guess it does get annoying, but I think it's worth it|'Agreed!'",
            "'Yo! There's a festival tomorrow! You coming?'|I tend to sleep a lot|'Just wake up early this one time! How hard can it be!'|You'd be surprised, I usually sleep till noon|'Noon??? You need to take care of yourself more!'|I think I do, just not physically|'Are you still eating frozen foods?'|It's possible|'You're hopeless.'",
            "'Maybe you should try to get better at cooking!'|I've tried a few times, but it seem I only know how to use a microwave|'If you keep eating frozen foods, you'll get sick!'|It's already been a few years, I'll be fine|'A few years?! Is that why you're so short?'|Hey, I'm taller than you",
            "'I feel like such a grown up!'|What did you do?|'I bought my own groceries yesterday!'|Oh ok, I was expecting something more..|'OK, I guess I'll just stop telling you stuff~'|I mean I'm in no place to judge I guess, I only leave the house to go to school anyways.|'You should be my role model!'|I guess you should find another upperclassmen",
            "'Is your room messy?'|No, why?|'Ooooh nothing~'|It sure doesn't seem like nothing|'Ok Ok I'll tell you!'|mhm?|'You just don't seem like the type to have a clean room, I was curious!'|Well I guess sometimes it does get a little messy when I get busy.|'So I was right!'|I said sometimes, although I am fairly busy these days...|'See!!!'",
            "'I like you.'|...|...|..I-|'It's a joke!!'|Oh okay, I didn't know how to respond|'That was fun'|Sure... Why-|'I'll get going, see you later!'|Right, bye."
        }, 0);

        lang.addLanguage(new string[]{
            "'嘿！ 你是新来的吗？'|呵呵，我是大三。|'呵呵……我刚搬来这个区'|第一年？|'是的，我很紧张！'|哦，不要，它会很有趣！|'那挺好的！'",
            "学校怎么样？|'我真的很喜欢这里！ 比我的家乡精彩多了！'|你也玩得开心吗？|'完全！ 这里也更有趣！'|那挺好的。|'你呢？'|不错|'哦，还有吗？'|没有了?|'你应该多说话！'",
            "'我喜欢雨的声音，听起来很放松'|你喜欢下雨天吗？|'完全！ 不是很明显吗？ 我爱雨！'|我也是。|'有时会很烦人，因为我的衣服总是湿的'|确实很烦人，但值得|'同意！'",
            "'哟！ 明天有节日！ 你来吗？'|我可能会睡|'就这一次早点起床！ 能有多难！'|我通常睡到中午|'中午？？？ 你更需要照顾好自己！'|我想我有，只是身体上没有|'你还在吃冷冻食品吗？'|可能|'你没希望了'",
            "'你应该学学做饭！'|我试过几次，我只知道怎么用微波炉|'如果你一直吃冷冻食品，你会生病的！'|我一直在吃 冷冻食品几年，我会没事的|'几年？！ 这就是你这么矮的原因吗？'|嘿，我比你高",
            "'我觉得自己长大了！'|你做了什么？|'我昨天买了自己的杂货！'|还有吗？|'好吧，我想我就不跟你说话了~'|对不起",
            "'你的房间乱吗？'|不，为什么？|'没什么~'|好吧|'你看起来不像是拥有干净房间的那种人， 我很好奇！'|有时候当我很忙时，它确实会变得有点乱.|'所以我是对的！'",
            "'我喜欢你。'|...|'...'|.. 我-|'开玩笑的！！'|哦好吧...|'我先走了，待会见！'"
        }, 1);

        lang.addLanguage(new string[]{
            "'嘿！ 你是新來的嗎？'|呵呵，我是大三。|'呵呵……我剛搬來這個區'|第一年？|'是的，我很緊張！'|哦，不要，它會很有趣！|'那挺好的！'",
            "學校怎麼樣？|'我真的很喜歡這裡！ 比我的家鄉精彩多了！'|你也玩得開心嗎？|'完全！ 這裡也更有趣！'|那挺好的。|'你呢？'|不錯|'哦，還有嗎？'|沒有了?|'你應該多說話！'",
            "'我喜歡雨的聲音，聽起來很放鬆'|你喜歡下雨天嗎？|'完全！ 不是很明顯嗎？ 我愛雨！'|我也是。|'有時會很煩人，因為我的衣服總是濕的'|確實很煩人，但值得|'同意！'",
            "'喲！ 明天有節日！ 你來嗎？'|我可能會睡|'就這一次早點起床！ 能有多難！'|我通常睡到中午|'中午？？？ 你更需要照顧好自己！'|我想我有，只是身體上沒有|'你還在吃冷凍食品嗎？'|可能|'你沒希望了'",
            "'你應該學學做飯！'|我試過幾次，我只知道怎麼用微波爐|'如果你一直吃冷凍食品，你會生病的！'|我一直在吃冷凍食品幾年，我會沒事的|'幾年？！ 這就是你這麼矮的原因嗎？'|嘿，我比你高",
            "'我覺得自己長大了！'|你做了什麼？|'我昨天買了自己的雜貨！'|還有嗎？|'好吧，我想我就不跟你說話了~'|對不起",
            "'你的房間亂嗎？'|不，為什麼？|'沒什麼~'|好吧|'你看起來不像是擁有乾淨房間的那種人， 我很好奇！'|有時候當我很忙時，它確實會變得有點亂.|'所以我是對的！'",
            "'我喜歡你。'|...|'...'|.. 我-|'開玩笑的！！'|哦好吧...|'我先走了，待會見！'"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
