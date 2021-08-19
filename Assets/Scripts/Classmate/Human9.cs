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
            "'ฉันคิดว่าการเรียนมันยากเกินไป ฉันหวังให้พวกเขาทำมันให้ง่ายขึ้น'|อ่าา ก็แย่อยู่นะ ฉันว่าแค่ปล่อยๆ มันไปก็พอมั้ง?|'ก็ ฉันแค่เกลียดที่มันกินเวลาหน่ะ ตามจริงงานมันก็ง่ายๆ แหละมั้ง?'|อ๋อ ยังไงก็อย่าเครียดมากแล้วกัน",
            "เธอนี่มีกลิ่นเป็นเอกลักษณ์มากนะ!|'ในทางที่ดีหรือแย่เหรอ?'|น่าจะในทางที่ดีนะ?|'งั้นก็ดี ฉันจะเห็นด้วยเลย ฉันตั้งใจใช้เวลาสร้างมันขึ้นมาเลยนะเนี่ย'",
            "'เฮ้ ฉันยังป๊อปปูล่าอยู่ใช่ไหม?'|แน่สิ!|'แน่สิเหรอ? หมายความว่าไง?'|ก็แบบ ฉันคิดว่าเธอยังค่อนข้างป๊อปปูล่าอยู่นะ!|'จริงสิ... ฉันว่านายคงไม่ค่อยรู้เรื่องอะไรแบบนี้อะนะ'|แหะๆ ก็จริงนะ",
            "'ฉันหวังว่าฉันจะได้อยู่ใกล้ๆ นายมากขึ้น!'|โอ้ น่าสนใจดีนี่ ทำไมหล่ะ?|'เมื่อคืนฉันนึกขึ้นได้ว่าฉันอยากจะคุยกับนาย!'|อ๋อ แหะๆ ฉันว่าเธอก็ส่งข้อความมาหาฉันได้นะ?|'ม่ายอะ! ฉันอยากคุยกะนายต่อหน้านี่นา!'",
            "ไง!|'ฉันว่านายควรจะลองใส่เสื้อผ้าชุดใหม่นะ!'|อ่า แบบไหนหล่ะ?|'อะไรสักอย่างที่ไม่ใช่กางเกงยีนส์กับเสื้อยืดหน่ะ?'|อ่า ฉันว่ามันคงยากหน่อยนะ…",
            "'ฉันหนาวสุดๆ !'|แย่จัง ไหวไหมนั่น อืมม.. ฉันว่ามันก็เป็นเวลาดีที่จะเริ่มใส่เสื้อผ้าหนาขึ้นหล่ะนะ|'หรือออออออออไม่ก็ นายให้ฉันยืมเสื้อแจ็คเก็ต!|'แต่แบบนั้น... ฉันก็หนาวสิ?|'โหหห เพื่อนน... อย่าทำหน้าเศร้าแบบนั้นสิ'",
            "'ฉันชอบทรงผมนายมากจริงๆ มันน่ารักดี!'|อ่า ขอบคุณนะ!|'ฉันคิดว่านายน่าจะปล่อยผมให้ยาวขึ้นอีกนิดนะ! มันคงจะดูดียิ่งขึ้นไปอีกหล่ะ!'|อ่า โอเค เดี๋ยวลองทำดู คิดว่านะ!",
            "'เฮ้ พรุ่งนี้นายอยากไปซื้อชานมไข่มุกกะฉันไหม?'|อ่าา เอ่ออ โทษทีนะ คงไปไม่ได้หน่ะ|'อ่า โอเค งั้นก็ไม่เป็นไร! ฉันแค่ถามหน่ะ!'"
        }, 1);

        tcsPos = lang.getLanguage();

    }
}
