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

        tcsPos[0] = "'I simply adore this weather, not too hot, not too cold!'|Yea, I agree, the weather is pretty nice today.|'I do think there is too much wind today'|Hmm, yea.";
        tcsPos[1] = "Have you thought about which college you want to go to?|'I plan to head to an Ivy League establishment, I believe I should be able to make it!'|Oh wow! Big plans I guess?|Indeed it is.";
        tcsPos[2] = "'You're a very pleasant person to talk to!'|Oh, thank you!|'Do you not think about being that way?'|Huh? I really like talking to you too!|'That's good.";
        tcsPos[3] = "'Making the most of today?'|Uh, yea. I was able to get some work done I guess? How about you?|'Well, I did lot's of work today, I was also able to acquire a job!'|Whoa! That's so cool!";
        tcsPos[4] = "What's your favorite food?|'Well, I think chocolate is lovely!'|Hmmm, I don't think that's... Well it's more of a desert?|'So you want an Entrée?'|Uh, yea|'Hmmm, I don't think I've quite found one yet?";
        tcsPos[5] = "'How nice to see you today!'|Oh, did something happen?|'Hm? I think I just find conversations with you especially pleasurable!'|Heh, thanks I guess!";
        tcsPos[6] = "'Oh, I love the weather so much. It's so blissful!'|Oh, isn't it just a little gloomy though?|'I think I like the cold and gloomy weather. I love it so much.'|That's good, I like the weather too!";
        tcsPos[7] = "'It's such a lovely today, don't you think so my friend?'|Hm? Yea I guess today is pretty good|'I think today cannot get worse! It's almost perfect!";
    }
}
