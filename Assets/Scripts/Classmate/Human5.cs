using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human5 : Classmate
{
    protected override void initHumanNum() => humanNum = 5;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "2 31 28 16";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "17";
        path[arrivalButNotTheMoviePartThree + 2] = "19 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#78CBB5";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "Hello|'Ayo, Need something lad?'|Oh I was just saying hi|'I gotchu bro, what's up fella?'|Nothing much, uh, how about you?|'I'm feeling awesome! I'm excited to get to know you more buddy!'",
            "'Whatcha doing lad?'|Uh, standing?|'Haha! I meant like in general, howz school, howz life?'|Oh ok, school's fine, and my life is okay too I guess|'Bro! You need to talk more man!'",
            "'Ya like music at all?'|Yea, I enjoy it for the most part I think?|'Nice! What kind of music?'|I don't really know what it's called, just lots of weird stuff, how about you?|'Rock!'",
            "'Ayo, you wanna follow me?'|I'm sorry what?|'I found a new running trail today! I need some buds to check it out with me!'|Hmm, sorry but I'll pass.|'Awwwwww man! Well I won't force you!",
            "'Hey, I need to ask you a question'|Yep?|'Are dinosaurs really birds? Like bro when I heard that, I remembered that they both lay eggs!'|I think it's the other way around, like the square rectangle thing.|'The what?'",
            "'Hey man, can you help me with a calc question?'|Uhhhhhhh, sure?|'So like the separation of variables crap, how does that work?'|Uhhhhhhhhh, listen, I honestly forgot how that stuff worked...",
            "'Ayo, there's a firework show soon! Me and my buddies are going to check it out! Wanna hop in?'|Uhhh, sorry, I'm kinda busy these days.|'Awww man, just one day brosky?'|Sorry, I really can't|'That sucks.'",
            "Heyo!|'Yo what's up fam!'|Uhm, nothing much, how about you?|'Pretty good!'|That's nice.|'Yea man!'"
        }, 0);

        lang.addLanguage(new string[]{
            "สวัสดี|'เอโย่ มีไรป่าวพวก?'|เปล่าหรอก ก็แค่ทักทาย|'เข้าใจละพวก เป็นไงบ้างเพื่อน?'|ก็ไม่อะไรมาก เอ่อ นายหล่ะเป็นไงบ้าง?|'ฉันรู้สึกเจ๋ง! ตื่นเต้นที่จะได้รู้จักนายมากขึ้นนะพวก!'",
            "'ทำไรอยู่พวก?'|อ่า ยืนอยู่?|'ฮะฮ่า! ฉันหมายถึงเรื่องทั่วๆ ไป เรียนเป็นไง ชีวิตเป็นไงบ้าง?'|อ๋อ โอเค เรียนก็ปกติดีนะ แล้วชีวิตก็โอเคดีเหมือนกัน ฉันว่านะ|'พวก! นายต้องคุยเยอะๆ กว่านี้นา!'",
            "'นายชอบฟังเพลงป๊ะ?'|ช่าย ส่วนมากฉันก็ชอบนะ คิดว่างั้น?|'เยี่ยม! ชอบเพลงแบบไหนหล่ะ?'|ฉันก็ไม่ค่อยรู้ว่ามันเรียกว่าอะไร แค่เสียงแปลกๆ เยอะๆ หน่ะ แล้วนายหล่ะ?|'ต้องเพลงร็อค!'",
            "'เอโย่ อยากไปด้วยป๊ะ?'|โทษนะ อะไรนะ?|'วันนี้ฉันเจอทางวิ่งใหม่! ฉันอยากมีเพื่อนไปดูด้วยกันหน่อยหน่ะ!'|อืมมม ขอโทษทีนะ แต่ฉันต้องขอผ่าน|'โห่ พวกกกกก! อืมมม ฉันไม่บังคับแล้วกัน!",
            "'เฮ้ ฉันอยากถามอะไรหน่อยได้ป๊ะ'|เอาดิ?|'พวกไดโนเสาร์นี่เป็นนกจริงป๊ะ? พอดีไปได้ยินมาแบบนั้น ฉันจำได้ว่าพวกมันทั้งคู่วางไข่เหมือนกัน!'|ฉันคิดว่ามันกลับกันนะ เหมือนทฤษฎีสี่เหลี่ยมจตุรัสกับสี่เหลี่ยมผืนผ้าหน่ะ|'ทฤษฎีอะไรนะ?'",
            "'เฮ้ พวก นายช่วยฉันทำการบ้านคณิตหน่อยได้ป่าว?'|อ่าาาาาาา ได้มั้ง?|'คือฉันต้องการแยกตัวแปรอะไรบ้าๆ นี่ มันทำยังไงวะ?'|อ่าาาาาาาาาา ฟังนะ จริงๆ ฉันก็ลืมมันไปแล้วว่าต้องทำยังไง…",
            "'เอโย่ เดี๋ยวก็มีงานดอกไม้ไฟแล้วนะ! ฉันกับพวกเพื่อนๆ จะไปดูสักหน่อยหล่ะ! ไปด้วยป๊ะ?'|อ่าาา ขอโทษทีนะ ช่วงนี้ฉันยุ่งๆ หน่ะ|'โห่ พวกกก แค่วันเดียวเองป๊ะ?'|ขอโทษนะ ไปไม่ได้จริงๆ |'แย่จัง'",
            "เฮ้โย่!|'โย่ เป็นไงบ้างพวก!'|อืมม ไม่ค่อยเท่าไหร่ นายหล่ะเป็นไงบ้าง?|'ดีสุดๆ !'|นั่นเยี่ยมเลย|'ใช่เลย พวก!'"
        }, 1);


        tcsPos = lang.getLanguage();
    }
}