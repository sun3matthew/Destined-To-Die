using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human13 : Classmate
{
    protected override void initHumanNum() => humanNum = 13;
    protected override void initPersonality() => personalityType = 2;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "0 20 25";//to school base
        path[arrivalButNotTheMoviePartTwo+1] = "26";
        path[arrivalButNotTheMoviePartThree - 1] = "9 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#65E2E2";

        LanguageLocalization<string[]> lang = new LanguageLocalization<string[]>();

        lang.addLanguage(new string[]{
            "'I simply adore this weather, not too hot, not too cold!'|Yea, I agree, the weather is pretty nice today.|'I do think there is too much wind today'|Hmm, yea.",
            "Have you thought about which college you want to go to?|'I plan to head to an Ivy League establishment, I believe I should be able to make it!'|Oh wow! Big plans I guess?|Indeed it is.",
            "'You're a very pleasant person to talk to!'|Oh, thank you!|'Do you not think about being that way?'|Huh? I really like talking to you too!|'That's good.",
            "'Making the most of today?'|Uh, yea. I was able to get some work done I guess? How about you?|'Well, I did lot's of work today, I was also able to acquire a job!'|Whoa! That's so cool!",
            "What's your favorite food?|'Well, I think chocolate is lovely!'|Hmmm, I don't think that's... Well it's more of a dessert?|'So you want an Entrée?'|Uh, yea|'Hmmm, I don't think I've quite found one yet?",
            "'How nice to see you today!'|Oh, did something happen?|'Hm? I think I just find conversations with you especially pleasurable!'|Heh, thanks I guess!",
            "'Oh, I love the weather so much. It's so blissful!'|Oh, isn't it just a little gloomy though?|'I think I like the cold and gloomy weather. I love it so much.'|That's good, I like the weather too!",
            "'It's such a lovely today, don't you think so my friend?'|Hm? Yea I guess today is pretty good|'I think today cannot get worse! It's almost perfect!"
        }, 0);

        lang.addLanguage(new string[]{
            "'เค้าชอบอากาศแบบนี้นะ ไม่หนาวไม่ร้อนเกินไป!'|ช่าย เห็นด้วย วันนี้อากาศดีนะ|'เค้าว่าวันนี้ลมพัดแรงไปหน่อย'|หืมม ก็ช่ายยนะ",
            "เธอคิดไว้รึยังว่าอยากเข้ามหาวิทยาลัยไหน?|'เค้าวางแผนจะไปมหาวิทยาลัยไอวีลีกแหละ เค้าว่าเค้าทำได้นะ!'|โอ้โห! เป้าหมายสูงเลยนะเนี่ย|ใช่เลยหล่ะ",
            "'นายเป็นคนที่น่าคุยด้วยมากนะ!'|อ่า ขอบคุณนะ!|'นายไม่เคยคิดแบบนั้นเหรอ?'|หือ? ฉันก็ชอบคุยกับเธอนะ!|'เยี่ยมเลย'",
            "'ทำวันนี้ให้ดีที่สุดอยู่รึเปล่า?'|อ่า ช่าย ในที่สุดฉันก็ทำงานเสร็จหล่ะนะ เธอหล่ะ?|'อืม วันนี้เค้าทำงานเยอะเลยแหละ เค้าหางานทำได้ด้วยนะ!'|โหวว! เจ๋งเลย!",
            "เธอชอบกินอะไรเหรอ?|'อืม เค้าว่าช็อคโกแลตก็ดีนะ!'|หืมมม ฉันไม่คิดว่านั่นมัน... อ่า มันดูเหมือนเป็นของหวานมากกว่านะ?|'งั้นนายหมายถึงอาหารคาวเหรอ?'|เอ่อ ช่าย|'อืมมม เค้าว่าเค้ายังไม่เจออะไรที่ชอบนะ'",
            "'ดีจังเลยที่เจอนายวันนี้!'|อ่า เกิดอะไรขึ้นรึเปล่า?|'หืม? เค้าคิดว่า...พอได้คุยกับนายแล้วเค้ามีความสุขเป็นพิเศษหน่ะ!'|เหะๆ ขอบใจนะ!",
            "'โอ้ย เค้ารักอากาศแบบนี้จังเลย สุขกายสบายใจสุดๆ!'|อืมม มันไม่มืดหม่นไปหน่อยเหรอ?|'เค้าว่าเค้าชอบอากาศเย็นๆ แล้วก็หม่นๆ แบบนี้แหละ ชอบมันมากๆ เลย'|นั่นก็ดีนะ ฉันเองก็ชอบเหมือนกัน!",
            "'วันนี้เป็นวันที่ดีจังเลย คิดเหมือนกันไหมเพื่อน?'|หืม? ช่าย ฉันว่าวันนี้เป็นวันที่ค่อนข้างดีเลย|'เค้าว่าไม่มีอะไรที่ทำให้วันนี้เป็นวันที่แย่ได้แน่นอน! มันแทบจะสมบูรณ์แบบเลยหล่ะ!"
        }, 1);

        lang.addLanguage(new string[]{
            "'J'aime juste trop ce temps, pas trop chaud, pas trop froid!'|Ouais, je suis d'accord, la météo est pas mal aujourd'hui.|'Je trouve qu'il y a quand même trop de vent aujourd'hui'|Hmm, ouais.",
            "T'as réfléchi à quelle université tu voulais aller?|'J'ai prévu de me diriger vers un établissement Ivy League, je pense que je suis capable d'y arriver!'|Oh wow! Gros projet je suppose?|'En effet ça l'est.",
            "'C'est vraiment agréable de te parler!'|Ah, merci!|'Tu penses pas que ce soit le cas?'|Hein? J'aime vraiment te parler aussi!|'C'est bien.'",
            "'T'as fait le plus que tu pouvais aujourd'hui?'|Euh, ouais. J'ai pu finir un peu de travail ? Et toi?|'Eh bien, j'ai beaucoup travaillé aujourd'hui, et j'ai aussi réussi à obtenir un job!|Whoa! C'est trop cool!",
            "C'est quoi ta nourriture favorite?|'Ben, je pense que le chocolat est pas mal!|Hmmm, je pense pas que ce soit... Ben c'est plus un dessert?|Donc tu veux une Entrée?'|Euh, ouais|'Hmmm, Je pense que je sais trop pour l'instant?'",
            "'Ah ça fait plaisir de te voir aujourd'hui!'|Oh, quelque chose est arrivé?|'Hm? Je pense que je trouve juste les conversations avec toi particulièrement sympathiques!|Ahah, merci je suppose!",
            "'Ah , j'aime tellement la météo, c'est vraiment plaisant!'|Ah, ce n'est pas un petit peu morne quand même?|Je pense que j'aime bien le temps morne et froid. J'aime vraiment ça.'|C'est bien , j'aime bien ce temps aussi!",
            "'Quelle belle journée, tu trouves pas mon ami?'|Hm? Ouais je pense qu'aujourd'hui on est plutôt pas mal|'Je pense que cette journée ne peut pas mal tourner! C'est presque parfait!'"
        }, 2);


        tcsPos = lang.getLanguage();
    }
}
