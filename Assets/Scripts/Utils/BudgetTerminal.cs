using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Steamworks;

public class BudgetTerminal : MonoBehaviour
{
    // Start is called before the first frame update
    Text textComponent;
    InputField keyb;

    string[] logIn;
    string[] logo;
    char blanking = '\u2588';

    string currTxt;
    int logInIdx;
    int logoIdx;
    long currNum;
    float pauseSeconds;
    float currTimer;
    int simulationRepeatCounter;
    float waitTimer = -1;
    bool done;

    bool typn;

    void Start()
    {
        //print(PlayerPrefs.HasKey("volume"));
        //if (!PlayerPrefs.HasKey("volume"))
        //    PlayerPrefs.SetInt("volume", 50);
        DontDestroyOnLoadManager.becomeMortal();
        AudioListener.volume = PlayerPrefs.GetInt("volume", 50)/100f;
        currTimer = 0;
        currTxt = "";
        typn = false;
        textComponent = transform.GetChild(0).GetComponent<Text>();
        keyb = transform.GetChild(1).GetComponent<InputField>();
        string temp = "                  ..............................................                  \n            ...&&&&&&&&&&&&&&&&&######################&&&&&&&&&&&&&...            \n       ...&&&&&&&&&&&&&&&&&&&&&&&&############&&&&&&&&&&&&&&&&&&&&&&&&&&...       \n     ..&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&..     \n   ..&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&..   \n  ..&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@@@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&..  \n..&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@((((@@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&######..\n..&&&&&&&&&&&&&&&&%%%%%%%%&&&&&&##&&((@@&&&&&&&&&&&&&&%%%%%%%%%%################..\n..&&&&&&&&&&&&&&&&&&########@@((&&&&&&((@@&&&&&&&&&&############################..\n..&&&&&&&&&&&&####&&########@@((&&&&&&((@@&&&&&&&&&&##########@@################..\n..&&&&&&&&&&&&####&&&&######@@((&&&&((((@@&&&&&&&&&&##########@@################..\n..&&&&&&&&&&&&%%####&&######@@((&&((((@@@@@@@@&&&&&&&&####%%&&&&################..\n..&&&&&&&&&&&&&&&&##&&######    ################@@&&&&####@@########@@@@@@######..\n..&&&&&&&&&&&&&&&&&&&&&&&&,,,,      ######@@####@@@@&&##&&&&######@@((((((@@####..\n..&&&&&&&&&&&&&&&&&&&&&&,,,,######          @@######@@@@@@&&##@@@@((&&&&&&((@@##..\n..##&&&&&&&&&&&&&&&&&&&&,,########&&&&##      ############@@@@@@((((&&&&&&((@@##..\n..####&&&&&&&&&&&&&&&&,,##&&&&@@@@      &&%%      ############((##&&&&&&((@@####..\n..####&&&&&&&&&&&&&&&&&&&&&&,,@@@@    &&&&    ##    ##@@@@######&&&&&&((((@@####..\n..######&&&&&&&&&&&&&&&&&&,,@@@@@@@@  &&    ######    @@  ######&&&&&&((@@######..\n..########&&&&&&&&&&##,,,,,,@@@@@@&&&&&&&&######    @@@@    ######&&((@@########..\n..######&&############&&&&@@@@@@@@@@@@&&&&    ##@@@@    &&  ################&&##..\n..####&&&&############&&&&&&@@@@@@@@      &&&&@@      &&&&    ##############&&&&..\n..####&&&&##############((((&&@@@@@@@@@@    &&@@@@  &&&&##,,##############&&&&##..\n..####&&##&&############((((((&&&&@@@@&&&&  &&&&@@@@@@####,,############&&&&####..\n..########&&&&############((&&((&&&&&&&&&&@@&&&&@@@@@@##,,##########&&&&########..\n..##########&&&&##########((&&((((**&&@@@@@@@@@@@@,,,,##,,####&&&&##&&##########..\n..%%%%######**&&##########&&&&((((**&&&&@@@@@@@@@@&&&&##,,((##&&**##&&##########..\n..%%%%%%####**&&##########&&((((((**((((&&&&&&@@@@&&&&((((((((****&&######@@@@##..\n..####%%%%####**&&&&&&&&&&&&##((((((****&&##########&&((((((****&&&&&&####@@####..\n..&&####%%####****&&&&&&&&**##%%((((##**&&########@@&&@@((((**&&&&&&&&&&####@@&&..\n..&&####%%%%####**&&&&&&&&****%%&&####**&&&&@@@@@@&&&&@@((@@**&&&&&&&&&&%%%%##&&..\n..&&&&&&&&%%%%&&**&&&&&&&&##**%%%%%%@@&&**&&@@@@&&&&@@@@@@**&&&&&&&&&&&&%%%%####..\n....&&&&&&&&%%%%@@**&&&&&&##&&**%%%%&&&&**@@@@&&&&@@@@@@****&&&&&&&&&&%%%%&&##....\n....&&&&&&@@%%%%@@****&&&&&&&&**%%%%%%&&**@@@@&&&&@@((((**%%&&&&&&&&%%%%@@@@##....\n....&&@@&&@@@@%%@@@@**&&&&&&&&**&&%%%%%%**@@@@&&%%@@((&&**%%&&&&&&%%%%%%&&&&@@....\n......@@&&&&@@%%@@@@**&&&&&&&&**&&&&%%%%**@@@@&&%%%%&&****&&&&&&%%%%%%&&&&&&......\n..............&&%%%%&&&&&&##&&**&&&&&&@@@@@@&&&&&&%%%%**%%&&&&%%&&&&..............\n..................................................................................\n........&&&&&&&&..................................................................\n  ......&&....................................................&&................  \n  ......&&&&&&&&..........................&&&&&&....&&&&&&..&&&&&&....&&&&......  \n  ............&&..&&....&&..&&&&&&&&....&&&&......&&....&&....&&....&&..........  \n    ..........&&..&&....&&..&&....&&....&&........&&....&&....&&......&&......    \n    ....&&&&&&&&..&&&&&&&&..&&....&&......&&&&&&....&&&&&&&&....&&..&&&&......    \n      ......................................................................      \n        ..................................................................        \n \n \n";
        logo = temp.Split('\n');
        if (!PlayerPrefs.HasKey("language"))
        {
            if (SteamManager.Initialized)
            {
                if (SteamApps.GetCurrentGameLanguage().Equals("schinese"))
                    PlayerPrefs.SetInt("language", 1);
                else if (SteamApps.GetCurrentGameLanguage().Equals("tchinese"))
                    PlayerPrefs.SetInt("language", 2);
                else
                    PlayerPrefs.SetInt("language", 0);
            }
        }
        Language.language = PlayerPrefs.GetInt("language", 0);
        LanguageLocalization<string[]> localization = new LanguageLocalization<string[]>();
        localization.addLanguage(new string[]{
            "Last login: Sun Jan  NaN NaN:NaN:NaN\n",
            "Simulation Initializing...",
            "...",
            "...",
            "Unable to Fetch Time.",
            "Unable to Connect.",
            "1 Error, 692 Warnings.",
            ">>>",
            "Simulation Initialized.",
            "Simulation Starting.",
            "Type \"help\" for more information",
            "...",
            "...",
            (PlayerPrefs.GetInt("CatPostcards", 0) == 17 && PlayerPrefs.GetInt("GameWin", 0) == 1) ? "Why are you still here." : "..."
            }, 0);

        localization.addLanguage(new string[]{
            "上次登录: Sun Jan  NaN NaN:NaN:NaN\n",
            "仿真初始化...",
            "...",
            "...",
            "无法获取时间。",
            "无法连接。",
            "1 个错误，692 个警告。",
            ">>>",
            "仿真初始化结束",
            "仿真开始",
            "输入\"help\"以获取更多信息",
            "...",
            "...",
            (PlayerPrefs.GetInt("CatPostcards", 0) == 17 && PlayerPrefs.GetInt("GameWin", 0) == 1) ? "你怎么还在这。" : "..."
            }, 1);

        localization.addLanguage(new string[]{
            "上次登錄: Sun Jan NaN NaN:NaN:NaN\n",
            "仿真初始化...",
            "...",
            "...",
            "無法獲取時間。",
            "無法連接。",
            "1 個錯誤，692 個警告。",
            ">>>",
            "仿真初始化結束",
            "仿真開始",
            "輸入\"help\"以獲取更多信息",
            "...",
            "...",
            (PlayerPrefs.GetInt("CatPostcards", 0) == 17 && PlayerPrefs.GetInt("GameWin", 0) == 1) ? "你怎麼還在這。" : "..."
            }, 2);

        logIn = localization.getLanguage();
        pauseFor();

    }

    // Update is called once per frame
    void Update()
    {
        if (done)
            return;
        keyb.ActivateInputField();
        keyb.Select();
        if (waitTimer > 0)
        {
            waitTimer += Time.deltaTime;
            if(waitTimer > 4)
            {
                done = true;
                GameObject.Find("Door").GetComponent<Door>().provoke();
            }
            return;
        }
        if(typn || !keyb.text.Equals(""))
        {
            if(!typn)
            {
                typn = true;
                LanguageLocalization<string> localization = new LanguageLocalization<string>();
                localization.addLanguage("Keyboard Interrupt\n[ENTER] to resume\n", 0);
                localization.addLanguage("键盘中断\n[ENTER] => 恢复\n", 1);
                localization.addLanguage("鍵盤中斷\n[ENTER] => 恢復\n", 2);
                currTxt += localization.getLanguage();
                //currTxt += keyb.text + "\n";
                if(keyb.text.Equals("\n"))
                    keyb.text = "";
            }
            else if(keyb.text.IndexOf('\n') != -1)
            {
                typn = false;
                string requestedCommand = keyb.text.Substring(0, keyb.text.Length - 1);
                currTxt += keyb.text;
                keyb.text = "";
                currTxt += "\n";
                if (requestedCommand.Equals("help"))
                {
                    currTxt += "List of commands:\n";
                    currTxt += "help - List of Commands\n";
                    currTxt += "volume [int:0-100] - Set volume\n";
                    currTxt += "kill - Terminate Program\n";
                    currTxt += "wipe - Clear Save *WARNING*\n";
                    currTxt += "skip - Skip Simulation Bootup\n";
                    currTxt += "language - Set Language [int:{english=0}{简体中文=1}{繁体中文=2}]\n";
                }
                else if(requestedCommand.Equals("kill"))
                {
                    Application.Quit();
                }else if (requestedCommand.Equals("skip"))
                {
                    GameObject.Find("Door").GetComponent<Door>().provoke();
                }
                else if(requestedCommand.Equals("wipe"))
                {
                    currTxt += "Wiped\n";
                    PlayerPrefs.DeleteAll();
                }
                else if (requestedCommand.Split(' ')[0].Equals("language"))
                {
                    PlayerPrefs.SetInt("language", int.Parse(requestedCommand.Split(' ')[1]));
                    if (PlayerPrefs.GetInt("language", 0) < 0 || PlayerPrefs.GetInt("language", 0) >= Language.languageAmt)
                    {
                        PlayerPrefs.SetInt("language", 0);
                        currTxt += "Out of bounds. Resetting to english";
                    }else
                    {
                        Language.language = PlayerPrefs.GetInt("language", 0);
                        currTxt += "Language set to: " + PlayerPrefs.GetInt("language", 0);
                    }
                }
                else if(requestedCommand.Split(' ')[0].Equals("volume"))
                {
                    currTxt += "(volume was " + PlayerPrefs.GetInt("volume", 50) + ")\n";
                    PlayerPrefs.SetInt("volume", int.Parse(requestedCommand.Split(' ')[1]));
                    AudioListener.volume = PlayerPrefs.GetInt("volume", 50)/ 100.0f;
                }else
                {
                    currTxt += "Command {" + requestedCommand + "} was not found\nType \"help\" for more information";
                }
                currTxt += "\nResuming...\n";
                pauseFor(2.0f);
                //print(requestedCommand);
            }
            if (keyb.caretPosition < keyb.text.Length)
            {
                textComponent.text = currTxt + keyb.text.Substring(0, keyb.caretPosition) + blanking.ToString() + keyb.text.Substring(keyb.caretPosition + 1);
            }else
            {
                textComponent.text = currTxt + keyb.text + blanking.ToString();
            }
        }
        else
        {
            //typn = false;
            if (currNum > 50)
            {
                currTxt = "";
                string front = "";
                //print(simulationRepeatCounter);
                if(simulationRepeatCounter > 75)
                    for (int i = 0; i < simulationRepeatCounter-75; i++)
                        front += string.Format("{0:X}", Random.Range(0,16));
                for (int i = 0; i < 100; i++)
                    currTxt += "<color=red>Failed</color> >>> Simulation 0x" + front + string.Format("{0:X}", currNum + i) + "\n";
                currNum = (int)(1.1f * currNum);
                simulationRepeatCounter++;
                if (currNum <= 50)
                {
                    textComponent.alignment = TextAnchor.MiddleCenter;
                    currTxt = "<color=#66ff66ff>Success</color>";//\n[Loading]\n[...]\n[...]\n";
                    waitTimer = 1;
                    //pauseFor(100);
                    //currTimer = 0;
                    //SceneManager.LoadScene("Room");
                }
            }
            else
            {
                if (currTimer > pauseSeconds)
                {
                    if (logoIdx < logo.Length)
                    {
                        currTxt += logo[logoIdx] + "\n";
                        logoIdx++;
                        pauseFor(Random.Range(0.0f, 0.1f));
                    }
                    else if (logInIdx < logIn.Length)
                    {
                        currTxt += logIn[logInIdx] + "\n";
                        logInIdx++;
                        pauseFor();
                    }
                    else
                    {
                        currTxt += "<color=red>Failed</color> >>> Simulation 0x" + string.Format("{0:X}", currNum) + "\n";
                        currNum++;
                        if (currNum < 50)
                            pauseFor(1.0f / (currNum * 2));
                    }
                    currTimer = 0;
                }
                currTimer += Time.deltaTime;
            }
            textComponent.text = currTxt + blanking.ToString();
        }
    }
    public void pauseFor(float seconds) => pauseSeconds = seconds;
    public void pauseFor() => pauseFor(Random.Range(0.0f, 1.0f));
}
