using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human1 : Classmate
{
    protected override void initHumanNum() => humanNum = 1;
    protected override void initPersonality() => personalityType = 1;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "0 9 19 17 22";//to school base
        path[arrivalButNotTheMoviePartTwo] = "23";
        path[arrivalButNotTheMoviePartThree + 1] = "20 2";
    }
    protected override void initHome() => house = new Vector2(74.50f, 4.36f);
    protected override void initConvos()
    {
        humanName = "#9E9C66";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "What's up?|'You're so chatty!'|Lmao, I guess I'm just in a good mood today?|'Awesome! What did you do?'|Uhhh, I don't know, I guess I had lots of sleep?|'Ha! I can't sleep early, I have too much energy! I just dance through the night!'|Dance?|'Oh, it was an exaggeration! I don't actually dance that much~'|Oh I see.",
            "Did you sleep well?|'Well I took a few melatonin pills I knocked out early.'|Oh, how many did you take?|'Hmm? One?'|Oh I see|'Hmmm? Why'd you ask?'|Oh I just remembered that if you take too much you get nightmares.|'Haha, that's a weird thing to know!'|Yea...my friend told me about it once",
            "'I'm so stressed right now!'|Uh Oh, what happened?|'I failed my chem quiz!!'|Like fail fail? Or like, did you just get a B?|'I got a 69!!'|Heh, 69.|'Hey! I'm having a crisis right now!!'|Well maybe you can just retake it?|'I know, But I'm still super stressed!'|Welp, hopefully you feel better soon?",
            "'Would you rather swim as fast as a fish or fly as fast as a bird?'|Why would anyone choose to swim?|'Hmmm. Oh! You can also breathe underwater?'|Like both freshwater and saltwater?|'Um... Yes?'|I feel like flying is just much more practical, like for traveling, or getting places without a ladder.",
            "'I think I might move...'|Oh no! Why?|'I don't really know, but I'm super sad about it...'|That really sucks, well come to visit us after you move!|'Probably, I think I'm going to live pretty far away, but I'll try by best!'",
            "I probably should have eaten earlier, or maybe I ate too much.|'What?! You're already so skinny! You need to eat more!'|Well I'm cramping right now, and I feel so full|'What? Hmmmm... Then you should eat early!'|That...That's the goal?",
            "'Hey! Remember when I said that I was moving? Well my parents changed their minds!'|Ah, I've been scammed|'WHAT?! Were you excited that I would go???'|I was kidding! Of course I'm glad that you're staying!|'Hehe, I'm so happy!'",
            "'I'm so tired today...'|Oh, did you get enough sleep?|'Well I took some more sleeping pills but I still couldn't sleep!'|Oh, well hopefully you can sleep better soon..|'Yep!'"
        }, 0);

        lang.addLanguage(new string[]{
            "เป็นไงบ้างพวก?|'นายนี่คุยเก่งจัง!'| 555 อยากจะขำจริงๆ วันนี้ฉันแค่อารมณ์ดีแหละมั้ง?|'เจ๋งแจ๋ว! ไปทำอะไรมาหล่ะ?'|อืมมม ไม่รู้สิ สงสัยนอนเยอะแหละมั้ง?|'โห! ฉันนอนเร็วไม่ได้เลยเพราะฉันมีพลังเยอะไปหน่อย! เมื่อคืนก็เต้นมาทั้งคืน!'|เต้นเหรอ?|'อ๋อ มันเป็นคำเปรียบเปรยหน่ะ! จริงๆ ก็ไม่ได้เต้นเยอะขนาดนั้น~'|อ๋อ เข้าใจละ",
            "หลับสบายดีรึเปล่า?|'ก็นะ ฉันกินยานอนหลับเมลาโทนินเข้าไปนิดหน่อย ขอบอกเลยว่าหลับเป็นตาย'|อ๋อ... แล้วกินไปเท่าไหร่หล่ะ?|'อืมมม? หนึ่งมั้งนะ?'|อ๋อ เข้าใจละ|'หืมมม? ถามทำไมหล่ะ?'|อ๋อ แค่จำได้ว่าถ้ากินเยอะไปจะฝันร้ายได้หน่ะสิ|'555 นายนี่รู้อะไรแปลกๆ นะ!'|ช่าย… เพื่อนฉันเคยบอกมาหน่ะ",
            "'ฉันเครียดมากจริงๆ !'|โอ๊ะโอ เกิดอะไรขึ้น?|'ฉันสอบตกวิชาเคมี!!'|ตกแบบตกจริงๆ หน่ะเหรอ? หรือตกแบบว่าได้เกรด B อะไรแบบนี้?|'ฉันได้ 69 คะแนน!!'|โห... 69|'เฮ้! นี่มันวิกฤตจริงๆ นะ!!'|อืมม นายก็ไปขอสอบแก้ได้นี่?|'มันก็ใช่ แต่ฉันก็ยังเครียดจัดๆ อยู่ดี!'|ก็นะ หวังว่านายจะรู้สึกดีขึ้นในเร็วๆ นี้นะ",
            "'นายอยากว่ายน้ำเร็วๆ แบบปลาหรืออยากบินเร็วๆ แบบนก?'|ใครเขาจะเลือกว่ายน้ำกันหล่ะ|'อืมมม... อ๋อ! ถ้าเลือกว่ายน้ำนายก็หายใจใต้น้ำได้ไง'|หมายถึงหายใจใต้น้ำได้ทั้งน้ำจืดน้ำเค็มเหรอ?|'อืมมม... ก็ใช่แหละมั้ง?'|ฉันรู้สึกว่าการบินได้นี่มันใช้งานได้จริงๆ กว่านะ อย่างใช้เดินทาง หรือขึ้นไปในที่สูงๆ ที่มันไม่มีบันไดให้ใช้.",
            "'ฉันว่าฉันต้องย้ายบ้านซะแล้วหล่ะ...'|ไม่นะ! ทำไมหล่ะ?|'ฉันก็ไม่ค่อยรู้เท่าไหร่ แต่ฉันรู้สึกเศร้าสุดๆ เลย...'|แย่จริงๆ เลย... ยังไงหลังย้ายบ้านแล้วก็กลับมาเยี่ยมพวกเราบ้างหล่ะ!|'อาจจะยากหน่อย ฉันคิดว่าฉันน่าจะไปอยู่ในที่ที่ไกลมากๆ แต่ฉันจะพยายามกลับมานะ!'",
            "ฉันน่าจะกินข้าวเช้านะเนี่ย หรือนี่ฉันกินเยอะเกินไป|'ห่ะ?! นายผอมมากๆ แล้วนะ! นายต้องกินให้เยอะกว่านี้!'|ก็นะ ตอนนี้ฉันเป็นตะคริวแล้วก็รู้สึกอิ่มสุดๆ เลย|'ห่ะ? อืมมมม... งั้นนายก็ควรกินข้าวเช้านะ!'|หนะ… นายเอาจริงดิ? จริงจังป่ะเนี่ย?",
            "'เฮ้! จำได้ไหมตอนที่ฉันบอกว่าฉันต้องย้ายบ้านหน่ะ? พ่อแม่ฉันเปลี่ยนใจแล้วหล่ะ!'|อ่าา... นี่ฉันถูกหลอกเหรอเนี่ย|'ห๊ะะ?! นี่นายตื่นเต้นที่ฉันจะไปเหรอ???'|ล้อเล่น! ฉันต้องดีใจอยู่แล้วที่นายยังอยู่นี่!|'ฮิฮิ ฉันมีความสุขจังเลย!'",
            "'วันนี้ฉันเหนื่อยจริงๆ ...'|เอ่อ... นายนอนพอรึเปล่า?|'ก็นะ ฉันกินยานอนหลับเข้าไปเพิ่มแต่ก็ยังนอนไม่หลับเลย!'|อ๋อ... หวังว่าจะนอนหลับได้ดีขึ้นเร็วๆ นี้นะ..|'ขอบใจนะ!'"
        }, 1);

        lang.addLanguage(new string[]{
            "Quoi de neuf ?|'Tu es si bavard !'|Mdr, j’imagine que je suis juste de bonne humeur aujourd’hui?| 'Super ! Tu as fait quoi de beau ?'|Euuh je sais pas trop, j’imagine que j’ai juste beaucoup dormi?|'Ahh moi je peux pas me coucher aussi tôt, j’ai trop d’énergie! J’ai dansé toute la nuit !'|Dansé ? |'Oh, j'exagère juste ! En réalité je danse pas tant que ça~'|Oh je vois.",
            "Tu as bien dormi ? |'Et bien j’ai pris quelques comprimés de mélatonine et je me suis vite endormi. '|  Oh tu en as pris combien ?|'Hmm ? Un seul ? '| Oh je vois. 'Hmmm pourquoi tu poses la question ?'|  Oh je me rappelle juste que si tu en prends trop après tu fais des cauchemars.|' Haha, je savais pas du tout c’est étrange comme fait.'|Oui un ami m’avait raconté ça une fois.",
            "'Je suis tellement stressé en ce moment!' |Oh qu’est-ce qui s’est passé ? |'J’ai raté mes qcm en chimie !' |Genre vraiment raté raté? Ou tu penses quand même avoir la moyenne ? | 'J’ai obtenu 69 !'| Hehe, 69. |'Eh je suis en train d’avoir un crise de panique là !!'| Et bien peut-être que tu pourrais repasser ton test ? | 'Je sais bien, mais ça n’empêche pas que je suis super stressé !' |Bah écoute, j’espère que tout va s’arranger ?",
            "'Tu préférerai nager aussi vite qu’un poisson ou voler aussi vite qu’un oiseau ?' |Comment quelqu’un pourrait choisir de nager ? | 'Hmmm. Oh! Tu peux aussi respirer sous l’eau ?'| Dans l’eau douce comme l’eau salée? | 'Um…Oui? ' |Je pense juste que le fait de pouvoir voler est bien plus pratique, pour voyager par exemple, ou pour se déplacer vers des endroits sans avoir à emprunter une échelle.",
            "'Je pense que je vais déménager…'| Oh non ! Pourquoi ? |'Je ne sais pas vraiment, mais ça me rend super triste…' |C’est vraiment chiant, en tout cas viens nous rendre visite après ton déménagement ! |'Sûrement, je pense que je vais partir vivre assez loin, mais je ferai de mon mieux !'",
            "J’aurais dû manger plus tôt, ou alors j’ai juste trop mangé. |'Quoi?! Tu es déjà tellement maigre! Tu devrais manger plus justement !' |Et bien j’ai des crampes maintenant, et je me sens trop rempli. |' Quoi ? Hmmmm…Tu devrais probablement manger plus tôt alors!' |Alors…Alors c’est ça le but ?",
            "'Salut! Tu te souviens quand je t’avais dit que je déménageais ? Et bien mes parents ont changé d’avis !'| Ah, je me suis fait avoir alors  'QUOI?! Tu étais content à l’idée que je parte ???' |Je plaisantais ! Bien sûr que je suis ravi que tu restes ! | 'Hehe, Je suis tellement heureux !'",
            "'Je me sens tellement fatigué aujourd’hui…' |Oh, tu as assez dormi ? | 'Et bien j’ai pris un peu plus de somnifères mais je n’ai quand même pas réussi à m’endormir !' |Oh, bah écoute j’espère que tu pourras mieux dormir la prochaine fois.. | 'Yep!'"
        }, 2);
        

        

        

        
        tcsPos = lang.getLanguage();
    }
}
/*
        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
        }, 0);

        tcsPos = lang.getLanguage();
            */
