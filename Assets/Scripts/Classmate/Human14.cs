using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human14 : Classmate
{
    protected override void initHumanNum() => humanNum = 14;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie+1] = "2 19 31 29";//to school base
        path[arrivalButNotTheMoviePartTwo] = "30";
        path[arrivalButNotTheMoviePartThree - 1] = "26 2";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#99CC33";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'Ayo'|Hey there|'I got a question for you!'|Yep?|'From one to ten, how buff am I!'|I- I don't know? Maybe like seven?|'Come on man! Only seven???'|I meant to say ten, my bad|'Ha! My man!!!'",
            "'What up!'|Hello|'I wish the sun got bigger! I want to flex on all you fools!'|I- Maybe save it for when I'm gone...|'Nah! Mark my words, tomorrow you'll see my bulging muscles!'",
            "'My personality is too nice!'|Nice is good? That's what girls like these days anyways?|'What?! I need to pump up my personality!'|I mean like, if that's what you want to do?|'Ayyyyy, my best bud!'",
            "Heyo|'Stay strong man...'|Uhm, did something happen?|'The weather. So gloomy, don't it getcha down?'|I kinda like it this way, it's easier on the eyes I guess.|'Well ya looked kinda down.'",
            "'Yo!'|Hello|'You ready to go on a great run tomarrow!'|Yea, I'm ready|'Ya gotta love the weather these days! Perfect running weather!'|Uhh, sure I guess?|'Hey! Cheer up dude! Now's a better time than any to run!",
            "Hello|'Bro I'm so broke man'|Hmm, maybe go get a job?|'No one will hire me man! I'm Dumb!'|Well summer's coming up, you could be a lifeguard?|'Yoo! You're right! I would get to flex my bod too!'",
            "'Hey! I wanna have a cool nickname!'|Why?|'Bro my name sounds so boring right now! I need something to pump it up!'|Hmmmm, I see. How about-<???????????????????????????????????????????????????????????????????????????????????????????????????????0",
            "!0"
        }, 0);

        lang.addLanguage(new string[]{
            "'嘿'|嘿|'我有一个问题要问你！'|是的？|'从一到十，我有多棒！'|我不知道？ 七？|'七？？？'|十？|'哈！ '",
            "'嘿嘿！'|你好|'我希望太阳变得更大！ 我想向你们这些傻瓜屈服！ | 留到我走的时候吧...|'不！ 记住我的话，明天你会看到我的大肌肉！'",
            "'我的性格太好了！'|好是好? 这就是现在的女孩喜欢的东西？|'什么？！ 我需要提升我的个性！'",
            "嘿|'保持坚强……'|嗯，发生什么事了吗？|'天气。 这么阴郁？'|我有点喜欢这样|'好吧，你看起来有点沮丧。'",
            "'哟！'|你好|'你准跑步了吗？'|是的，我准备好了|'完美的跑步天气！'|嗯，当然。|'嘿！ 开心点！ 现在是跑步的最佳时机！'",
            "你好|'兄弟，我破产了' |嗯，找份工作？|'没有人会雇用我！ 我是哑巴！'|夏天快到了，你可以当救生员吗？|'哟！ 正确的！'",
            "'嘿！ 我想要一个很酷的昵称！'|为什么？|'兄弟，我的名字现在听起来很无聊!'|嗯，我明白了。 那-<???????????????????????????????????????????????????????????????????????????????????????????????????????0",
            "!0"
        }, 1);

        lang.addLanguage(new string[]{
            "'嘿'|嘿|'我有一個問題要問你！'|是的？|'從一到十，我有多棒！'|我不知道？ 七？|'七？？？'|十？|'哈！ '",
            "'嘿嘿！'|你好|'我希望太陽變得更大！ 我想向你們這些傻瓜屈服！ | 留到我走的時候吧...|'不！ 記住我的話，明天你會看到我的大肌肉！'",
            "'我的性格太好了！'|好是好? 這就是現在的女孩喜歡的東西？|'什麼？！ 我需要提升我的個性！'",
            "嘿|'保持堅強……'|嗯，發生什麼事了嗎？|'天氣。 這麼陰鬱？'|我有點喜歡這樣|'好吧，你看起來有點沮喪。'",
            "'喲！'|你好|'你準跑步了嗎？'|是的，我準備好了|'完美的跑步天氣！'|嗯，當然。|'嘿！ 開心點！ 現在是跑步的最佳時機！'",
            "你好|'兄弟，我破產了' |嗯，找份工作？|'沒有人會僱用我！ 我是啞巴！'|夏天快到了，你可以當救生員嗎？|'喲！ 正確的！ '",
            "'嘿！ 我想要一個很酷的暱稱！'|為什麼？|'兄弟，我的名字現在聽起來很無聊!'|嗯，我明白了。 那-<????????? ?????????????????????????????????????????????????? ????????????????????????????????????????????0",
            "!0"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
