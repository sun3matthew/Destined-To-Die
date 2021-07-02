using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human9 : Classmate
{
    protected override void initHumanNum() => humanNum = 9;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie] = "1 19 29 37";//to school base
        path[arrivalButNotTheMoviePartTwo-1] = "19";
        path[arrivalButNotTheMoviePartThree + 1] = "25 1";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#7ADAD0";

        tcsPos[0] = "'I think school is too hard, I wish they just made it easier.'|Ah that sucks, I guess just take it easy?|'Well, I just hate how time consuming it is, the work is actually pretty easy?'|Oh, still take it easy I guess?";
        tcsPos[1] = "You have a very unique smell!|'In a good or a bad way?'|In a good way?|'That's good, I would agree with you. I do spend time working on it.";
        tcsPos[2] = "'Hey, I'm still popular right?'|Sure!|'Sure? What does that mean?'|Like I think you're still pretty popular!|'Yea, I guess you can't relate'|Heh, right.";
        tcsPos[3] = "'I wish I lived closer to you!'|Oh, interesting. Why?|'Last night I realized I wanted to talk to you!'|Oh, heh. Well you could just message me I guess?|'Nope! I wanted to talk to you in person!'";
        tcsPos[4] = "Hi!|'I think you should try new outfits!'|Oh, like what?|'Something other than jeans and t-shirt?'|Oh, I think that's too much effort...";
        tcsPos[5] = "'I'm so cold!'|Oh that sucks, well I guess now's a good time to start wearing more?|'Orrrrrrrrr you can lend me your jacket!|'But, then I would be cold?|'Awww man... sad face'";
        tcsPos[6] = "'I love your hair so much! It's cute!'|Oh, thank you!|'I think you could grow out your hair more though! It would look even better!'|Oh ok, I'll look into it I guess!";
        tcsPos[7] = "'Hey, Do you want to go get boba with me tomorrow?'|Oh uh, sorry, probably not?|'Oh... ok then! I was just asking!'";

    }
}
