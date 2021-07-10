using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human9 : Classmate
{
    protected override void initHumanNum() => humanNum = 9;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "1 19 29 37";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "19";
        path[arrivalButNotTheMoviePartThree + 1] = "25 1";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#7ADAD0";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'I think school is too hard, I wish they just made it easier.'|Ah that sucks, I guess just take it easy?|'Well, I just hate how time consuming it is, the work is actually pretty easy?'|Oh, still take it easy I guess?",
            "You have a very unique smell!|'In a good or a bad way?'|In a good way?|'That's good, I would agree with you. I do spend time working on it.",
            "'Hey, I'm still popular right?'|Sure!|'Sure? What does that mean?'|Like I think you're still pretty popular!|'Yea, I guess you can't relate'|Heh, right.",
            "'I wish I lived closer to you!'|Oh, interesting. Why?|'Last night I realized I wanted to talk to you!'|Oh, heh. Well you could just message me I guess?|'Nope! I wanted to talk to you in person!'",
            "Hi!|'I think you should try new outfits!'|Oh, like what?|'Something other than jeans and t-shirt?'|Oh, I think that's too much effort...",
            "'I'm so cold!'|Oh that sucks, well I guess now's a good time to start wearing more?|'Orrrrrrrrr you can lend me your jacket!|'But, then I would be cold?|'Awww man... sad face'",
            "'I love your hair so much! It's cute!'|Oh, thank you!|'I think you could grow out your hair more though! It would look even better!'|Oh ok, I'll look into it I guess!",
            "'Hey, Do you want to go get boba with me tomorrow?'|Oh uh, sorry, probably not?|'Oh... ok then! I was just asking!'"
        }, 0);

        lang.addLanguage(new string[]{
            "'我觉得学校太难了，他们应该让学校更轻松。'|你应该放松一下|'好吧，我只是讨厌它多费时间，工作其实很容易？'|哦，好吧?",
            "你有一种非常独特的气味！|'好还是坏？'|好？|'很好，我同意你的看法。 我确实花时间研究它。'",
            "'嘿，我还是很有魅力的吧？'|当然！|'当然？ 那是什么意思？'|我觉得你还是很有魅力的！|'是的，我猜你不会联想到'|嘿，对...。",
            "'我希望我住在离你更近的地方！'|哦，有趣。 为什么？|'昨晚我意识到我想和你说话！'|哦，嘿。 你可以在网上给我发消息吗？|'不行！ 我想亲自和你谈谈！'",
            "嗨！|'你应该尝试新衣服！'|哦，像什么？|'牛仔裤和T恤以外的东西？'|哦，太费力了......",
            "'我好冷！你可以把你的夹克借给我吗?'|但是，那样我会冷的？|'啊... 悲伤的脸'",
            "'我非常喜欢你的头发！ 真可爱！'|哦，谢谢你！|'我觉得你的头发可以再长一些！ 看起来会更好！'|哦，好的。",
            "'嘿，明天要和我一起去喝奶茶吗？'|哦，对不起，我不能。|'哦……那好吧！'"
        }, 1);

        lang.addLanguage(new string[]{
            "'我覺得學校太難了，他們應該讓學校更輕鬆。'|你應該放鬆一下|'好吧，我只是討厭它多費時間，工作其實很容易？'|哦，好吧?",
            "你有一種非常獨特的氣味！|'好還是壞？'|好？|'很好，我同意你的看法。 我確實花時間研究它。'",
            "'嘿，我還是很有魅力的吧？'|當然！|'當然？ 那是什麼意思？'|我覺得你還是很有魅力的！|'是的，我猜你不會聯想到'|嘿，對...。",
            "'我希望我住在離你更近的地方！'|哦，有趣。 為什麼？|'昨晚我意識到我想和你說話！'|哦，嘿。 你可以在網上給我發消息嗎？|'不行！ 我想親自和你談談！'",
            "嗨！|'你應該嘗試新衣服！'|哦，像什麼？|'牛仔褲和T卹以外的東西？'|哦，太費力了......",
            "'我好冷！你可以把你的夾克借給我嗎?'|但是，那樣我會冷的？|'啊... 悲傷的臉'",
            "'我非常喜歡你的頭髮！ 真可愛！'|哦，謝謝你！|'我覺得你的頭髮可以再長一些！ 看起來會更好！'|哦，好的。",
            "'嘿，明天要和我一起去喝奶茶嗎？'|哦，對不起，我不能。|'哦……那好吧！'"
        }, 2);

        tcsPos = lang.getLanguage();

    }
}
