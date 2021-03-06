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
            "??????????????????!|'???????????????????????????????????????????'|??????????????? ????????????????????????????????????????????????|'????????? ????????????????????? ?????????'|???????????????????????????????|'????????????????????????????????????????????????????????????????'|????????????????????? ?????????????????????????????????????????????????????????????????????????????????????|'????????? ???????????? ??????????????????????????????????????????????????????'|????????????",
            "'????????????????????????????????????????????????????????????????????????????????????????????????????????????'|????????? ?????????????????????|'???????????????????????????! ??????????????????????????????????????? ????????????????????????????????????????????????????????????????????????!'|????????? ????????? ?????????... ????????? ??????????????????????????????????????????",
            "????????????????????????????????????????|'?????????????????????????????????????????????????????????'|????????? ??????????????????????????????????????????????|'???????????????????????????????????? ?????????????????????????????????????????????????????????????????????'|????????? ?????????????????????????????????????????????????????????????????????????????????????????????????????????????|'????????????????????????????????????'",
            "'????????? ???????????????????????????????????????????????????????????????????????? ?????????????????????????????????????????????????????????????????????'|???????????????????????? ????????????????????????????????????????????????????????????????????????????????????????|'???????????????????????????????????????????????? ??????????????????????????????????????????????????????????????????????????????????????????????????????'|?????????... ??????????????????...",
            "'??????????????????????????????????????????????????????????????????????????????????'|???????????????????|'????????????????????????????????? ??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????'|????????? ????????????????????????????????????????????????|'???????????? ??????????????????????????????????????????????????????????????????????????????????????????'",
            "'???????????????????????????????????????????????????????????????????????????????????? ?????????????????????????????????????????????'|???????????? ?????????????????????????????????????????????????????????????????? ????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????|'????????? ????????????????????????????????????????????????????????????????????????????????????????????????????????????????'|????????? ??????????????? ?????????????????????????????????????????????",
            "????????????????????????????????????????|'??????????????????????????????????????????????????????? ??????????????????????????????????????? ???????????????????????????????????????????????????????????????????????????????????????????????????????????????'|???????????? ??????????????????????????????????????????????????????????????????????????????????????????????????????????|'????????????????????? ?????????????????????????????????????????????????????????????????????????????????'",
            "'????????????????????????????????????????????????????????????????????????????????????'|?????????????????????????????????????????????????|'?????????????????????????????????????????????????????????????????????????????????????????? ????????????????????????????????????????????????????????????????????????????????????????????????'|????????? ???????????? ???????????????!"
        }, 1);

        lang.addLanguage(new string[]{
            "Salut!|'Qu'est ce que tu veux?'|J'te salue juste?|'Oh salut. Je suppose.'|Comment tu vas?|'T'as besoin de quelque chose?'|Non? Je demandais juste comment se passait ta journ??e?|'Oh ok. Je passe mon tour.'|Ok",
            "'Voir ta t??te me fait juste souhaiter que ma journ??e n'aie jamais commenc??.'|Ah, d??sol??|'HAHAHA! Je rigolais juste.T'as vraiment pris ??a s??rieusement!'|Eheheh...ouais. je crois que c'est le cas.",
            "Comment ??a va?|'Le temps est vraiment nul aujourd'hui.'|Ah, pourquoi ??a?|'Il fait trop chaud. Et il n' y a pas de vent du tout.'|Ah, ben je pense que ??a va commencer ?? se rafra??chir bient??t?|'??a ferait mieux.'",
            "'Salut, pourquoi tu sembles mort aujourd'hui. ??a plombe l'ambiance.'|J'suis d??sol??, je vais essayer de sourire un peu?|'C'est comme tu veux, je pense pas vraiment que les gens te pr??te attention dans tous les cas'|Eheh...pas faux.",
            "'Pourquoi t'es si ??nervant?'|Pardon?|'Oublies. J'ai juste pas dormi du tout la nuit derni??re.'|Oh, ??a fait sens je pense.|'Ouais, les gens m'??nervent juste aujourd'hui.'",
            "'Pourquoi il fait si froid aujourd'hui, c'est super p??nible.'|Ouais il fait assez froid, je pense que tu peux juste porter plus de couches de v??tements.|'Quoi, tu crois que j'ai pas essay?? ??a?'|Oh d??sol??, c'??tait juste une suggestion.",
            "Comment ??a va?|'??a pourrait pas neiger l??? Il fait vraiment super froid, mais apparemment pas assez pour qu'il neige.'|Ouais, peut-??tre que c'est pas assez humide?|'Ouais non. Je pense pas que ce soit la raison.'",
            "'J'suis super ??nerv?? aujourd'hui.'|Qu'est ce qui c'est pass???|'J'ai pas envie de parler de ??a aujourd'hui, j'te dirais un autre jour.'|Oh ok, bien s??r!"
        }, 2);

        tcsPos = lang.getLanguage();
    }
}
