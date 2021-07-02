using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human7 : Classmate
{
    protected override void initHumanNum() => humanNum = 7;
    protected override void initPersonality() => personalityType = 0;
    protected override void initPaths()
    {
        path[arrivalButNotTheMovie+1] = "2 11 39 38";//to school base
        path[arrivalButNotTheMoviePartTwo] = "28";
        path[arrivalButNotTheMoviePartThree + 1] = "20 2";
    }
    protected override void initHome() => house = new Vector2(87.35f, 10.17f);
    protected override void initConvos()
    {
        humanName = "#77B4E4";

        tcsPos[0] = "Hey|'Huh? Oh, I think I've seen you before'|Oh...Wait really?|'Huh? Maybe it was someone else...'|...|'Sorry this is embarrassing'|No it's fine|'Just pretend this never happened will ya?'";
        tcsPos[1] = "'You need to eat more fruits and veggies!'|Pfft, your not my mom|'It's unhealthy if you keep on eating microwaved burritos!'|My metabolism will handle it, it'll be fineee...|'I'll make you stronger!'|I really don't think that's how it works";
        tcsPos[2] = "Hey!|'You need to take care of yourself more'|Is that all you ever talk about?|'Seriously! How hard is it to eat more fresh fruit!'|Well, I would need to leave my room which is already too much effort|'Thats a little concerning, but whatever'";
        tcsPos[3] = "'Are you planning to watch the rally?'|There's a rally today?|'Of course! They started announcing it last week!'|Why are you being so loud|'It's one of my most charming qualities~'|Riiiiight|'You should try being more outgoing!'|Nope, nope, nope!";
        tcsPos[4] = "'Why do you look so... Sad'|I honestly don't know, it's probably just because I didn't get enough sleep or something|'I think your sadness is due to this weather, it's cold and wet'|You know rain is my favorite weather?|'What? Why?'|I don't know, I just like it";
        tcsPos[5] = "I have a question to ask you|'Ya think you can give me a greeting first?'|Uhh, What?|'Like a \"Hi\" or a \"Hello\"'|Does it matter that much?|'People might think you're rude, and it wouldn't hurt'|Fine, Hii~ How are you doing this fine day~|'Thank you~, now stop with the sarcasm'|I don't think I will";
        tcsPos[6] = "'Have you ever had a nickname?'|Why?|'I've made an awesome nickname for you!'|No|'Really? its super funny!'|Our sense of humor don't always match|'Hey! my sense of humor is much better than yours!'|I said different, not better, although I would disagree with you|'Hey!'";
        tcsPos[7] = "'If you could do anything you wanted, what would you do'|That's a stupid question|'Fine! Well I wish I could travel the world!'|Isn't that what everyone wants?|'So What~ I still want to do it'|Well have fun with that|'I will! Sorry I have to go somewhere, I'll talk to you later!'|Talk to you later";
    }
}
