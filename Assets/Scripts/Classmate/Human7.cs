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
            "เฮ้|'หือ? โอ้ ฉันว่าฉันเคยเห็นนายมาก่อนนะ'|อ่า… เดี๋ยวนะ จริงเหรอ?|'หือ? บางทีมันอาจจะเป็นคนอื่นก็ได้...'|...|'ขอโทษค่ะ นี่มันน่าอายจังเลย'|ไม่หรอก ไม่เป็นไร|'งั้นนายช่วยทำเป็นว่ามันไม่เคยเกิดขึ้นหน่อยได้ไหมง่ะ?'",
            "'นายต้องกินผักผลไม้มากกว่านี้นะ!'|*กลั้นขำ* เธอไม่ใช่แม่ของฉันสักหน่อย|'มันไม่ดีต่อสุขภาพนะจ๊ะถ้านายมัวแต่กินเบอร์ริโตที่อุ่นด้วยไมโครเวฟแบบนั้น!'|เดี๋ยวระบบเผาผลาญฉันก็จัดการกับมันเอง ไม่เป็นไรหรอกหน่าาาาา...|'ฉันจะทำให้นายแข็งแรงขึ้นเอง!'|ฉันไม่คิดว่าการทำแบบนั้นจะช่วยได้จริงๆ นะ",
            "เฮ้!|'นายต้องดูแลตัวเองให้มากกว่านี้นะ'|เธอมีเรื่องพูดแค่นี้เหรอ?|'นายนี่จริงๆ เลย! กินผลไม้สดมันจะยากแค่ไหนกันเชียว!'|ก็ฉันต้องออกจากห้องไปหาผลไม้มากิน แค่นั้นมันก็ลำบากเกินไปแล้ว|'นั่นน่าเป็นห่วงนิดหน่อย แต่ก็ไม่เป็นไร'",
            "'นายจะไปเข้าชุมนุมไหมง่ะ?'|มีชุมนุมวันนี้เหรอ?|'ใช่สิ! เขาประกาศอาทิตย์ที่แล้วไง!'|เธอจะเสียงดังทำไมเนี่ย|'มันเป็นเสน่ของฉันไงหล่ะ~'|เหรออออ|'นายควรจะเป็นคนที่เป็นมิตรกว่านี่นะ!'|ไม่ ไม่เอา ไม่เป็น!",
            "'ทำไมนายดู... เศร้าจังเลย'|จริงๆ แล้วฉันก็ไม่รู้ มันน่าจะเป็นแค่เพราะฉันนอนไม่พอ หรืออะไรสักอย่างนี่แหละ|'ฉันว่าความเศร้าของนายเป็นเพราะสภาพอากาศวันนี้นะ หนาวๆ เปียกๆ ง่ะ'|เธอรู้รึเปล่าว่าหน้าฝนเป็นฤดูที่ฉันชอบ?|'ห่ะ? ทำไมง่ะ?'|ไม่รู้สิ แค่ชอบมันหน่ะ",
            "ฉันมีคำถามมาถามเธอด้วยหล่ะ|'นายคิดว่านายจะทักทายฉันก่อนไหมง่ะ?'|อ่าาา ห่ะ?|'แบบว่า “ไง” หรือ “สวัสดี”'|มันสำคัญขนาดนั้นเลยเหรอ?|'คนอื่นอาจคิดว่านายเป็นคนหยาบคายได้นะ พูดหน่อยก็ไม่เสียหายนี่'|ก็ได้ งายย~ วันดีๆ แบบนี้ คุณสบายดีไหมครับ~|'ขอบคุณจ้าาา~ แล้วก็หยุดเสียดสีได้แล้ว'|ผมว่าผมจะไม่หยุดนะ",
            "'นายเคยมีชื่อเล่นรึเปล่า?'|ทำไมเหรอ?|'ฉันมีชื่อเล่นเจ๋งๆ มาให้นายด้วยหล่ะ!'|ไม่เอาหล่ะ|'ไม่เอาจริงเหรอ? มันตลกมากเลยนะ!'|ความตลกของเราสองคนมันไม่ค่อยเข้ากันอยู่แล้ว|'เฮ้! เซ้นส์ฉันดีกว่านายอีกนะ!'|ฉันบอกว่ามันไม่เหมือนกัน ไม่ใช่ว่าใครดีกว่า ถึงฉันจะไม่เห็นด้วยกับที่เธอว่าก็เถอะร|'เฮ้!'",
            "'ถ้านายอยากทำอะไรก็ได้ที่อยากทำ นายจะทำอะไรง่ะ'|ถามโง่ๆ |'เชอะ! ฉันหน่ะอยากจะท่องเที่ยวไปทั่วโลก!'|ไม่ใช่ว่าทุกคนก็อยากทำแบบนั้นเหรอ?|'แล้วไงหล่ะ~ ฉันก็ยังอยากทำมันอยู่ดี'|อ่า งั้นก็ขอให้สนุก|'แน่นอน! โทษทีนะแต่ฉันต้องไปที่อื่นก่อนหน่ะ ไว้คุยกันคราวหน้านะ!'|ไว้คุยกันคราวหน้า"
        }, 1);

        tcsPos = lang.getLanguage();
    }
}
