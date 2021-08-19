using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human4 : Classmate
{
    protected override void initHumanNum() => humanNum = 4;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "3 14 37 30";//to school base
        path[arrivalButNotTheMoviePartTwo+1] = "30";
        path[arrivalButNotTheMoviePartThree] = "21 0";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#CEE465";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'*Yawn* I woke up way too early'|How many hours of sleep did you get?|'eight'|That's pretty normal, how much do you usually sleep?|'Nine and a half'|That's honestly pretty impressive|'I have mastered the art of sleeping!'",
            "'I think I might have caught a cold'|What happened?|'I'm just feeling totally under the weather.'|Did you just not sleep enough?|'I can never get enough sleep, so it might be part of the problem'|Well I hope you get better soon?",
            "'Why is it always so bright in the morning, my eyes hurt.'|Do you enjoy sleeping in?|'Of course!! It's soooooo nice!'|Wait, how much do you sleep in during the weekends?|'...Um... I don't know, maybe 3?'|I'm sorry what?",
            "Why do you like eating so much?|'I've been on the hunt for the best tasting food! You have to find it somehow!'|I see, well what's the best right now?|'I've forgotten'|Doesn't that defeat the whole quest?|'What??? I'll know it when I taste it!'|Well let me know when you find it.",
            "How often do you eat out?|'Well...Maybe once or twice a day?'|Wait, how do you fit two in a day? And doesn't it cost lots?|'Guess what? Once I even had 5 in a day!'|I'm both impressed, and concerned.|'I guess it costs a lot too, but it's well worth it!",
            "'Oh, good! I've been looking all over for you!'|Really? why?|'*Yawn* But first, why do we need to get up so early in the morning all the time?'|Because education is important?|'Hmmm... Why can't it all be just shifted back a few hours!|Well not everyone sleeps in as much as you",
            "'Oh, hiya!'|That's new|'You think? It's something I heard in a tv commercial'|Was it a food commercial?|'Hey, what are you implying here?'|Was it a food commercial?|'I was going to offer you a snack, but not anymore!'|Oh ok, well I guess sucks to be me.|'Aw, I was hoping you would beg!'|Lmao, I'll pass",
            "'Hey! Something about today feels weird'|Oh really?|'*Yawn* I think I just didn't sleep or eat enough'|Oh, makes sense I guess|'Anyways I have to get going now! Goodbye!'"
        }, 0);

        lang.addLanguage(new string[]{
            "'*หาว* วันนี้ฉันตื่นเช้าเกินไป'|นายนอนได้กี่ชั่วโมงหน่ะ?|'แปด'|นั่นมันปกติสุดๆ เลยนะ ปกตินอนเท่าไหร่เนี่ย?|'เก้าชั่วโมงครึ่ง'|นั่นมันช่างน่าประทับใจเหลือเกิน|'ฉันเป็นผู้เชี่ยวชาญศิลปะด้านการนอนหลับหน่ะ!'",
            "'ฉันว่าฉันกำลังจะเป็นหวัดแล้วแน่เลย'|เกิดอะไรขึ้นเหรอ?|'ฉันรู้สึกไม่ค่อยสบายหน่ะ'|นายแค่นอนไม่พอรึเปล่า?|'ฉันนอนเท่าไหร่ก็ไม่เคยพอ มันคงเป็นส่วนหนึ่งของปัญหานี่หล่ะ'|อืมม ยังไงก็ขอให้อาการดีขึ้นเร็วๆ นี้นะ",
            "'ทำไมตอนเช้าถึงต้องสว่างขนาดนี้ด้วยเนี่ย ฉันแสบตาไปหมดแล้ว'|นายชอบนอนตื่นสายไหม?|'แน่นอนอยู่แล้ว!! มันดีมากกกกกก!'|เดี๋ยวนะ นายนอนตื่นสายไปมากเท่าไหร่ในวันหยุดสุดสัปดาห์เนี่ย?|'...เอิ่ม… ไม่รู้สิ น่าจะ 3 มั้ง?'|ห๋าา อะไรนะ?",
            "ทำไมนายชอบการกินจังเลย?|'ฉันตามล่าอาหารที่รสชาติดีที่สุดมานานแล้ว แล้วก็จะตามหาต่อไป! ยังไงก็ต้องหาให้เจอให้ได้!'|อ๋อ... อืมมม แล้วที่ดีที่สุดตอนนี้คืออะไรหล่ะ?|'ฉันลืมไปแล้วแฮะ'|ไม่ใช่ว่านั่นคือการพิชิตภารกิจทั้งหมดของนายเหรอ?|'ห๊ะ??? พอฉันได้ชิมเดี๋ยวก็รู้เองแหละน่า!'|งั้นถ้าเจอแล้วก็บอกฉันด้วยหล่ะ",
            "นายออกไปกินข้าวนอกบ้านบ่อยขนาดไหน?|'อืมม...น่าจะครั้ง สองครั้งต่อวันมั้งนะ?'|เดี๋ยวนะ นายจัดงบให้พอดีกับการกินข้าวนอกบ้านสองครั้งต่อวันได้ยังไงหน่ะ? ไม่ใช่ว่ามันแพงมากเลยเหรอ?|'ให้ทาย? ฉันเคยกิน 5 ครั้งต่อวันด้วยซ้ำ!'|ฉันทั้งรู้สึกประทับใจทั้งเป็นห่วงเลยนะเนี่ย|'ฉันว่ามันก็เสียตังค์เยอะเหมือนกันนะ แต่มันก็คุ้มค่าดี!",
            "'โห ดีเลย! ฉันกำลังตามหานายไปทั่ว!'|จริงเหรอ? ทำไมหล่ะ?|'*หาว* แต่อันดับแรก ทำไมฉันต้องตื่นเช้าทุกครั้งเลยนะ?'|ก็เพราะการเรียนมันสำคัญมั้งนะ?|'อืมมม...ทำไมพวกมันถึงไม่เลื่อนออกไปซักชั่วโมงสองชั่วโมงหน่อยนะ!|ก็ไม่ใช่ทุกคนที่จะนอนตื่นสายมากแบบนายนี่นา",
            "'โอ้ ไฮ้ยาาา!'|คำแปลกดีนะ|'คิดว่างั้นเหรอ? มันเป็นอะไรที่ฉันได้ยินมาจากโฆษณาบนทีวีหน่ะ'|มันคือโฆษณาอาหารเหรอ?|'เฮ้ นี่นายกำลังจะสื่ออะไรหน่ะ?'|มันคือโฆษณาอาหารรึเปล่า?|'ฉันกำลังจะแบ่งขนมให้นาย แต่ตอนนี้ไม่ให้แล้ว!'|อ่า โอเค ฉันแย่เองแหละ|'โหหห ฉันอุตส่าห์หวังว่านายจะขอนะเนี่ย!'|อยากจะขำกลิ้ง ฉันขอผ่านก็แล้วกัน",
            "'เฮ้! วันนี้มันมีอะไรแปลกๆ ไปนะ'|หืมม จริงเหรอ?|'*หาว* ฉันว่าฉันกินไม่พอหรือไม่นอนไม่พอ'|อ่า ก็คงงั้นแหละมั้ง|'ยังไงก็ช่างเถอะ ฉันต้องไปแล้วหล่ะ! ลาก่อนนะ!'"

        }, 1);

        tcsPos = lang.getLanguage();
    }
}
