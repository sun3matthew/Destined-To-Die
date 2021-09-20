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

        lang.addLanguage(new string[]{
            "'*Baille* Je me suis levé beaucoup trop tôt'|Combien d'heures de sommeil t'as eu? |'Huit'|C'est plutôt normal, combien de temps tu dors d'habitude?|'Neuf heures et demi'|Honnêtement c'est plutôt impressionant|'J'ai maîtrisé l'art du sommeil!'",
            "'Je pense que j'ai dû attrapé froid'|Qu'est-ce qui c'est passé ?|'Je me sens juste pas dans mon assiette'|T'aurais pas juste pas dormis assez ?|'Je peux jamais dormir assez, donc ça doit être en partie le problème'|Ben j'espère que tu te sentiras mieux assez vite.",
            "'Pourquoi c'est toujours aussi lumineux le matin, ça me fait mal aux yeux.'|T'aime bien dormir?|'Bien évidemment! C'est teeeellement bien!'|Attends, tu dors combien de temps les weekends?|'... Euh... Je sais pas, peut être 3h?'|Excuses-moi , quoi?",
            "Pourquoi aimes- tu autant manger?|'Je suis à la chasse à la meilleure nourriture! Tu dois la trouver d'une manière ou d'une autre!'|Je vois, eh bien c'est quoi le meilleur pour l'instant?|'J'ai oublié'|Est-ce que ça ne va pas à l'encontre de toute cette quête?|'Quoi??? Je le saurais quand j'y goûterais!'|Eh bien dis le moi quand tu l'auras trouvé.",
            "Tu sors manger souvent?|'Ben...Peut-être une fois ou deux par jour?'|Attends, comment t'as le temps deux fois par jour? Et ça coûte pas cher?|'Devines quoi? Une fois je l'ai même fait 5 fois en une journée!'|Je suis à la fois impressionné et inquiet.|'Je pense que ça coûte cher aussi, mais ça en vaut le coût!",
            "'Oh, super! Je te cherchais partout!'|Vraiment? Pourquoi?|'*Baille* Mais d'abord, pourquoi tu es obligé de te lever si tôt le matin à chaque fois?'|Parce que l'éducation c'est important?|'Hmmm...Pourquoi ça peut pas tout être décalé de quelques heures![Ben tout le monde ne dort pas autant que toi",
            "'Oh, hiya'|C'est nouveau|'Tu crois? C'est quelque chose que j'ai entendu dans une pub à la tv'|C'était une pub de nourriture?|'Eh, qu'est-ce que tu insinues là?'|C'était une pub de nourriture?|'J'allais t'offrir un bout à manger, mais plus maintenant!'|Ah ok, je suppose que c'est pas cool d'être moi.|'Oh, j'espérais que t'allais me supplier!|Mdr, je passe mon tour.",
            "Hey! Quelque semble bizarre aujourd'hui'|Ah vraiment?|'*Baille* Je pense juste que j'ai pas assez mangé ou dormi'|Ah, ça explique tout je pense|'Dans tous les cas faut que j'y aille! Au revoir!'"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
