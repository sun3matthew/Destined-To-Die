using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human10 : Classmate
{
    protected override void initHumanNum() => humanNum = 10;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie-1] = "2 25 45 43";//to school base
        path[arrivalButNotTheMoviePartTwo] = "43";
        path[arrivalButNotTheMoviePartThree + 2] = "1";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#79FFFB";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'Hey! Are you new here?'|Uhhhh, I'm a Junior this year. But do I get that often|'Heh heh... I'm still getting used to this area. And I guess you also looked new'|Freshmen?|'Yeah, I'm suuuuuper nervous!'|Oh well don't be, it'll be fun- well I don't know if fun is the right word. Maybe exciting?|'I mean exciting is good, right?'|Right..",
            "How's freshman year so far?|'I really enjoy it here! It's much more exciting than my old town!'|That's good, are you having fun too?|'Totally! It's so much more fun here too!'|That's good.|'How about you? Are you having fun?'|It's been good|'Oh. Is that all?'|Yep|'You should talk more!'|Right, I'll try",
            "'I love the sounds of rain, the ambience of it while it hits the roof is amazing!'|Yea, do you like the rain?|'Totally! Isn't it obvious? I love the rain!'|Me too.|'It gets annoying sometimes since everything is always wet'|I guess it does get annoying, but I think it's worth it|'Agreed!'",
            "'Yo! There's a festival tomorrow! You coming?'|I tend to sleep a lot|'Just wake up early this one time! How hard can it be!'|You'd be surprised, I usually sleep till noon|'Noon??? You need to take care of yourself more!'|I think I do, just not physically|'Are you still eating frozen foods?'|It's possible|'You're hopeless.'",
            "'Maybe you should try to get better at cooking!'|I've tried a few times, but it seem I only know how to use a microwave|'If you keep eating frozen foods, you'll get sick!'|It's already been a few years, I'll be fine|'A few years?! Is that why you're so short?'|Hey, I'm taller than you",
            "'I feel like such a grown up!'|What did you do?|'I bought my own groceries yesterday!'|Oh ok, I was expecting something more..|'OK, I guess I'll just stop telling you stuff~'|I mean I'm in no place to judge I guess, I only leave the house to go to school anyways.|'You should be my role model!'|I guess you should find another upperclassmen",
            "'Is your room messy?'|No, why?|'Ooooh nothing~'|It sure doesn't seem like nothing|'Ok Ok I'll tell you!'|mhm?|'You just don't seem like the type to have a clean room, I was curious!'|Well I guess sometimes it does get a little messy when I get busy.|'So I was right!'|I said sometimes, although I am fairly busy these days...|'See!!!'",
            "'I like you.'|...|...|..I-|'It's a joke!!'|Oh okay, I didn't know how to respond|'That was fun'|Sure... Why-|'I'll get going, see you later!'|Right, bye."
        }, 0);

        lang.addLanguage(new string[]{
            "'เฮ้! นายเพิ่งมาใหม่เหรอ?'|เอ่อออ ปีนี้ฉันอยู่ปีสามหน่ะ แต่ก็โดนทักผิดบ่อยแหละนะ|'แหะ แหะ... ผมกำลังปรับตัวเข้ากับที่นี่อยู่ฮะ แล้วผมก็เดาว่าพี่ดูเหมือนคนเพิ่งมาใหม่เหมือนกัน'|เราเป็นเด็กปีหนึ่งเหรอ?|'ใช่ฮะ ประหม่ามากๆ เลย!'|ไม่ต้องประหม่าไป ต่อจากนี้ก็จะเจอเรื่องสนุกๆ- อ่าา ถึงจะไม่รู้ว่าการใช้คำว่าสนุกมันถูกรึเปล่าก็เถอะ อาจจะเป็นคำว่าน่าตื่นเต้นหล่ะมั้ง?|'ตื่นเต้นเป็นเรื่องที่ดีใช่ไหมฮะ?'|ใช่...",
            "เด็กใหม่เป็นไงบ้าง?|'ผมชอบที่นี่นะฮะ! มีเรื่องน่าตื่นเต้นมากกว่าที่เมืองเดิมของผมซะอีกฮะ!'|นั่นก็เป็นเรื่องที่ดีนะ แล้วสนุกดีไหม?|'โดนใจเต็มๆ! อยู่ที่นี่มีเรื่องสนุกๆ เยอะกว่ามากเลยฮะ!'|ดีเลย|'พี่หล่ะเป็นไงบ้างฮะ? สนุกรึเปล่าฮะ?'|มันก็ดีนะ|'อ่า แค่นั้นเหรอฮะ?'|ชั่ยๆ|'พี่ควรจะพูดเยอะๆ กว่านี้นะฮะ!'|ก็จริงนะ พี่จะลองดู",
            "'ผมชอบเสียงของฝน บรรยากาศที่ฝนตกกระทบหลังคานี่มันมหัศจรรย์มากเลยฮะ!'|ช่าย เราชอบฝนเหรอ?|'ใช่เลยฮะ! มันยังไม่ชัดพอเหรอฮะ? ผมชอบฝนฮะ!'|พี่ก็เหมือนกัน|'บางทีมันก็น่ารำคาญนะฮะที่ทุกอย่างจะเปียกตลอดเลย'|พี่ว่ามันก็น่ารำคาญอยู่ แต่มันก็คุ้มค่าดี|'เห็นด้วยเลยฮะ!'",
            "'โย่! พรุ่งนี้มีงานเทศกาลด้วยนะฮะ! พี่มาด้วยรึเปล่าฮะ?'|พี่เป็นคนที่ชอบนอนเยอะหน่ะ|'แค่ตื่นเช้าครั้งนี้ครั้งเดียวเองฮะพี่! จะยากขนาดไหนกันฮะ!'|เราต้องตกใจแน่ ปกติพี่นอนถึงตอนเที่ยงหน่ะ|'ตอนเที่ยงเหรอฮะ??? พี่ต้องดูแลตัวเองให้มากกว่านี้นะฮะ!'|พี่ว่าพี่ทำแล้วนะ แค่ไม่ใช่ทางร่างกายหน่ะ|'พี่ยังกินอาหารแช่แข็งอยู่รึเปล่าฮะ?'|มันก็บางทีหล่ะนะ|'พี่นี่ทำตัวหมดหวังจังเลยฮะ'",
            "'บางทีพี่น่าจะลองทำกับข้าวให้เก่งขึ้นดีไหมฮะ!'|พี่เคยลองทำบ้างแล้ว แต่ดูเหมือนพี่จะรู้แค่วิธีใช้ไมโครเวฟหน่ะ|'ถ้าพี่กินแต่อาหารแช่แข็งเดี๋ยวพี่ก็ป่วยหรอกฮะ!'|มันก็เป็นแบบนี้มาหลายปีแล้ว ไม่เป็นไรหรอกหน่า|'หลายปีเหรอฮะ?! เพราะงี้รึเปล่าฮะพี่ถึงตัวเตี้ย?'|เฮ้ พี่สูงกว่าเรานะ",
            "'ผมรู้สึกได้ถึงการเติบโต!'|เราทำอะไรไปบ้างหล่ะ?|'เมื่อวานผมไปซื้อของชำด้วยตัวเองฮะ!'|อ๋อ โอเค พี่คาดหวังเยอะไปหน่อย...|'โ อ เ ค ผมว่าผมหยุดบอกเรื่องของผมให้พี่ฟังดีกว่า~'|ปล่าว พี่แค่แบบว่า พี่ไม่มีสิทธิ์ว่าใครหรอก พี่ว่านะ ยังไงพี่ก็แค่ออกจากบ้านมาโรงเรียนแค่นี้อยู่แล้ว|'พี่นี่ควรเป็นแบบอย่างของผมเลยฮะ!'|พี่ว่าเราควรไปหารุ่นพี่คนอื่นดีกว่านะ",
            "'ห้องพี่รกไหมฮะ?'|ไม่นะ ทำไมเหรอ?|'อ่าาาา ไม่มีไรฮะ~'|มันฟังดูเหมือนไม่ใช่ว่าไม่มีอะไรเลยนะ|'โอเค โอเค ผมบอกพี่ก็ได้ฮะ!'|อ่าฮะ?|'พี่ดูไม่เหมือนคนที่มีห้องสะอาดเลยฮะ ผมสงสัยแบบนั้นแหละฮะ!'|อืม บางทีมันก็รกเวลาที่พี่ยุ่งๆ หล่ะนะ|'งั้นผมก็พูดถูกสิฮะ!'|พี่บอกว่าบางครั้งไง ถึงช่วงนี้พี่จะค่อนข้างยุ่งๆ ก็เถอะ...|'เห็นไหมหล่ะ!!!'",
            "'ผมชอบพี่ฮะ'|...|...|..พี่-|'ล้อเล่นฮะะะ!!'|อ่า โอเค พี่ไม่รู้เลยว่าต้องตอบสนองยังไงดี|'สนุกจังเลยฮะ'|แน่สิ... ทำไมเ-|'ผมไปก่อนนะฮะ เจอกันคราวหน้าฮะ!'|ก็คงงั้น บาย"
        }, 1);

        lang.addLanguage(new string[]{
            "'Hey! T'est nouveau ici?'|Uhhhh, je suis en première cette année. Mais est-ce que je viens souvent|'Eheh...Je continue de m'habituer à cet endroit. Et tu semblais nouveau aussi'|T'es en troisième?|'Ouais, je suis suuuuuper nerveuse!|Oh ben le soit pas, ça va être amusant-bon je ne sais pas si amusant est le bon mot. Peut-être excitant?|'Je pense qu'excitant c'est pas mal, non?'|Ouais…",
            "Comment se passe l'année de troisième?|'J'aime vraiment ça! C'est bien plus passionnant que mon ancienne ville!'|C'est bien, tu t'amuses aussi?|'Totallement! C'est bien plus marrant ici aussi!'|C'est bien|'Et pour toi alors? Tu t'amuses?'|Ça se passe bien|'Oh. C'est tout?'| Ouep|'Tu devrais parler plus!'|D'accord, j'vais essayer.",
            "'J'aime le bruit de la pluie, l'ambiance que ça donne quand elle résonne sur le toit c'est incroyable!'|Ouais, t'aime la pluie?|'Complètement! C'est pas évident? J'adore la pluie!'|Moi aussi.|'Ça devient embêtant desfois quand c'est tout le temps humide'|Je pense que c'est embêtant mais que ça en vaut le coup|'J'suis d'accord!'",
            "'Yo! Il y a un festival demain! Tu viens?'|J'ai tendance à beaucoup dormir|'Lèves toi plus tôt juste cette fois! Ça peut pas être si dur!'|Tu serais surprise, d'habitude je dors jusqu'à midi|'Midi??? T'as besoin de prendre plus soin de toi!'|Je pense que je le fais,  juste pas physiquement|'Tu continues de manger des plats surgelés?|C'est possible|T'es un cas désespéré.'",
            "'Peut-être que tu devrais essayer de devenir meilleur en cuisine!'|J'ai essayé une ou deux fois, mais on dirait que je sais uniquement utiliser un micro-onde|'Si tu continues de manger des plats surgelés, tu vas être malade!'|Ça fait déjà quelques années, ça va aller|'Quelques années?! C'est pour ça que t'es si petit?'|Eh, j'suis plus grand que toi",
            "'Je me sens plus adulte!'|T'as fait quoi?|'J'ai fais mes propres courses hier!'|Ah ok, je m'attendais à quelque chose de plus..|'OK, je pense que je vais arrêter de te dire des trucs~'|Je veux dire je suis pas en droit de juger je suppose, je ne quitte la maison que pour aller en cours dans tous les cas.|'Tu devrais être mon model!'|Je pense que tu devrais trouver un autre élève plus âgé pour ça",
            "'Est-ce que ta chambre est mal rangée?'|Non, pourquoi?|'Oooooh, rien~'|Ça semble pas vraiment rien|'Ok ok je te le dis!'|mhm?['Tu semble juste pas être le genre de personne à avoir une chambre rangée, j'étais curieuse!'|Ben je pense que des fois c'est un peu mal rangé quand je suis occupé.|'Donc j'avais raison!'|J'ai dis des fois, mais bon j'suis assez occupé ces derniers jours...|'Tu vois!'",
            "'Je t'aime bien'|...|...|..Je-|'C'est une blague!!'|Ah d'accord, je savais pas comment répondre|'C'était marrant'|Bien sûr...Pourquoi-|'Je dois y aller, on se revoit plus tard!'|Très bien, à plus."
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
