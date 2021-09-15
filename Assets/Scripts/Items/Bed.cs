using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Interactable, Clickable
{
    TimeDay timeDayObj;
    private string notice;
    protected override void Start()
    {
        base.Start();
        /*tcs[00] = "Please, I don't want to die. Maybe I do. Why am I sad. I don't know. I don't know. I'm so scared someone please just help me. Please please please...";
        tcs[01] = "True Friend... I want someone I can cry to. I want to cry. I want to talk to someone. It just hurts so so much.";
        tcs[02] = "Why am I crying so much. I just want to feel something. It feels good. Help me, Help me. Please...";
        tcs[03] = "I'm sad. this is bad. Why can't I just tell someone. I'm just so so scared. Help. Help me";
        tcs[04] = "I hate it all so much, I'm so scared. Someone, help... help.";
        tcs[05] = "I want to cry, I just want to cry, I want to feel something";
        tcs[06] = "I think I'm fine. I'm not sad. I'm not sad. I'm not sad.";
        tcs[07] = "Am I just stressed out? I want to feel something.";
        tcs[08] = "I feel nothing, I think I'm happy. I don't really know. I'm just numb";
        tcs[09] = "I guess today was okay, But overall I think my life is going fine";
        tcs[10] = "I'm happy, life is good. I think I'm happy|I don't think I can ever be happy, It'll always come back. But I'll just enjoy it while it lasts";
        tcs[11] = "Am I happy? Yes, this is what being happy is. I am happy.|I'm enjoying life! Everything is good. Yes, I am happy.";
        tcs[12] = "I like being happy, I don't want it to leave.|How do I stay happy, I want to stay happy. I don't want to go back";
        tcs[13] = "My scars, I've changed, I'm happy now. I wont go back|This is what being happy is. I love being happy, I just want to stay like this forever";
        tcs[14] = "I'm happy I want to stay like this forever. I don't want to be sad. This is good.|Life is awsome. I'm enjoying myself, I'm happy!";
        tcs[15] = "Wow, life is fun. This is what it means to be happy, I'm chilling!";
        tcs[16] = "ERROR: Unable to Fetch";
        tcs[17] = "ERROR: Unable to Fetch|ERROR: Unable to Fetch|ERROR: Unable to Fetch|ERROR: Unable to Fetch|@#@# &&&@**";
        tcs[18] = "ERROR: Unable to Fetch|ERROR: Unable to Fetch|ERROR: Unable to Fetch|ERROR: Unable to Fetch|(*&#$&$&&@ @#$ @# #@#__%@# &|@#*($& @#@#* @#*#@ @#(*&$";
        tcs[19] = "ERROR: Unable to Fetch|ERROR: Unable to Fetch|ERROR: Unable to Fetch|@#$*(%&&*(&*@#&*(*($*(&|(*)@#$*#(@)*$@#$!!|#@()$)@(#%*)@#(*$@#)(#$*@$|@#$#@$@#%!@%@!$!@$";
        tcs[20] = "ERROR: Unable to Fetch|@!^$%#!@%^$#^% !@&&!@*!@*$!@!!|!@%&^(*@#*&(*(&@#*&*(*( &&&&&&&@&@&&@&@&@|!@#!@$#@%%#@@@@@# # @#@@@$%#@@#|*(&*( @#*($*@# *#$&@#*(&$*(&@*(#&$(& @@#$$$$|I can't be happy.";*/

        LanguageLocalization<string> localization = new LanguageLocalization<string>();
        localization.addLanguage("I'm not sleepy, it's still too early in the day", 0);
        localization.addLanguage("ฉันไม่ง่วง มันยังไม่ดึกเลย", 1);
        localization.addLanguage("Je ne suis pas fatigué, il est trop tôt dans la journée", 2);
        notice = localization.getLanguage();
    }
    public void clickedOn(bool type)
    {
        if(type)
        {
            if (time.timeDay > 20 || time.timeDay < 5.5)
                player.resetDay();
            else
                Cutscene.cutscene(notice);
        }
    }
}
