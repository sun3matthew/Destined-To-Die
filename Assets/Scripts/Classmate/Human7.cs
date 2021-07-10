using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human7 : Classmate
{
    protected override void initHumanNum() => humanNum = 7;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie+1] = "2 11 39 38";//to school base
        path[arrivalButNotTheMoviePartTwo] = "28";
        path[arrivalButNotTheMoviePartThree + 1] = "20 2";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#77B4E4";


        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "Hey|'Huh? Oh, I think I've seen you before'|Oh...Wait really?|'Huh? Maybe it was someone else...'|...|'Sorry this is embarrassing'|No it's fine|'Just pretend this never happened will ya?'",
            "'You need to eat more fruits and veggies!'|Pfft, your not my mom|'It's unhealthy if you keep on eating microwaved burritos!'|My metabolism will handle it, it'll be fineee...|'I'll make you stronger!'|I really don't think that's how it works",
            "Hey!|'You need to take care of yourself more'|Is that all you ever talk about?|'Seriously! How hard is it to eat more fresh fruit!'|Well, I would need to leave my room which is already too much effort|'Thats a little concerning, but whatever'",
            "'Are you planning to watch the rally?'|There's a rally today?|'Of course! They started announcing it last week!'|Why are you being so loud|'It's one of my most charming qualities~'|Riiiiight|'You should try being more outgoing!'|Nope, nope, nope!",
            "'Why do you look so... Sad'|I honestly don't know, it's probably just because I didn't get enough sleep or something|'I think your sadness is due to this weather, it's cold and wet'|You know rain is my favorite weather?|'What? Why?'|I don't know, I just like it",
            "I have a question to ask you|'Ya think you can give me a greeting first?'|Uhh, What?|'Like a \"Hi\" or a \"Hello\"'|Does it matter that much?|'People might think you're rude, and it wouldn't hurt'|Fine, Hii~ How are you doing this fine day~|'Thank you~, now stop with the sarcasm'|I don't think I will",
            "'Have you ever had a nickname?'|Why?|'I've made an awesome nickname for you!'|No|'Really? its super funny!'|Our sense of humor don't always match|'Hey! my sense of humor is much better than yours!'|I said different, not better, although I would disagree with you|'Hey!'",
            "'If you could do anything you wanted, what would you do'|That's a stupid question|'Fine! Well I wish I could travel the world!'|Isn't that what everyone wants?|'So What~ I still want to do it'|Well have fun with that|'I will! Sorry I have to go somewhere, I'll talk to you later!'|Talk to you later"
        }, 0);

        lang.addLanguage(new string[]{
            "嘿|'哦，我想我以前见过你。'|哦...真的吗？|'嗯？ 也许是别人...'|...|'抱歉这很尴尬'|没关系|'就假装这从来没有发生过好吗？'",
            "'你需要多吃水果和蔬菜！'|你不是我妈|'如果你吃微波炉食物是不健康的！'|我的新陈代谢会处理它, 没事的|'我会让你变得更强！'|什么？",
            "嘿！|'你需要多照顾自己'|这就是你谈论的全部吗？|'多吃点新鲜水果有多难！'|我什至懒得离开我的房间。|'什么？ 你怎么这么懒'",
            "'你打算看集会吗？'|今天有集会？|'当然！ 他们上周开始宣布！'|你为什么这么大声|'这是我最迷人的品质之一~'|嗯，好的|'你应该多说话！'|不!",
            "'你怎么看起来这么……伤心'|我没有睡够|'我想你的悲伤是因为这个天气，又冷又湿'|你知道下雨是我最喜欢的天?|'什么？ 为什么？'|不知道，就是喜欢",
            "我有个问题想问你|'你觉得你可以先给我打个招呼吗？'|嗯，什么？|'像\"嗨\"或\"你好\"'|有那么重要吗?|'人们可能会认为你很粗鲁！'|好的，嗨~ 这美好的一天你过得好吗~|'谢~ 现在停止讽刺'|我不会",
            "'你有过昵称吗？'|为什么？?|'我为你做了一个很棒的昵称！'|不想要|'超级有趣！'|我们的幽默感并不总是匹配|'嘿！ 我的幽默感比你好多了！'|什么？？",
            "'如果你可以做任何你想做的事，你会做什么'|这是一个笨的问题|'好吧，我希望我能环游世界！'|这不是每个人都想要的吗？|'那又怎样~我还想做!'"
        }, 1);

        lang.addLanguage(new string[]{
            "嘿|'哦，我想我以前見過你。'|哦...真的嗎？|'嗯？ 也許是別人...'|...|'抱歉這很尷尬'|沒關係|'就假裝這從來沒有發生過好嗎？'",
            "'你需要多吃水果和蔬菜！'|你不是我媽|'如果你吃微波爐食物是不健康的！'|我的新陳代謝會處理它, 沒事的|'我會讓你變得更強！' |什麼？",
            "嘿！|'你需要多照顧自己'|這就是你談論的全部嗎？|'多吃點新鮮水果有多難！'|我什至懶得離開我的房間。|'什麼？ 你怎麼這麼懶'",
            "'你打算看集會嗎？'|今天有集會？|'當然！ 他們上週開始宣布！'|你為什麼這麼大聲|'這是我最迷人的品質之一~'|嗯，好的|'你應該多說話！'|不!",
            "'你怎麼看起來這麼……傷心'|我沒有睡夠|'我想你的悲傷是因為這個天氣，又冷又濕'|你知道下雨是我最喜歡的天?|'什麼？ 為什麼？'|不知道，就是喜歡",
            "我有個問題想問你|'你覺得你可以先給我打個招呼嗎？'|嗯，什麼？|'像\"嗨\"或\"你好\"'|有那麼重要嗎? |'人們可能會認為你很粗魯！'|好的，嗨~ 這美好的一天你過得好嗎~|'謝~ 現在停止諷刺'|我不會",
            "'你有過暱稱嗎？'|為什麼？?|'我為你做了一個很棒的暱稱！'|不想要|'超級有趣！'|我們的幽默感並不總是匹配|'嘿！我的幽默感比你好多了！'|什麼？？",
            "'如果你可以做任何你想做的事，你會做什麼'|這是一個笨的問題|'好吧，我希望我能環遊世界！'|這不是每個人都想要的嗎？ |'那又怎樣~我還想做!'"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
