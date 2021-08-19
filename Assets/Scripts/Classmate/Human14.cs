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
            "'เอโย่'|สวัสดี|'ฉันมีคำถามมาถามแกด้วยหล่ะ!'|เอาดิ?|'จากหนึ่งถึงสิบเนี่ย ฉันเท่ขนาดไหน!'|ฉัน- ฉันไม่รู้สิ? อาจจะเจ็ดแหละมั้ง?|'อะโห เพื่อน! แค่เจ็ดเองเหรอ???'|ฉันหมายถึงสิบหน่ะ ฉันพูดผิดเอง|'ฮ่า! เพื่อน!!!'",
            "'เป็นไง!'|สวัสดี|'ฉันอยากให้ดวงอาทิตย์มันใหญ่ขึ้นกว่านี้! ฉันจะยกมันทุ่มใส่หน้าพวกแกทั้งหมดเลย!'|ฉั- นายเอาไว้ทำตอนฉันไม่อยู่เถอะนะ...|'หึ! จำคำฉันไว้เลย พรุ่งนี้แกจะได้เห็นกล้ามแน่นๆ ของฉันแน่!'",
            "'เหอะ! บุคลิกฉันนี่มันแสนดีเกินไปจริงๆ!'|ดีก็เป็นเรื่องที่ดีแล้วนี่? เดี๋ยวนี้สาวๆ ก็ชอบแบบนั้นกันนี่นา?|'ห่ะ?! แบบนี้ฉันก็ต้องเสริมบุคลิกตัวเองเพิ่มแล้วสิ!'|ฉันหมายความว่า… เอาเถอะ ถ้านายอยากทำหน่ะนะ|'อั๊ยยะะะะ งี้สิเพื่อนรัก!'",
            "เฮ้โย่|'เข้มแข็งไว้นะพวก...'|เอิ่ม เกิดอะไรขึ้นรึเปล่า?|'อากาศมันอึมครึมมาก มันจะไม่ทำให้แกรู้สึกแย่รึไง?'|ฉันค่อนข้างที่จะชอบให้มันเป็นแบบนี้นะ ฉันว่ามันสบายตาดี|'เหรอ แต่แกดูเศร้าๆ นะ'",
            "'โย่!'|สวัสดี|'แกพร้อมไปวิ่งพรุ่งนี้รึยัง!'|ช่าย พร้อมแล้ว|'แกต้องชอบอากาศแบบช่วงนี้แน่! อากาศที่สมบูรณ์แบบสำหรับการวิ่ง!'|เอ่ออ แน่นอน แหละมั้ง?|'เฮ้! ร่างเริงหน่อยพวก! วิ่งตอนนี้ดีกว่าตอนไหนๆ ซะอีกนะ!'",
            "สวัสดี|'เพื่อน ฉันถังแตกสุดๆ เลย'|อืมม ลองหางานทำดูไหมหล่ะ?|'ไม่มีใครเขาจ้างฉันหรอกพวก! ฉันโง่หน่ะ!'|อ่า เดี๋ยวก็ฤดูร้อนแล้ว นายลองไปเป็นเจ้าหน้าที่ไลฟ์การ์ดไหมหล่ะ?|'โย่วว! แกพูดถูกแผง! ฉันจะได้ไปเบ่งกล้ามเจ๋งๆ นี่ด้วย!'",
            "'เฮ้! ฉันอยากมีชื่อเล่นเจ๋งๆ สักหน่อย!'|ทำไมหล่ะ?|'เพื่อน ชื่อฉันมันฟังดูน่าเบื่อมาก! อยากได้อะไรมาทำให้มันดูเจ๋งกว่าเดิมหน่ะ!'|อืมมมม เข้าใจละ งั้นเอาแบบนี้ไหม-<???????????????????????????????????????????????????????????????????????????????????????????????????????0",
            "!0"
        }, 1);


        tcsPos = lang.getLanguage();
    }
}
