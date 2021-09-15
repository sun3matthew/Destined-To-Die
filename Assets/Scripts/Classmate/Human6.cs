using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human6 : Classmate
{
    protected override void initHumanNum() => humanNum = 6;
    protected override void initPersonality() => personalityType = 1;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "1 21 44";//to school base
        path[arrivalButNotTheMoviePartTwo] = "41";
        path[arrivalButNotTheMoviePartThree + 2] = "19 1";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#F6AFD3";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'I love to yak!'|I can tell, I feel like you're the only person I know who uses the word yak|'No way! Back from my town, we say it all the time! Do you people really not use it?'|Nope, maybe it's too, uhhh, I don't know. Weird?|'Haha! Well I'll just keep saying it!'|It makes you unique I guess?",
            "'DID YOU CLONE YOURSELF??'|What?|'I saw you so many times today!'|Well uh, I did not clone myself|'I doooon't believe you~!'|I mean like, I don't think it was me but maybe I just moved fast?|'NO! You had different shirts!'|...So how did you know it was me?|'The way you walk! You have a terrible slouch!'|Ah. Are you high?",
            "'Oh my gosh, you again!'|This is the first time we saw each other- Are you on about the cloning thing again?|'I promise! They look just like you!!!'|I really can't tell if you're joking...|'I promiseeeeeee! Why would I lie to you!'|I'll just conclude that you're blind.",
            "'Hello again!'|What's your vision?|'Huh? 20 20?'|I don't understand...|'I don't know what you're referring to. Anyways, isn't the sun super nice today!'|Ehhhh, I don't really like the sun, it's just too bright and too hot.|'Awwwww man! But the sun rays! They're so nice!'",
            "'I'm so sleepy today...'|When did you sleep?|'Oh My Gosh, like 1 am or something!'|Ah, what were you doing until then?|'Well I just could not fall asleep! My mind was constantly running!'|What were you thinking about?|'Ha! I don't think I'll tell you~'",
            "'Gah! Oh it's just you. Do you go shopping much?'|Uhhh, not often. Why?|'Oh I was just wondering! When was the last time you went shopping?'|Like not recent? Maybe like a year- Wait like for clothing right?|'What else would you buy?'|Uhhh, wood?",
            "'I wish the sun was up for longer!'|Well maybe you should wake up earlier, than you can see the sun from sunrise to sunset!|'Noooooo! I don't like the sun that much... I can't wake up early!'",
            "'I think I might be moving soon'|Wait what? really? When?|'Hey, calm down! It's not anything you have to stress about! It's not that soon and we can still talk online!'|Yea I guess..."
        }, 0);

        lang.addLanguage(new string[]{
            "'ฉันอยากจะแหวะ!'|บอกได้เลยว่า ฉันรู้สึกว่าเธอเป็นคนเดียวที่ฉันรู้จักที่ใช้คำว่าแหวะ|'ไม่มีทางอะ! ที่บ้านฉันเราก็พูดกันแบบนี้ตลอด! คนที่นี่เขาไม่พูดกันจริงๆ เหรอ?'|ไม่เลย บางทีมันอาจจะดู… อ่าาา ไม่รู้สิ แปลกมั้ง?|'55! เอาเถอะ ยังไงฉันก็จะพูดมันอยู่ดี!'|มันก็ทำให้เธอดูมีเอกลักษณ์ดีนะฉันว่า?",
            "'นี่นายโคลนร่างตัวเองรึเปล่าหน่ะ??'|ห่ะ?|'วันนี้ฉันเห็นนายหลายครั้งมากๆ !'|อ่า ฉันไม่ได้โคลนร่างตัวเอง|'ฉันไม่เชื่ออออนายหรอกกก~!'|ฉันหมายถึง แบบว่า ฉันไม่คิดว่าที่เธอเห็นคือฉันนะ แต่บางทีมันอาจจะคือฉันที่แค่ตัวอยู่ไม่ติดที่ แค่นั้นมั้ง?|'ไม่ใช่หรอก! นายใส่เสื้อไม่เหมือนกันด้วยนะ!'|...งั้นเธอรู้ได้ยังไงว่าเป็นฉัน?|'ก็ท่าเดินนายไง! นายเดินตัวงอแปลกๆ !'|อ่า นี่เธอหลอนรึเปล่าเนี่ย?",
            "'โอ้คุณพระคุณเจ้า นายอีกแล้ว!'|นี่คือครั้งแรกที่เราเจอกันนะ- นี่เธอจะพูดถึงเรื่องโคลนร่างอะไรนั้นอีกเหรอ?|'ฉันสาบาน! พวกเขาดูเหมือนนายเลย!!!'|ฉันพูดไม่ถูกเลยว่านี่เธอล้อเล่นอยู่รึเปล่า...|'ฉันสาบานนนนนนน! ทำไมฉันต้องโกหกนายด้วยอะ!'|เอาเป็นว่าเธอตาฝาดแล้วกัน",
            "'สวัสดีอีกครั้งจ้าา!'|วิสัยทัศน์ของเธอคืออะไร?|'หืม? 20 20มั้ง?'|ฉันไม่เข้าใจ...|'ฉันไม่รู้ว่านายพูดถึงอะไร ยังไงก็เถอะ ไม่ใช่วันนี้ดวงอาทิตย์มันสุดยอดไปเลยเหรอ!'|อ่าา ฉันไม่ค่อยชอบดวงอาทิตย์นะ มันสว่างเกินไปแล้วก็ร้อนเกินไปด้วย|'โห พวกกกก! แต่พวกแสงอาทิตย์อะ! มันดีนะ!'",
            "'วันนี้ฉันง่วงจริงๆ ...'|เธอนอนกี่โมงหน่ะ?|'โอ้คุณพระคุณเจ้า ประมาณตี 1 นี่แหละมั้ง!'|อ่า ทำอะไรดึกถึงขนาดนั้นหน่ะ?|'ก็ ฉันแค่นอนไม่หลับอะ! สมองมันวิ่งไม่หยุดเลย!'|เธอคิดถึงเรื่องอะไรเหรอ?|'หึ! ฉันไม่คิดว่าฉันจะบอกนายหรอกนะ~'",
            "'กรี๊ดด! อ่าาา นายนี่เองงง นายไปซื้อของบ่อยป่าวอะ?'|อ่าาา ไม่ค่อยบ่อยนะ ทำไมเหรอ?|'อ๋อ ฉันแค่สงสัยหน่ะ! นายออกไปซื้อของครั้งสุดท้ายตอนไหนอะ?'|ก็ไม่ใช่เร็วๆ นี้หรอก น่าจะปีที่แล้วมั้ง- เดี๋ยวนะ หมายถึงซื้อพวกเสื้อผ้าใช่ไหม? |'นอกเหนือจากนั้นแล้วนายซื้ออะไรอะ?'|อ่าาา แผ่นไม้มั้ง?",
            "'ฉันอยากให้ดวงอาทิตย์ขึ้นนานๆ กว่านี้!'|งั้นเธอก็อาจจะ...ตื่นเช้ามากขึ้นกว่านี้ แล้วเธอจะได้ดูดวงอาทิตย์ขึ้นจนถึงตกดินเลย!|'ม่ายยยยยย! ฉันไม่ได้ชอบดวงอาทิตย์ขนาดนั้น... ฉันตื่นเช้าไม่ได้หรอก!'",
            "'ฉันว่าฉันอาจจะกำลังย้ายบ้านเร็วๆ นี้'|ห่ะ เดี๋ยวนะ อะไรนะ? จริงเหรอ? เมื่อไหร่หน่ะ?|'เฮ้ ใจเย็นสิ! มันไม่ใช่เรื่องที่นายต้องมาเครียดหรอกนะ! มันไม่ได้เร็วขนาดนั้น แล้วเราก็ยังคุยกันแบบออนไลน์ได้!'|อ่า… มันก็ใช่มั้ง..."
        }, 1);

        lang.addLanguage(new string[]{
            "'J'adore jaboter!'|Je peux dire, je crois que t'es la seule personne que je connais qui utilise le mot jaboter'|'Pas possible! Quand j'étais dans ma ville on disait ça tout le temps! Vous utilisez vraiment jamais ce mot?'|Non, parce que c'est p't'être trop, euh, je sais pas. Bizarre?|'Haha! Ben je vais continuer à le dire!'|Ça te rend unique je pense?",
            "'TU T'ES CLONÉ??'|Quoi?|'Je t'ai vu tellement de fois aujourd'hui!'|Bah, euh, je ne me suis pas cloné|'J'te crois pas~!|Je veux dire genre, je pense pas que c'était moi mais peut être que j'ai bougé vite?|'NON! t'avais un t-shirt différent!'|...Ducoup...Comment t'as su que c'était moi?|'Ta façon de marcher! T'es tout penché!'|Ah. T'es défoncé?",
            "'Oh mon dieux, encore toi!'|C'est la première fois qu'on se vois- T'es toujours sur le truc de clonage?|'J'te promet il te ressemble parfaitement!!!'|J'arrive vraiment pas à dire si tu rigoles ou pas...|'J'te promeeeeeeet! Pourquoi je te mentirais?'|Je vais juste en conclure que t'es aveugle.",
            "'Re-Bonjour!'|T'as une bonne vision?|'Euh? 20/20?|Je comprends pas...|'Je sais pas ce que tu cherche à savoir. Dans tous les cas, est-ce que le soleil est pas super aujourd'hui!'|Euuuuuh, j'aime pas trop le soleil, c'est juste trop brillant et chaud.|'Ahhhhhh, mec! Mais les rayons de soleil! Ils sont trop beaux!'",
            "Je suis trop fatiguée aujourd'hui...'|Quand est'ce que tu t'es couchée?|'Oh mon dieux, genre 1h du mat ou quelque chose comme ça!'|Ah, tu faisais quoi jusqu'à cette heure?|'Bah j'arrivais juste pas à dormir! Mon esprit est toujours en train de travailler!'|Et tu pensais à quoi?|'Ha! Je pense que je vais pas te l'dire~'",
            "'Gah! Oh c'est juste toi. Tu vas beaucoup faire du shopping?'|Euhhh, pas souvent. Pourquoi?|'Ah je me me demandais juste! C'est quand la dernière fois que t'es allé faire du shopping?'|Pas récemment? Peut-être genre il y a un an-Attends comme pour des vêtement on est d'accord?|'Qu'est ce que tu voudrais acheter d'autre?'|Euhhh, du bois?",
            "'J'aimerais que le soleil reste levé plus longtemps!'|Bah, peut être que tu devrais te lever plus tôt, que tu puisses voir le soleil du levé au couché!|'Noooon! J'aime pas le soleil à ce point...Je peux pas me lever tôt!'",
            "'Je pense que je vais bientôt déménager'|Attends quoi? Vraiment? Quand?|'Eh, calmes toi! C'est pas quelque chose qui devrait te faire stresser! C'est pas pour tout de suite et on peut toujours se parler en ligne!'|Ouais je suppose..."
        }, 2);

        tcsPos = lang.getLanguage();
    }
}


