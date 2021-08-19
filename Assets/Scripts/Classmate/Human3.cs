using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human3 : Classmate
{
    protected override void initHumanNum() => humanNum = 3;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "3 5 31 28";//to school base
        path[arrivalButNotTheMoviePartTwo] = "29";
        path[arrivalButNotTheMoviePartThree] = "23 25 2";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#F3B87E";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'Do you want to accompany me to a movie sometime?'|Sure! Sounds pretty fun!|'I'll be sure to include one more seat!'",
            "Why are the days so boring...|'I fancy you just don't have a purpose in life'|Oh.|'Just be sure to find a purpose and you will be much more happy!'",
            "'I cannot wait for the fireworks this year!'|Oh really? I guess they are super pretty.|'The sounds too, the loud booms, the crackles. Oh I love it so much!'",
            "'Why are so many people crazy?'|Huh?|'People sleep so late, sleeping at 11pm is already too extreme for me.'|Oh, well I think some people are just night owls? Like maybe they're more productive at night?",
            "Hello|'Sorry, I kinda have something something on my mind right now, and I do not think I can hold a conversation right now'|Oh ok, I'll talk to you later.",
            "'Do you enjoy watching movies?'|Uhhh, actually I don't exactly like them, they're too long I guess?|'Oh really? I'm surprised you don't'|Well I don't hate them, just not my favorite I guess.",
            "'I'm going to the farmer's market tomorrow? Do you want to tag along?'|Uhhhhh, I'm a little busy tomorrow, so probably not.|'Oh ok, that's fine!'",
            "'Can you come to my birthday party next week?'|Uhh, yea sure! I'll try to be there.|'Awesome! I'll be expecting you!'"
        }, 0);

        lang.addLanguage(new string[]{
            "'นายอยากไปดูหนังเป็นเพื่อนฉันหน่อยไหมสักครั้งนึง?'|เอาสิ! ฟังดูน่าสนุกดีนะ!|'ฉันจะเพิ่มที่นั่งให้อีกที่นะ!'",
            "ทำไมวันวันหนึ่งมันถึงได้น่าเบื่อขนาดนี้นะ...|'ฉันนึกว่านายไม่มีจุดมุ่งหมายในชีวิตซะอีก'|อ่า...|'แค่หาจุดมุ่งหมายให้เจอเดี๋ยวก็มีความสุขมากขึ้นเองหล่ะ!'",
            "'ฉันรอดูดอกไม้ไฟปีนี้แทบไม่ไหวเลย!'|จริงเหรอ? ฉันเดาว่าพวกมันต้องสวยสุดๆ เลย|'เสียงก็เหมือนกันนะ เสียงแตกดังตู้มมม แล้วก็เสียงแตกกระจัดกระจายดังแปรี๊ยะๆ โอ๊ย ฉันชอบมันมากๆ เลย!'",
            "'ทำไมพวกบ้าถึงเยอะจัง?'|หืมม?|'พวกเขานอนดึกมากขนาดนั้นได้ยังไงหน่ะ สำหรับฉันการนอน 5 ทุ่มก็หนักหนาสาหัสแล้ว'|อืมมม ฉันว่าบางคนก็แค่เป็นคนนอนดึกแหละมั้ง? แบบว่า พวกเขาน่าจะทำงานได้ดีขึ้นในตอนกลางคืนหน่ะ?",
            "สวัสดี|'ขอโทษนะ พอดีตอนนี้ฉันกำลังคิดอะไรบางอย่างอยู่ ฉันไม่คิดว่าฉันจะคุยตอนนี้ได้หน่ะ'|อ๋อ โอเค ไว้ค่อยคุยกันคราวหน้าแล้วกัน",
            "'นายดูหนังสนุกดีไหม?'|อืมมม จริงๆ ฉันไม่ค่อยชอบมันเท่าไหร่นะ มันคงยาวเกินไปละมั้ง?|'อ่าว จริงเหรอ? ตกใจจังที่นายไม่ชอบ'|ฉันก็ไม่ได้เกลียดมันหรอกนะ มันแค่ไม่ใช่หนังที่ฉันชอบหน่ะ ฉันว่านะ",
            "'พรุ่งนี้ฉันจะไปตลาดนัด นายอยากไปด้วยกันมะ?'|เอ่อออออ พรุ่งนี้ฉันยุ่งนิดหน่อย เพราะงั้น ฉันคงจะไม่ได้ไปนะ|'อ่า โอเค ไม่เป็นไร!'",
            "'อาทิตย์หน้านายมางานเลี้ยงวันคล้ายวันเกิดของฉันได้ไหม?'|เอ่อ... ได้ เอาดิ! ฉันจะพยายามไปให้ได้แล้วกัน|'เจ๋ง! ฉันจะรอนายนะ!'"
        }, 1);


        tcsPos = lang.getLanguage();
    }
}
