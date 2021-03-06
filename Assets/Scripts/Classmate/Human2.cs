using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human2 : Classmate
{
    protected override void initHumanNum() => humanNum = 2;
    protected override void initPersonality() => personalityType = 1;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie+1] = "1 13 37";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "38";
        path[arrivalButNotTheMoviePartThree+2] = "19 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#95E9BF";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'The sun's really bright today, don't you think?'|Uhm, it looks fairly...Normal?|'You know you should look up more, you'll get back pains if you keep looking down'|Well I already have back pains|'Do you want a massage?'|What? No",
            "'Hey! How's it going?'|How do I actually respond to that?|'You know, \"Good\", \"Bad\", things like that?'|Good|'And... Keep going'|Not really in the mood|'Whaaa... thats too bad'|Sucks to be you I guess",
            "'I had a super weird dream last night, but it's a little embarrassing'|What is it?|'Nooooooo, it's too embarrassing!'|Okay, then don't say it|'Noooo you're supposed to keep asking!'|Uhh, W-Whats the dream?|'Nevermind, now I feel like I just forced you'|Uhh, how do I respond now|'...Just, Nevermind'",
            "'What up!'|What... up?|'It's going to rain soon!'|Oh, really?|'Yeah, well rainy days are special!'|So you like it when it rains?|'mHm!'|Yea, I like the rain too, and I love running in the rain.|'Running? Do you want to get a cold? Don't do that!'",
            "'I need some good prank ideas!'|Why?|'Geez, it's my final year here! I want to have some fun!'|Why do I think you're going to do something dangerous|'Whaa? You're the one that's going to hurt yourself!'|Right... Since you're the more responsible one|'I don't like the tone of your voice!~",
            "'Perfect Timing! I was just thinking about you!'|You were... What?|'I had another dream, you were in it!'|What was I doing in your dream?|'I won't tell you~'|I'm concerned|'Fineee, I'll tell you, but just make sure you don't laugh!'",
            "'Do you ever shop?'|Huh? I guess I buy stuff online, but not really in real life|'There's a farmer market tomorrow! Wanna come? I have a group of friends coming'|Oh. Uh, I'll be busy tomorrow|'All day? You should take some time to relax a little! If you don't get enough rest, you'll get wrinkles and white hair!'|Thanks for your concern",
            "Hey, How have you been doing?|'Great! The weather is really nice today! Don't you think?'|Yea I guess..|'You look so gloomy today, cheer up!'|I'll try, talk to you later."
        }, 0);

        lang.addLanguage(new string[]{
            "'วันนี้แดดแรงจริงๆ ว่าไหมอะ?'|อืมม... มันก็ดู… ปกติดีนะ?|'นายน่าจะเงยหน้าขึ้นไปมองมากกว่านี้นะเดี๋ยวก็ปวดหลังหรอกถ้าเอาแต่ก้มหน้าอยู่อย่างนั้นอะ'|ก็นะ ฉันปวดหลังไปแล้วหล่ะ|'อยากให้นวดให้ป่าว?'|ห่ะ? ไม่เอา",
            "'เฮ้! เป็นไงบ้างอะ?'|ฉันต้องตอบยังไงหล่ะนั่น?|'ก็แบบ, \"ดี\", \"แย่\", อะไรประมาณนั้นอะ?'|ดีนะ|'แล้วไงต่อ... พูดต่อเลย'|ไม่มีอารมณ์พูดจริงๆ|'หวาาา... แย่จังเลยอะ'|ฉันว่าเป็นเธอนี่ก็ดีจังเลยนะ",
            "'เมื่อคืนนี้ฉันฝันแปลกสุดๆ เลย แล้วมันก็น่าอายนิดหน่อย'|ฝันเป็นยังไงบ้าง?|'ม่ายยยยยยยยย มันน่าอายเกินไป!'|โอเค งั้นไม่ต้องพูดก็ได้|'ม่ายยยย นายต้องถามต่อสิ!'|เอ่อ... ละ-แล้วฝันเป็นยังไงบ้าง?|'ช่างมันเถอะ ตอนนี้ฉันรู้สึกเหมือนฉันไปบีบบังคับนายเลย'|เอ่อ... แล้วตอนนี้ฉันต้องตอบยังไงดี|'...แค่แบบ… ช่างมันเถอะนะ'",
            "'ไงบ้าง!'|ไง... บ้าง?|'ฝนจะตกแล้วนะ!'|จริงเหรอ?|'ช่าย แล้ววันที่ฝนตกก็เป็นวันที่พิเศษด้วยนะ!'|เธอชอบเวลาฝนตกเหรอ?|'อือฮึ!'|นั่นสินะ ฉันก็ชอบฝนเหมือนกัน แล้วฉันก็ชอบวิ่งเล่นในสายฝนด้วย|'วิ่งเล่นเหรอ? อยากเป็นหวัดรึไง? อย่าทำแบบนั้นสิ!'",
            "'ฉันต้องการไอเดียแกล้งคนแบบเจ๋งๆ!'|เอาไปทำไมหล่ะ?|'โถ่ ฉันอยู่ที่นี่เป็นปีสุดท้ายแล้วนะ! ฉันก็อยากเล่นสนุกบ้าง!'|ทำไมฉันถึงรู้สึกว่าเธอจะทำอะไรอันตรายๆ เนี่ย|'ห๋าาา? นายต่างหากที่จะทำให้ตัวเองเจ็บ!'|ก็จริง... ในเมื่อเธอเป็นคนที่มีความรับผิดชอบมากกว่า|'ฉันไม่ชอบน้ำเสียงนายเลยอ่า!~",
            "'มาได้เวลาเป๊ะ! ฉันกำลังคิดถึงนายเลย!'|เธอกำลัง... อะไรนะ?|'ฉันมีอีกฝันนึงด้วยหล่ะ แล้วนายก็อยู่ในนั้นด้วย!'|เธอฝันเห็นฉันทำอะไรบ้าง?|'ฉันไม่บอกนายหรอก~'|กังวลเลยนะเนี่ย|'ก็ได้~~~ ฉันจะบอกก็ได้ แต่นายห้ามหัวเราะนะ!'",
            "'นายเคยไปซื้อของบ้างป่าวเนี่ย?'|หือ? ฉันว่าฉันก็ซื้อของออนไลน์อยู่นะ แต่ไม่ได้ไปซื้อในชีวิตจริง|'พรุ่งนี้มีตลาดนัดนะ! อยากมาด้วยป่าว? มีเพื่อนอีกกลุ่มหนึ่งมาด้วยหล่ะ'|อ่าฮะ พรุ่งนี้ฉันไม่ว่างหน่ะ|'ทั้งวันเลยเหรอ? นายควรจะหาเวลาพักผ่อนบ้างนะ! ถ้าพักไม่พอเดี๋ยวก็มีตีนกาแล้วก็หัวหงอกหรอก!'|ขอบใจที่เป็นห่วงนะ",
            "เฮ้ ช่วงนี้เป็นไงบ้าง?|'ก็เยี่ยมเลย! วันนี้อากาศดีจริงๆ ! ว่าไหมหล่ะ?'|อืมม ก็น่าจะใช่นะ..|'วันนี้นายดูเศร้าๆ นะ ร่าเริงหน่อยสิ!'|เดี๋ยวจะลองดู ไว้คุยกันทีหลังนะ"
        }, 1);

        lang.addLanguage(new string[]{
            "'Le soleil est vraiment brillant aujourd'hui, tu trouves pas?'|Euh, il semble assez...Normal?|'Tu sais, tu devrais regarder le ciel plus souvent, tu vas avoir mal au dos si tu continues à baisser la tête'|Ben, j'ai déjà mal au dos|'Tu veux un massage?'|Quoi? Non",
            "'Hey! Comment ça va?'|Comment je suis censé répondre à ça?|'Tu sais,\"Bien\",\"Mal\", quelque chose comme ça?'|Bien|'Et...Continues'|J'suis pas pas vraiment de super humeur|'Aaaaaaah...C'est pas cool'|C'est pas cool d'être toi je suppose",
            "'J'ai fais un rêve super bizarre la nuit dernière, mais c'est un peu embarrassant'|C'était quoi?|'Noooon, c'est trop embarrassant!'|D'accord, le dis pas alors|'Noooon, t'es supposé continuer à vouloir savoir!'|Euh, C-C'était quoi le rêve?|'J'ai rien dis, maintenant ça se sent que je t'ais forcé'|Euh, je réponds quoi maintenant|'...Juste, oublies'",
            "'Quoi de neuf?'|Quoi... de neuf?|'Il va bientôt pleuvoir'|Oh, vraiment?|'Ouais, et les jours de pluie sont spéciaux!'|Donc t'aime ça quand il pleut?|'Hm!'|Ouais, j'aime la pluie aussi, et j'aime courir sous la pluie.|Courir? Tu veux attrapper froid? Fais pas ça!'",
            "'J'ai besoin de quelques bonnes idées de blagues!'|Pourquoi?|Bon sang, c'est ma dernière année ici! Je veux m'amuser un peu!'|Pourquoi j'ai l'impression que tu va faire quelque chose de dangereux|'Heein? T'es celui qui va te blesser tout seul!'|Bien... Puisque t'es la plus responsable|'J'aime pas le ton que t'as utilisé!~",
            "Juste au bon moment! J'étais en train de penser à toi!'|T'était... Quoi?|'J'ai fait un autre rêve,et t'était dedans!'|Et je faisais quoi dans ton rêve?|'Je te le dirais pas~'|Ça m'inquiète|'Bieeen, je vais te le dire, mais promet moi de ne pas rire!'",
            "'Tu fais les courses desfois?'|'Euh, j'achète des trucs en ligne, mais pas vraiment dans la vraie vie|'Il y a un marché demain! Tu veux venir? J'ai un groupe d'amis qui viennent'| Ah. euh, je suis occupé demain|'Toute la journée? Tu devrais prendre un peu de temps pour te relaxer! Si tu te reposes pas assez tu vas avoir des rides et des cheveux blancs!'|Merci de t'inquiéter",
            "Hey, Comment tu vas en ce moment?'Bien! Il fait bon aujourd'hui! Tu trouves pas?'|Ouais je suppose..|'T'es vraiment pas rayonnant aujourd'hui, sois plus gai!'|Je vais essayer, on se reparle plus tard."
        }, 2);


        tcsPos = lang.getLanguage();
    }
}
