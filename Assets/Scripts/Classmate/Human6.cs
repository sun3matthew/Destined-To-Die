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
            "'???????????????????????????????????????!'|???????????????????????????????????? ???????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????|'??????????????????????????????! ?????????????????????????????????????????????????????????????????????????????????????????????! ??????????????????????????????????????????????????????????????????????????? ?????????????'|?????????????????? ???????????????????????????????????????????????? ??????????????? ???????????????????????? ?????????????????????????|'55! ????????????????????? ????????????????????????????????????????????????????????????????????????!'|?????????????????????????????????????????????????????????????????????????????????????????????????????????????",
            "'???????????????????????????????????????????????????????????????????????????????????????????????'|??????????|'??????????????????????????????????????????????????????????????????????????????????????? !'|????????? ?????????????????????????????????????????????????????????????????????|'?????????????????????????????????????????????????????????????????????~!'|?????????????????????????????? ?????????????????? ?????????????????????????????????????????????????????????????????????????????????????????? ???????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????? ??????????????????????????????????|'??????????????????????????????! ???????????????????????????????????????????????????????????????????????????????????????!'|...?????????????????????????????????????????????????????????????????????????????????????|'??????????????????????????????????????????! ??????????????????????????????????????????????????? !'|????????? ???????????????????????????????????????????????????????????????????",
            "'???????????????????????????????????????????????? ??????????????????????????????!'|????????????????????????????????????????????????????????????????????????????????????- ??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????|'????????????????????????! ????????????????????????????????????????????????????????????!!!'|??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????...|'??????????????????????????????????????????! ????????????????????????????????????????????????????????????????????????!'|???????????????????????????????????????????????????????????????????????????",
            "'??????????????????????????????????????????????????????!'|??????????????????????????????????????????????????????????????????????|'?????????? 20 20?????????????'|????????????????????????????????????...|'??????????????????????????????????????????????????????????????????????????? ????????????????????????????????? ????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????!'|???????????? ??????????????????????????????????????????????????????????????????????????? ??????????????????????????????????????????????????????????????????????????????????????????????????????|'?????? ??????????????????! ??????????????????????????????????????????????????????! ?????????????????????!'",
            "'?????????????????????????????????????????????????????? ...'|?????????????????????????????????????????????????|'???????????????????????????????????????????????? ???????????????????????? 1 ?????????????????????????????????!'|????????? ?????????????????????????????????????????????????????????????????????????|'?????? ??????????????????????????????????????????????????????! ???????????????????????????????????????????????????????????????!'|??????????????????????????????????????????????????????????????????????|'??????! ???????????????????????????????????????????????????????????????????????????????????????~'",
            "'??????????????????! ??????????????? ????????????????????????????????? ???????????????????????????????????????????????????????????????????'|??????????????? ??????????????????????????????????????? ?????????????????????????|'????????? ?????????????????????????????????????????????! ??????????????????????????????????????????????????????????????????????????????????????????????????????????'|??????????????????????????????????????? ????????????????????? ??????????????????????????????????????????????????????- ???????????????????????? ????????????????????????????????????????????????????????????????????????????????????? |'?????????????????????????????????????????????????????????????????????????????????????????????????'|??????????????? ??????????????????????????????????",
            "'???????????????????????????????????????????????????????????????????????????????????? ?????????????????????!'|??????????????????????????????????????????...?????????????????????????????????????????????????????????????????? ???????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????!|'???????????????????????????! ??????????????????????????????????????????????????????????????????????????????????????????... ???????????????????????????????????????????????????????????????!'",
            "'???????????????????????????????????????????????????????????????????????????????????????????????? ?????????'|????????? ???????????????????????? ??????????????????? ????????????????????????? ????????????????????????????????????????|'????????? ????????????????????????! ?????????????????????????????????????????????????????????????????????????????????????????????????????????????????????! ??????????????????????????????????????????????????????????????? ?????????????????????????????????????????????????????????????????????????????????????????????!'|???????????? ????????????????????????????????????..."
        }, 1);

        lang.addLanguage(new string[]{
            "'J'adore jaboter!'|Je peux dire, je crois que t'es la seule personne que je connais qui utilise le mot jaboter'|'Pas possible! Quand j'??tais dans ma ville on disait ??a tout le temps! Vous utilisez vraiment jamais ce mot?'|Non, parce que c'est p't'??tre trop, euh, je sais pas. Bizarre?|'Haha! Ben je vais continuer ?? le dire!'|??a te rend unique je pense?",
            "'TU T'ES CLON????'|Quoi?|'Je t'ai vu tellement de fois aujourd'hui!'|Bah, euh, je ne me suis pas clon??|'J'te crois pas~!|Je veux dire genre, je pense pas que c'??tait moi mais peut ??tre que j'ai boug?? vite?|'NON! t'avais un t-shirt diff??rent!'|...Ducoup...Comment t'as su que c'??tait moi?|'Ta fa??on de marcher! T'es tout pench??!'|Ah. T'es d??fonc???",
            "'Oh mon dieux, encore toi!'|C'est la premi??re fois qu'on se vois- T'es toujours sur le truc de clonage?|'J'te promet il te ressemble parfaitement!!!'|J'arrive vraiment pas ?? dire si tu rigoles ou pas...|'J'te promeeeeeeet! Pourquoi je te mentirais?'|Je vais juste en conclure que t'es aveugle.",
            "'Re-Bonjour!'|T'as une bonne vision?|'Euh? 20/20?|Je comprends pas...|'Je sais pas ce que tu cherche ?? savoir. Dans tous les cas, est-ce que le soleil est pas super aujourd'hui!'|Euuuuuh, j'aime pas trop le soleil, c'est juste trop brillant et chaud.|'Ahhhhhh, mec! Mais les rayons de soleil! Ils sont trop beaux!'",
            "Je suis trop fatigu??e aujourd'hui...'|Quand est'ce que tu t'es couch??e?|'Oh mon dieux, genre 1h du mat ou quelque chose comme ??a!'|Ah, tu faisais quoi jusqu'?? cette heure?|'Bah j'arrivais juste pas ?? dormir! Mon esprit est toujours en train de travailler!'|Et tu pensais ?? quoi?|'Ha! Je pense que je vais pas te l'dire~'",
            "'Gah! Oh c'est juste toi. Tu vas beaucoup faire du shopping?'|Euhhh, pas souvent. Pourquoi?|'Ah je me me demandais juste! C'est quand la derni??re fois que t'es all?? faire du shopping?'|Pas r??cemment? Peut-??tre genre il y a un an-Attends comme pour des v??tement on est d'accord?|'Qu'est ce que tu voudrais acheter d'autre?'|Euhhh, du bois?",
            "'J'aimerais que le soleil reste lev?? plus longtemps!'|Bah, peut ??tre que tu devrais te lever plus t??t, que tu puisses voir le soleil du lev?? au couch??!|'Noooon! J'aime pas le soleil ?? ce point...Je peux pas me lever t??t!'",
            "'Je pense que je vais bient??t d??m??nager'|Attends quoi? Vraiment? Quand?|'Eh, calmes toi! C'est pas quelque chose qui devrait te faire stresser! C'est pas pour tout de suite et on peut toujours se parler en ligne!'|Ouais je suppose..."
        }, 2);

        tcsPos = lang.getLanguage();
    }
}


