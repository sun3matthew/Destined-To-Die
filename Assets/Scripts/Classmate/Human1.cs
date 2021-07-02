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

        tcsPos[0] = "What's up?|'You're so chatty!'|Lmao, I guess I'm just in a good mood today?|'Awesome! What did you do?'|Uhhh, I don't know, I guess I had lots of sleep?|'Ha! I can't sleep early, I have too much energy! I just dance through the night!'|Dance?|'Oh, it was an exaggeration! I don't actually dance that much~'|Oh I see.";
        tcsPos[1] = "Did you sleep well?|'Well I took a few melatonin pills I knocked out early.'|Oh, how many did you take?|'Hmm? One?'|Oh I see|'Hmmm? Why'd you ask?'|Oh I just remembered that if you take too much you get nightmares.|'Haha, that's a weird thing to know!'|Yea...my friend told me about it once";
        tcsPos[2] = "'I'm so stressed right now!'|Uh Oh, what happened?|'I failed my chem quiz!!'|Like fail fail? Or like, did you just get a B?|'I got a 69!!'|Heh, 69.|'Hey! I'm having a crisis right now!!'|Well maybe you can just retake it?|'I know, But I'm still super stressed!'|Welp, hopefully you feel better soon?";
        tcsPos[3] = "'Would you rather swim as fast as a fish or fly as fast as a bird?'|Why would anyone choose to swim?|'Hmmm. Oh! You can also breathe underwater?'|Like both freshwater and saltwater?|'Um... Yes?'|I feel like flying is just much more practical, like for traveling, or getting places without a ladder.";
        tcsPos[4] = "'I think I might move...'|Uh no! Why?|'I don't really know, but I'm super sad about it...'|That really sucks, well come to visit us after you move!|'Probably, I think I'm going to live pretty far away, but I'll try by best!'";
        tcsPos[5] = "I probably should have eaten earlier, or maybe I ate too much.|'What?! You're already so skinny! You need to eat more!'|Well I'm cramping right now, and I feel so full|'What? Hmmmm... Then you should eat early!'|That...That's the goal?";
        tcsPos[6] = "'Hey! Remember when I said that I was moving? Well my parents changed their minds!'|Ah, I've been scammed|'WHAT?! Were you excited that I would go???'|I was kidding! Of course I'm glad that you're staying!|'Hehe, I'm so happy!'";
        tcsPos[7] = "'I'm so tired today...'|Oh, did you get enough sleep?|'Well I took some more sleeping pills but I still couldn't sleep!'|Oh, well hopefully you can sleep better soon..|'Yep!'";
    }
}
