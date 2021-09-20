using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human8 : Classmate
{
    protected override void initHumanNum() => humanNum = 8;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie-1] = "3 19 35 41";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "42";
        path[arrivalButNotTheMoviePartThree + 2] = "31 14 6 0";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#F59D78";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'Hey!'|Hi?|'How was your day?'|Oh uh, pretty good|'Come on!! Keep going!'|Well I woke up pretty early so that was nice I guess?|'Okkkk, you should talk more!'|Right",
            "'How was your day?'|I uh, It was pretty good|'How can you forget!'|What?|'Tell me more!!'|Well the sun looked nice today I guess|'Hey! That's basically what you said yesterday!'|Welp sucks to be you I guess",
            "'Hellooooo~'|Heyo|'How was your day fine sir?'|Uhhhm It was good, I did some stuff I guess|'Okkkkkk, Keep going!'|Well my knee kinda hurts, but I think I can still run|'Awwww man that sucks!'",
            "'Yoooohooooo!'|How do you keep coming up with these new greetings?|'Hmm? I just always say these things!'|I feel like this time it was new?|'Whaaat??? That's so rude!'|Wait it was a, it was a complement?|'Hmph! It doesn't sound like it!",
            "Hello|'Hmph! Why can't you try a new greeting once in a while!'|I- wait I can't tell if you're actually mad at me?|'Hehe... Of course not! I was just playing with you~'|Oh ok, I thought I actually did a bad thing",
            "Good afternoon?|'Goodbye'|Oh,... Ok? I'm sorry?|'Hehe, did I scare ya?'|Ah ok, well you did a little I guess.|'Hehe!'",
            "'Howdy!'|That's a new one.|'Come on!! I said it to you last time we spoke!'|Oh, Whoops I guess I forgot. My memory sucks these days...|'Agreed! Well hopefully you remember next time you talk to me!'",
            "Hey|'Hellooo!'|That's- How was your day?|'It was horrible! I woke up late to my first class, then my mommy yelled at me! Then I spilled boba all over my lap!'|Ah, that uh, that sucks|'Yea, it did.'"
        }, 0);

        lang.addLanguage(new string[]{
            "'เฮ้!'|ไง?|'วันนี้เป็นไงบ้าง?'|อ่าา อืมมม ดีเยี่ยมเลย|'เอาสิ!! พูดต่อเลย!'|อืม ก็ฉันตื่นเช้ามากๆ นั่นมันเยี่ยมดี ฉันว่านะ?|'โอเคคคค นายควรพูดเยอะๆ กว่านี้นะ!'|คงงั้น",
            "'วันนี้เป็นไงบ้าง?'|ฉัน อ่าา ดีเยี่ยมเลย|'นายลืมได้ไงเนี่ย!'|ห่ะ?|'บอกฉันอีกหน่อยสิ!!'|ก็ ฉันว่าดวงอาทิตย์ดูเยี่ยมดีนะวันนี้|'เฮ้! เมื่อวานนายก็พูดแบบนี้!'|ก็… ช่วยไม่ได้นะ",
            "'สวัสดีจ้าาา~'|เฮ้โย่|'วันดีๆ แบบนี้เป็นอย่างไรบ้างคะท่าน?'|อืมมมม มันก็ดี ฉันได้ทำอะไรนิดหน่อย ฉันว่านะ|'โอเคคคคค พูดต่อเลย!'|อืมม ก็ เจ็บเข่านิดหน่อย แต่คิดว่าน่าจะยังวิ่งได้|'โหหหห เพื่อนนน แย่อ่าาา!'",
            "'ยู้ววววฮูววววว!'|นี่เธอสรรหาวิธีทักทายใหม่ๆ แบบนี้ตลอดได้ยังไงกันหน่ะ?|'หืมม? ฉันก็แค่พูดอะไรแบบนี้อยู่แล้วหน่ะ!'|ฉันรู้สึกว่าครั้งนี้มันใหม่นะ?|'ห๊ะะะ??? หยาบคายย!'|เดี๋ยวนะ อ่าา มันคือคำชมหน่ะ?|'ฮึ่มมม! ไม่เห็นเหมือนคำชมเลย!",
            "สวัสดี|'ฮึ่ม! ทำไมนายไม่ลองทักทายแบบใหม่บ้างนะ!'|ฉั- เดี๋ยวนะ นี่เธอโกรธฉันจริงๆ เหรอ?|'ฮิฮิ... ไม่ใช่หรอกหน่า! ฉันแค่หยอกนายเอง~'|อ๋อ โอเค นึกว่าฉันทำอะไรผิดเสียอีก",
            "สวัสดีตอนบ่าย?|'ลาก่อนนะ'|อ่า โอเคไหมเนี่ย...? เธอว่าอะไรนะ?|'ฮิฮิ ฉันทำนายกลัวอ่ะป่าว?'|อ่า โอเค ก็นะ นิดนึงแหละนะ ฉันว่า|'ฮิฮิ!'",
            "'ว่างายย!'|คำใหม่นี่นา|'เอาหน่า!! ครั้งก่อนที่เราคุยกันฉันก็บอกไปแล้วนะ!'|อ่า... โหยย! ฉันคงลืมหน่ะ ทุกวันนี้ความทรงจำแย่หน่อย...|'เห็นด้วยเลย! ฉันหวังว่าครั้งหน้าที่คุยกันนายจะจำได้นะ!'",
            "เฮ้|'สวัสดีจ้าา!'|นั่- วันนี้เป็นไงบ้าง?|'มันแย่มากเลย! ฉันตื่นมาเรียนคาบแรกไม่ทัน จากนั้นแม่ก็ตะโกนดุฉัน! แล้วฉันก็ทำชานมไข่มุกหกเต็มตักฉันเลย!'|อ่า นั่นมัน เอ่อ แย่จัง|'ช่าย แย่เลยหล่ะ'"
        }, 1);

        lang.addLanguage(new string[]{
            "'Hey!|Salut?|Comment a été ta journée?|Oh euh, plutôt bonne|'Allez! Continues!'|Ben je me suis lever assez tôt donc c'était pas mal je pense?|'Okkkk, tu devrais parler plus!'|Bien",
            "'Comment a été ta journée?'|Je euh, c'était pas mal|'Comment tu peux oublier!'|Quoi?|'Dis-m'en plus!!'|Bah le soleil était beau aujourd'hui je suppose|'Hey!C'est exactement ce que t'as dit hier!'|Ouep c'est nul d'être toi je suppose",
            "'Bonjouuuur~'|Salut|'Comment s'est passé cette belle journée monsieur?'|Euhhhhh c'était bien, j'ai fais quelques trucs je suppose|'Okkkkk, Continues!'|Ben mes genoux me font mal, mais je pense que je peux toujours courir|'Awwww mec c'est pas cool!'",
            "'Yooooohooooo!'|Comment t'arrives à trouver une nouvelle salutation à chaque fois?|'Hein? Je dis juste tout le temps ça!'|J'ai l'impression que cette fois c'était nouveau?|'Quoiii??? C'est pas sympa!'|Attends c'était un, c'était un compliment?|'Hmph! on dirait pas!",
            "Bonjour|'Hmph! Pourquoi tu peux pas essayer quelque chose de nouveau pour une fois!'|Je- attends j'arrive pas à dire si t'es fachée contre moi?|'Hehe...Bien sûr que non! Je m'amusais just avec toi~'|Ah ok, J'ai cru que j'avais fait quelque chose de mal",
            "Salut?|Au revoir'|Oh,...ok? J'suis désolé?|'Hehe, je t'ai fais peur?'|Ah ok, ben un peu je pense.|'Hehe!'",
            "'Bien le bonjour!|C'est nouveau.|'Aller!! Je l'ai dit la dernière fois qu'on a parlé!'|Ah, oops je pense que j'ai oublié. Ma mémoire n'est pas incroyable en ce moment...|'Jsuis d'accord! Bien j'espère que tu t'en souviendras la prochaine fois que tu me parleras!'",
            "Hey|'Bonjouuur!'|C'est-Comment était ta journée?|'C'était horrible! Je me suis levé en retard pour mon premier cours, ducoup ma mère m'a crié dessus! Et j'ai recraché mon boba sur mes jambes!|Ah, ça euh, ça craint|'Ouais, effectivement"
        }, 2);


        tcsPos = lang.getLanguage();


    }
}
