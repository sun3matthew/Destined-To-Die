using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human14 : Classmate
{
    protected override void initHumanNum() => humanNum = 14;
    protected override void initPersonality() => personalityType = 4;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie+1] = "2 19 31 29";//to school base
        path[arrivalButNotTheMoviePartTwo] = "30";
        path[arrivalButNotTheMoviePartThree - 1] = "26 2";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#99CC33";

        tcsPos[0] = "'Ayo'|Hey there|'I got a question for you!'|Yep?|'From one to ten, how buff am I!'|I- I don't know? Maybe like seven?|'Come on man! Only seven???'|I meant to say ten, my bad|'Ha! My man!!!'";
        tcsPos[1] = "'What up!'|Hello|'I wish the sun got bigger! I want to flex on all you fools!'|I- Maybe save it for when I'm gone...|'Nah! Mark my words, tomorrow you'll see my bulging muscles!'";
        tcsPos[2] = "'My personality is too nice!'|Nice is good? That's what girls like these days anyways?|'What?! I need to pump up my personality!'|I mean like, if that's what you want to do?|'Ayyyyy, my best bud!'";
        tcsPos[3] = "Heyo|'Stay strong man...'|Uhm, did something happen?|'The weather. So gloomy, don't it getcha down?'|I kinda like it this way, it's easier on the eyes I guess.|'Well ya looked kinda down.'";
        tcsPos[4] = "'Yo!'|Hello|'You ready to go on a great run tomarrow!'|Yea, I'm ready|'Ya gotta love the weather these days! Perfect running weather!'|Uhh, sure I guess?|'Hey! Cheer up dude! Now's a better time than any to run!";
        tcsPos[5] = "Hello|'Bro I'm so broke man'|Hmm, maybe go get a job?|'No one will hire me man! I'm Dumb!'|Well summer's coming up, you could be a lifeguard?|'Yoo! You're right! I would get to flex my bod too!'";
        tcsPos[6] = "'Hey! I wanna have a cool nickname!'|Why?|'Bro my name sounds so boring right now! I need something to pump it up!'|Hmmmm, I see. How about-<?????????????????????????????????????????????????0";
        tcsPos[7] = "!0";
    }
}
