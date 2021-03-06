using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human11 : Classmate
{
    protected override void initHumanNum() => humanNum = 11;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "6 15 34";//to school base
        path[arrivalButNotTheMoviePartTwo] = "24";
        path[arrivalButNotTheMoviePartThree - 1] = "25 10 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#A0C1EE";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'Heya! Thanks for helping me out over the summer!'|Oh, it was no big deal|'I still have trouble keeping the edges clean, but I think I'm getting better!'|That's good, at least you're doing something|'Yessss! I'm going to keep being more productive!!'",
            "When did you sleep?|'*Sniff* I got sick again'|I assume you already took your medicine?|'It tasted gross, why did my mom force me take chinese medicine...'|It's probably good for you to some extent|'Wahhhhhhhh not you too- *Ahchoo*'|Although I do think western medicine probably works better.",
            "Are you feeling better?|'no.'|...|Did it get worse?|'yes- Actually maybe it stayed the same.'|I think that's still a good sign|'That's hard for me to believe, it hurts so much'|I guess it's more like you probably reached the worst that it can get?|'Really? But I feel sooo horrible.'|Hang in there.",
            "How are you feeling today?|'I think I feel better.'|That's good|'Ugh... the awful taste of medicine is still in my mouth.'|Do you have water?|'I already tried that, but I can't wash the taste out!'|Well it'll come out eventually|'It's just soo bitter'",
            "'*Ahchoo*'|You good?|'Wahhhhhh I think it got worse again, I'm sore all over'|Did anything change?|'Wait. Have you not noticed? It's so much colder!!!'|It has? I guess the mornings are more cold these days.",
            "'It's s-so c-cold... w-why d-did it get so c-c-cold.'|I think you should stay home for the day.|'I told my mom that I felt so s-sick, but she won't let me!'|Well take it easy today I guess, do you want my jacket?|'Hmmmm, I'll be fine once I get into a room and also won't you be cold?|'Well if you need it, you can ask.",
            "'Heyaa!!'|Oh, I see you have gotten better?|'It's so weird! It was just like I was never sick!'|I guess medicine does help-|'Please please please don't bring it up again. I can still taste it whenever I think about it!|Oh lmao, whoops.|'I'm so excited to resume life normally!'",
            "'OK, if you could have anything you want, what would you want?'|Huh? Why?|'Just answer it!'|Uhhh, I don't know|'Aww that's so boring!'|Yea, well I have to get going, see you."
        }, 0);

        lang.addLanguage(new string[]{
            "'เฮ้ยา! ขอบคุณที่ช่วยงานฉันช่วงปิดเทอมภาคฤดูร้อนนะ!'|อ๋อ ไม่ใช่เรื่องใหญ่อะไรหรอก|'ฉันยังมีปัญหากับงานเนี๊ยบๆ อยู่เลยอ่า แต่ฉันว่าฉันทำได้ดีขึ้นแล้วนะ!'|ดีแล้วหล่ะ อย่างน้อยเธอก็ได้ลงมือทำ|'ใใใใช่! ฉันจะตั้งใจทำงานให้ดีมากขึ้นเรื่อยๆ เลยหล่ะ!!'",
            "เธอนอนกี่โมงเนี่ย?|'*สูดน้ำมูก* ฉันไม่สบายอีกแล้ว'|ฉันขอเดาว่าเธอกินยาแล้วไปแล้วใช่ไหม?|'มันรสชาติแย่มากเลยอ่า ทำไมแม่ต้องบังคับให้ฉันกินยาจีนด้วยก็ไม่รู้...'|มันต้องมีอะไรที่ดีต่อเธอสักอย่างแหละนะ|'อ๊ากกกกกกกก นายก็ด้วยเหรอ- *ฮัดชิ้วว*'|แต่ฉันคิดว่ายาแผนปัจจุบันน่าจะได้ผลดีกว่านะ",
            "เธอรู้สึกดีขึ้นรึยัง?|'ไม่เลย'|...|มันแย่ขึ้นเหรอ?|'ใช่- จริงๆ บางทีมันอาจจะแค่อาการคงที่นะ'|ฉันคิดว่านั่นก็ยังคงเป็นสัญญาณที่ดีนะ|'ทำใจเชื่อได้ยากมาก มันเจ็บสุดๆ '|ฉันเดาว่ามันคงเจ็บสุดๆ ได้เท่านี้แหละมั้งนะ|'จริงเหรอ? แต่ฉันรู้สึกแย่มากกกเลย'|อดทนไว้นะ",
            "วันนี้รู้สึกยังไงบ้าง?|'ฉันว่าฉันรู้สึกดีขึ้นหน่อยนะ'|ดีเลย|'เห้อ... รสชาติยาสุดสะพรึงยังติดปากฉันอยู่เลย'|เธอดื่มน้ำรึยัง?|'ลองดื่มไปแล้ว แต่มันล้างรสชาติออกไปไม่ได้อะ!'|อืมม เดี๋ยวมันก็คงออกเองแหละนะ|'มันขมมากจริงๆ นะ'",
            "'*ฮัดชิ้วว*'|ไหวไหมเนี่ย?|'อ้ากกกกกก ฉันคิดว่าอาการของฉันแย่ลงอีกแล้ว มันปวดเมื่อยร่างกายไปหมดเลย'|เพราะมีอะไรแปลกไปรึเปล่า?|'เดี๋ยวนะ นี่นายดูไม่ออกจริงๆเหรอ? อากาศมันเย็นขึ้นมากนะ!!!'|เย็นขึ้นจริงเหรอ? ฉันว่าอากาศตอนเช้าของทุกวันนี้มันเย็นกว่าซะอีก",
            "'มะ- มัน หนะ- หนาว มะ- มาก... ทะ- ทำไม มะ- มัน หนะ- หนาว มะ- มาก ขนาด นะ- นี้'|ฉันว่าเธอพักอยู่บ้านสักวันก็ดีนะ|'ฉันบอกแม่ไปแล้ว ว่าฉันมะ- ไม่ค่อยสบาย แต่แม่ไม่ให้พักอยู่บ้าน!'|ยังไงก็อย่าหักโหมมากแล้วกันนะ เธออยากได้แจ็คเก็ตฉันไหม?|'อืมมมม เดี๋ยวเข้าห้องไปก็ดีขึ้นเอง แล้วนายจะได้ไม่ต้องมาหนาวด้วย'|ยังไงถ้าเธอต้องการมันก็บอกฉันได้นะ",
            "'เฮ้ยาา!!'|อ่าว อาการดีขึ้นแล้วเหรอ?|'มันแปลกมากเลย! มันเหมือนว่าฉันไม่เคยป่วยเลยหล่ะ!'|ฉันว่ายามันช่วยได้น-|'อย่า อย่า อย่าพูดถึงมันอีกเชียวนะ ขอร้องเลย ฉันยังจำรสชาติมันได้ทุกครั้งที่นึกถึงเลยอะ!|อ่า... 55555555555555+++ โทษๆ |'ฉันตื่นเต้นมากที่จะได้ใช้ชีวิตปกติๆ สักที!'",
            "'โ อ เ ค ห ล่ ะ ถ้านายมีสิ่งที่อยากได้อยู่ สิ่งนั้นมันคืออะไรอะ?'|หือ? ทำไมเหรอ?|'แค่ตอบมาเถอะหน่า!'|เอ่ออ ไม่รู้สิ|'โหห น่าเบื่อจัง!'|ช่าย อ่า.. เดี๋ยวต้องไปก่อนละ ไว้เจอกันนะ"
        }, 1);

        lang.addLanguage(new string[]{
            "'Hey salut! Merci de m'avoir aidée pendant l'été!'|Oh, c'était pas grand chose|'J'ai toujours du mal à être constante, mais je pense que je m'améliore!'|C'est bien, au moins tu fais quelque chose|'Ouiiii! Je vais continuer d'être plus productive!!'",
            "Quand est-ce que t'as dormi?|'*Sniff* Je suis encore malade'|Je suppose que t'as déjà pris tes médicaments?|'C'était mauvais, pourquoi est-ce que ma mère m'a forcé à utiliser la médecine chinoise...'|C'est probablement bon pour toi d'une certaine manière|'Wahhhhhhh pas toi aussi-*Achou*'|Je pense quand même que la médecine occidentale fonctionne mieux.",
            "Tu te sens mieux?|'non.'|...|Ça a empiré?|'Oui-ou peut être que c'est pareil plutôt.'|Je pense que c'est quand même bon signe|'C'est difficile à croire, ça fait trop mal'|Je suppose que t'as atteint le pire que ça pouvais être?|'Vraiment? Mais je me sens vraaaiment pas bien.'|Accroches-toi.",
            "Comment tu te sens aujourd'hui?|'Je pense que ça va mieux.'|C'est cool|'Ugh...J'ai toujours le goût horrible des médicaments dans la bouche.'|T'as de l'eau?|'J'ai déjà essayé ça, mais je peux pas faire disparaître le goût!'|Ben il va certainement disparaître tout seul.|'C'est juste super amer.'",
            "'*Achou*'|Tu vas bien?|'Wahhhhh je pense que c'est de nouveau pire, j'ai mal partout'|Quelque chose a changé?|'Attends. T'as pas remarqué? Il fait beaucoup plus froid!!!'|À ce point? Je suppose que les matins sont frais ces derniers jours.",
            "'Il f-fait t-trop froid... p-pourquoi i-il f-fait si froid.'|Je pense que tu devrais rester chez toi pour la journée.|'J'ai dit à ma mère que je me sentais mal, mais elle veut pas que je reste!'|On va y aller doucement aujourdd'hui je pense, tu veux ma veste?|'Hmmmm, j'irais mieux une fois qu'on seras dans un bâtiment et aussi je veux pas que tu ai froid?'|Ok, si t'as besoin, demandes.",
            "'Saluut!!'|Oh, je vois que tu vas mieux?|'C'est trop bizarre! C'est comme si j'avais jamais été malade!'|Je suppose que les médicament ont aidés-|'S'il te plaît, s'il te plaît, s'il te plaît, parle pas de ça. J'ai encore le goût à chaque fois que j'y pense!'|Ah ahah, oups.|'J'suis trop impatiente de retrouver une vie normale!'",
            "'Ok, si tu pouvais avoir tout ce que tu voulais, tu voudrais quoi?'|Hein? Pourquoi?|'Réponds juste!'|Euhh, je sais pas|'Aww c'est ennuyeux!'|Ouais, bon faut que j'y aille, à plus."
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
