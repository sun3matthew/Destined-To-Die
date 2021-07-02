using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human5 : Classmate
{
    protected override void initHumanNum() => humanNum = 5;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "2 31 28 16";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "17";
        path[arrivalButNotTheMoviePartThree + 2] = "19 3";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#78CBB5";

        tcsPos[0] = "Hello|'Ayo, Need something lad?'|Oh I was just saying hi|'I gotchu bro, what's up fella?'|Nothing much, uh, how about you?|'I'm feeling awesome! I'm excited to get to know you more buddy!'";
        tcsPos[1] = "'Whatcha doing lad?'|Uh, standing?|'Haha! I meant like in general, howz school, howz life?'|Oh ok, school's fine, and my life is okay too I guess|'Bro! You need to talk more man!'";
        tcsPos[2] = "'Ya like music at all?'|Yea, I enjoy it for the most part I think?|'Nice! What kind of music?'|I don't really know what it's called, just lots of weird stuff, how about you?|'Rock!'";
        tcsPos[3] = "'Ayo, you wanna follow me?'|I'm sorry what?|'I found a new running trail today! I need some buds to check it out with me!'|Hmm, sorry but I'll pass.|'Awwwwww man! Well I won't force you!";
        tcsPos[4] = "'Hey, I need to ask you a question'|Yep?|'Are dinosaurs really birds? Like bro when I heard that, I remembered that they both lay eggs!'|I think it's the other way around, like the square rectangle thing.|'The what?'";
        tcsPos[5] = "'Hey man, can you help me with a calc question?'|Uhhhhhhh, sure?|'So like the separation of variables crap, how does that work?'|Uhhhhhhhhh, listen, I honestly forgot how that stuff worked...";
        tcsPos[6] = "'Ayo, there's a firework show soon! Me and my buddies are going to check it out! Wanna hop in?'|Uhhh, sorry, I'm kinda busy these days.|'Awww man, just one day brosky?'|Sorry, I really can't|'That sucks.'";
        tcsPos[7] = "Heyo!|'Yo what's up fam!'|Uhm, nothing much, how about you?|'Pretty good!'|That's nice.|'Yea man!'";
    }
}