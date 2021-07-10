using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human11 : Classmate
{
    protected override void initHumanNum() => humanNum = 11;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "6 15 34";//to school base
        path[arrivalButNotTheMoviePartTwo] = "24";
        path[arrivalButNotTheMoviePartThree - 1] = "25 10 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#A0C1EE";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'Heya! Thanks for helping me out over the summer!'|Oh, it was no big deal|'I still have trouble keeping the edges clean, but I think I'm getting better!'|That's good, at least you're doing something|'Yessss! I'm going to keep being more productive!!'",
            "When did you sleep?|'*Sniff* I got sick again'|I assume you already took your medicine?|'It tasted gross, why did my mom force me take chinese medicine...'|It's probably good for you to some extent|'Wahhhhhhhh not you too- *Ahchoo*'|Although I do think western medicine probably works better.",
            "Are you feeling better?|'no.'|...|Did it get worse?|'yes- Actually maybe it stayed the same.'|I think that's still a good sign|'That's hard for me to believe, it hurts so much'|I guess it's more like you probably reached the worst that it can get?|'Really? But I feel sooo horrible.'|Hang in there.",
            "How are you feeling today?|'I think I feel better.'|That's good|'Ugh... the awful taste of medicine is still in my mouth.'|Do you have water?|'I already tried that, but I can't wash the taste out!'|Well it'll come out eventually|'It's just soo bitter'",
            "'*Ahchoo*'|You good?|'Wahhhhhh I think it got worse again, I'm sore all over'|Did anything change?|'Wait. Have you not noticed? It's so much colder!!!'|It has? I guess the mornings are more cold these days.",
            "'It's s-so c-cold... w-why d-did it get so c-c-cold.'|I think you should stay home for the day.|'I told my mom that I felt so s-sick, but she won't let me!'|Well take it easy today I guess, do you want my jacket?|'Hmmmm, I'll be fine once I get into a room and also won't you be cold?|'Well if you need it, you can ask.",
            "'Heyaa!!'|Oh, I see you have gotten better?|'It's so weird! It was just like I was never sick!'|I guess medicine does help-|'Please please please don't bring it up again. I can still taste it whenever I think about it!|Oh lmao, whoops.|'I'm so excited to resume life normally!'",
            "'OK, if you could have anything you want, what would you want?'|Huh? Why?|'Just answer it!'|Uhhh, I don't know|'Aww that's so boring!'|Yea, well I have to get going, see you."
        }, 0);

        lang.addLanguage(new string[]{
            "'嘿嘿！ 谢谢你帮助我！'|哦，没什么大不了的|'我仍然很难保持边缘清洁，但我想我正在变得更好！'|那很好，至少你正在做一些事情|'是的 ！ 我将继续提高生产力！！'",
            "你什么时候睡的？|' 我又生病了'|你吃药了吗？|'味道很恶心，为什么我妈逼我吃中药...'|可能对你有一定的好处|'你也不是-'|我觉得是西式的 药物效果更好。",
            "你感觉好点了吗？|'没有。'|...|有没有变得更糟？|'它保持不变。'|我认为这仍然是一个好兆头|'这让我难以置信，太痛了' |更像是你达到了它所能达到的最坏状态？。真的吗？ 但我觉得太可怕了。'|坚持住。",
            "你今天感觉如何？|'我觉得我感觉好多了。'|很好|'呃……药的味道还在我嘴里。'|你有水吗？|'我已经试过了，但是 我洗不掉味道！太苦了'",
            "你还好吗？|'哇哦，我觉得它又变得更糟了，我浑身酸痛'|有什么变化吗？|'等等。 你没有注意到吗？ 冷多了！！！'|是吗？ 我猜这几天早上更冷了。",
            "'太冷了...为什么会这么冷。'|我觉得你应该呆在家里一天。|'我告诉我妈妈我感觉很不舒服，但她 不让我！'|我想今天放轻松一点，你想要我的夹克吗？|'嗯，我一进房间就没事了，你不冷吗？'|好吧，如果 你需要，你可以问。",
            "'嘿嘿！！'|哦，我看你好了？|'这太奇怪了！ 就像我从来没有生病一样！'|我想药物确实有帮助-|'请不要再提了。 每当我想到它时，我仍然可以重新品尝它！'|哦，哎呀。|'我很高兴能够恢复正常生活！'",
            "“如果你可以拥有任何你想要的东西，你想要什么？”|嗯？ 为什么？|'回答就行！'|呃，我不知道|'哇，太无聊了！'|是的，我得走了，见。"
        }, 1);

        lang.addLanguage(new string[]{
            "'嘿嘿！ 謝謝你幫助我！'|哦，沒什麼大不了的|'我仍然很難保持邊緣清潔，但我想我正在變得更好！'|那很好，至少你正在做一些事情|'是的！ 我將繼續提高生產力！！'",
            "你什麼時候睡的？|' 我又生病了'|你吃藥了嗎？|'味道很噁心，為什麼我媽逼我吃中藥...'|可能對你有一定的好處|'你也不是-'|我覺得是西式的藥物效果更好。",
            "你感覺好點了嗎？|'沒有。'|...|有沒有變得更糟？|'它保持不變。'|我認為這仍然是一個好兆頭|'這讓我難以置信，太痛了' |更像是你達到了它所能達到的最壞狀態？。真的嗎？ 但我覺得太可怕了。'|堅持住。",
            "你今天感覺如何？|'我覺得我感覺好多了。'|很好|'呃……藥的味道還在我嘴裡。'|你有水嗎？|'我已經試過了，但是我洗不掉味道！太苦了'",
            "你還好嗎？|'哇哦，我覺得它又變得更糟了，我渾身酸痛'|有什麼變化嗎？|'等等。 你沒有註意到嗎？ 冷多了！！！'|是嗎？ 我猜這幾天早上更冷了。",
            "'太冷了...為什麼會這麼冷。'|我覺得你應該呆在家裡一天。|'我告訴我媽媽我感覺很不舒服，但她不讓我！'|我想今天放輕鬆一點，你想要我的夾克嗎？|'嗯，我一進房間就沒事了，你不冷嗎？'|好吧，如果你需要，你可以問。",
            "'嘿嘿！！'|哦，我看你好了？|'這太奇怪了！ 就像我從來沒有生病一樣！'|我想藥物確實有幫助-|'請不要再提了。 每當我想到它時，我仍然可以重新品嚐它！'|哦，哎呀。|'我很高興能夠恢復正常生活！'",
            "“如果你可以擁有任何你想要的東西，你想要什麼？ ”|嗯？ 為什麼？|'回答就行！'|呃，我不知道|'哇，太無聊了！'|是的，我得走了，見。"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
