using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human12 : Classmate
{
    protected override void initHumanNum() => humanNum = 12;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "3 37 40";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "22";
        path[arrivalButNotTheMoviePartThree + 1] = "20 2";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#996FCA";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "How was school today?|'I hate it so much. My group is so useless, I do so much work, and when I showed them, they didn't like it!'|Ah I see, well it's just one project I guess, maybe you'll get a better group next time?",
            "'Aw, maaaaaan'|Uh oh, what happened?|'I think I ate too late. I have a killer stomach cramp.'|That sucks, well, take it easy I guess, okay?|'Probably not, it'll go away soon, I know it.'",
            "'Do you like books at all?'|Ehhhh, not really. I only like a few books.|'Oh, well I hate reading so much. It's just so boring!'|Yea, I agree, I hate reading too.",
            "'I hate online classes so much!'|Oh really? I feel like it's easier at least?|'It's just so boring. The classes are just so horrible.'|Yea I guess, I still think I would prefer online though.",
            "How's school?|'It is literally the worst thing to ever exist. Why do the teachers make group assignments during online classes?? The breakout rooms are so horrible and awkward!'|Heh, yea. I agree!",
            "'Oh my god. Why does my teacher, NOT PUT UP THE ASSIGNMENT, AND GIVE EVERYONE A ZERO!!!'|Lmao, maybe your teacher just hates you guys?|'Sigh. Probably, school just sucks in general.'",
            "What do you want to do in the future?|'I honestly have no idea, I think my parents want me to be a doctor.'|Heh, typical parents I guess. Do you want to?|'I don't hate the prospect, but I don't know.",
            "'Do you enjoy listening to my random rants?'|Yea? It's pretty fun? Like it's very enjoyable?|'Ah okay, I always feel like I'm being annoying!'|Heh, not at all, I love it."
        }, 0);

        lang.addLanguage(new string[]{
            "วันนี้เรียนเป็นไงบ้าง?|'ฉันเกลียดมันสุดๆ คนในกลุ่มฉันไม่เอาถ่าน ฉันทำงานเยอะมาก แล้วพอเอาให้ดู พวกเขาก็ไม่ชอบมัน!'|อ่าวเหรอ แต่ก็ยังดีนะที่เป็นแค่งานเดียว รอบหน้าอาจจะได้กลุ่มดีๆ ก็ได้นะ",
            "'โหห โอ๊ยยยยยย'|อ่าว เกิดไรขึ้นหน่ะ?|'ฉันคงกินข้าวช้าไป ปวดท้องจะตายแล้ว'|แย่จัง อืม อดทนไว้ก่อนก็น่าจะได้นะ โอเคไหม?|'อาจจะไม่ขนาดนั้น ฉันรู้ว่าอีกเดี๋ยวก็หายปวดท้องเองหล่ะ'",
            "'นายชอบหนังสือรึเปล่า?'|เอ... ก็ไม่เชิงชอบนะ ชอบแค่บางเล่มหน่ะ|'อ่า ดีเลย ฉันหล่ะเกลียดอ่านสุดๆ น่าเบื่อมากๆ !'|ช่าย เห็นด้วยเลย ฉันก็ไม่ชอบอ่านหนังสือเหมือนกัน",
            "'ฉันเกลียดการเรียนออนไลน์สุดๆ !'|อ่า จริงเหรอ? อย่างน้อยฉันก็รู้สึกว่ามันง่ายดีนะ?|'มันน่าเบื่อมากหน่ะ เลยทำให้คาบเรียนดูแย่ไปเลย'|ช่าย ก็คงงั้น ถึงฉันจะชอบการเรียนออนไลน์มากกว่าก็เถอะ",
            "เรียนเป็นไง?|'มันคือเรื่องที่แย่ที่สุดเท่าที่เคยมีมาเลย ทำไมครูถึงต้องให้งานกลุ่มในคาบเรียนออนไลน์เนี่ย?? กลุ่มเรียนย่อยมันรู้สึกน่ากลัวแล้วก็น่าอึดอัดสุดๆ!'|หึ ช่ายย เห็นด้วย!",
            "'โอ้คุณพระคุณเจ้า ทำไมครูที่ไม่ยอมบอกงานถึงให้คะแนนทุกคนเป็นศูนย์ด้วยเนี่ย!!!'|อยากจะร้องไห้ ครูไม่ชอบพวกเธอรึเปล่าเนี่ย?|'เห้ออ ก็อาจใช่ ปกติโรงเรียนก็ห่วยอยู่แล้ว'",
            "เธออยากจะทำอะไรในอนาคตเหรอ?|'จริงๆ ฉันก็ไม่รู้นะ คิดว่าพ่อกับแม่คงอยากให้เป็นหมอแหละ'|หึ ก็เหมือนพ่อแม่โดยทั่วไปสินะ เธออยากเป็นรึเปล่าหล่ะ?|'ถ้าได้เป็นก็ดี แต่ก็ไม่รู้สิ",
            "'นายชอบการพูดตรงๆ ของฉันรึเปล่า?'|ช่ายแหละมั้ง? มันก็สนุกดีนะ? แบบว่าก็เพลินดี?|'อ่า โอเค ฉันรู้สึกว่าตัวเองน่ารำคาญตลอดเลย!'|หึ ไม่เลย ฉันชอบนะ"
        }, 1);

        tcsPos = lang.getLanguage();
    }
}
