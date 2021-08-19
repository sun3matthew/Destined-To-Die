using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human15 : Classmate
{
    protected override void initHumanNum() => humanNum = 15;
    protected override void initPersonality() => personalityType = 2;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie+1] = "2 13 35";//to school base
        path[arrivalButNotTheMoviePartTwo] = "36";
        path[arrivalButNotTheMoviePartThree + 1] = "21 0";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#7ED887";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "Hello!|'What do you want?'|I'm just greeting you?|'Oh hey. I guess.'|How are you doing?|'Do you need something?'|No? I was just asking how your day went?|'Oh ok. I'll pass.'|Ok",
            "'Seeing your face makes me wish my day never started.'|Oh, sorry|'HAHAHA! I was just joking. You actually took that seriously!'|Hehehe... Right. I guess I did.",
            "How's it going?|'The weather sucks so much today.'|Oh, how so?|'It's so dang hot. And there's no wind at all.'|Oh, well I think it'll start cooling down soon?|'It better.'",
            "'Yo, why do you look so dead today. It's killing the mood.'|I'm sorry, I'll try to cheer up?|'It's whatever, I don't think people pay attention to you anyways'|Heh... Right.",
            "'Why are you so annoying?'|I'm sorry?|'Nevermind. I just got zero hours of sleep last night.'|Oh, that makes sense I guess.|'Yea, people are just pissing me off today.'",
            "'Why is it so cold today, it's so annoying.'|Yea it is pretty cold, I guess you can just wear more layers.|'What, you think I haven't tried that yet?'|Oh sorry, I was just suggesting it.",
            "How's it going?|'Why couldn't it snow here? It's so damn cold, but apparently not cold enough for snow.'|Yea, maybe it's not humid enough?|'Yea no. I don't think that's the reason.'",
            "'I'm so annoyed today.'|What happened?|'I don't want to talk about it today, I'll tell you some other day.'|Oh ok, sure!"
        }, 0);

        lang.addLanguage(new string[]{
            "สวัสดี!|'นายอยากได้อะไร?'|เปล่า ฉันแค่ทักทายหน่ะ|'อ๋อ งั้นก็… เฮ้'|เป็นไงบ้าง?|'นายต้องการอะไรรึเปล่า?'|ก็ไม่นะ แค่ถามว่าวันนี้เป็นยังไงบ้าง?|'อ๋อ โอเค แต่ไม่ขอตอบแล้วกัน'|โอเค",
            "'พอเห็นหน้านายแล้วฉันไม่อยากทำอะไรเลย'|อ่า ขอโทษนะ|'ฮ่าฮ่าฮ่า! ฉันแค่ล้อเล่น นายนี่ทำเป็นจริงจังไปได้!'|แหะ แหะ แหะ... ใช่ ฉันคงจริงจังไป",
            "เป็นยังไงบ้าง?|'วันนี้อากาศอย่างแย่'|อ่า ทำไมคิดงั้นหล่ะ?|'มันร้อนโคตรๆ แถมยังไม่มีลมอีกต่างหาก'|อ๋อ ฉันคิดว่าเดี๋ยวมันก็เย็นขึ้นแหละมั้ง?|'เป็นงั้นก็ดี'",
            "'โย่ ทำไมวันนี้นายดูตายซากจัง เห็นแล้วอารมณ์เสียชะมัด'|ฉันขอโทษ เดี๋ยวลองร่าเริงขึ้นก็ได้มั้ง?|'มันจะยังไงก็ช่าง ฉันไม่คิดว่าจะมีใครมาสนใจนายอยู่ดี'|เหะ... ก็จริง...",
            "'ทำไมนายน่ารำคาญขนาดนี้เนี่ย?'|อะไรนะ?|'ช่างมันเถอะ พอดีเมื่อคืนฉันไม่ได้หลับเลยแม้แต่ชั่วโมงเดียว'|อ่า ก็ดูสมเหตุสมผลดี|'ช่าย เห็นใครก็ทำให้ฉันหงุดหงิดไปหมด'",
            "'ทำไมวันนี้มันเย็นจังเลยเนี่ย น่ารำคาญเป็นบ้า'|ช่าย มันค่อนข้างหนาวเลยแหละ แต่ใส่เสื้อผ้าให้หนาขึ้นก็น่าจะช่วยได้นะ|'ห๊ะ นี่นายคิดว่าฉันยังไม่ได้ทำแบบนั้นเหรอ?'|อ่า ขอโทษ แค่ลองแนะนำหน่ะ",
            "เป็นยังไงบ้าง?|'ทำไมหิมะถึงไม่ตกนะ? มันโคตรจะหนาว แต่ยังไม่มากพอที่จะทำให้หิมะตกรึไงกัน'|ช่าย บางทีอากาศมันอาจจะชื้นไม่พอแหละมั้ง?|'ไม่หล่ะ ฉันไม่คิดว่านั่นคือสาเหตุนะ'",
            "'วันนี้มีแต่เรื่องให้ฉันรำคาญ'|เกิดอะไรขึ้นเหรอ?|'ฉันยังไม่อยากพูดถึงมันในวันนี้ เดี๋ยวค่อยบอกนายวันหลังก็แล้วกัน'|อ่า โอเค ได้สิ!"
        }, 1);

        tcsPos = lang.getLanguage();
    }
}
