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

    [SerializeField]
    GameObject cantFuckingFindIt;

    [SerializeField]
    GameObject shit;

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

    void Awake()
    {
        //print(PlayerPrefs.HasKey("volume"));
        //if (!PlayerPrefs.HasKey("volume"))
        //    PlayerPrefs.SetInt("volume", 50);
        //DontDestroyOnLoadManager.becomeMortal();
        //AudioListener.volume = PlayerPrefs.GetInt("volume", 50)/100f;
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
                if (SteamApps.GetCurrentGameLanguage().Equals("thai"))
                    PlayerPrefs.SetInt("language", 1);
                else if (SteamApps.GetCurrentGameLanguage().Equals("french"))
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
            "...",
            "...",
            "Type \"help\" for more information",
            "Type \"help\" for more information",
            "Type \"help\" for more information",
            "...",
            "...",
            (PlayerPrefs.GetInt("CatPostcards", 0) == 17 && PlayerPrefs.GetInt("GameWin", 0) == 1) ? "Why are you still here." : "..."
            }, 0);

        localization.addLanguage(new string[]{
            "เข้าสู่ระบบครั้งล่าสุด: Sun Jan  NaN NaN:NaN:NaN\n",
            "กำลังเริ่มต้นการจำลองสถานการณ์...",
            "...",
            "...",
            "ไม่สามารถตรวจสอบเวลาได้",
            "ไม่สามารถเชื่อมต่อได้",
            "1 ข้อผิดพลาด 692 คำเตือน",
            ">>>",
            "กำลังเริ่มต้นการจำลองสถานการณ์",
            "กำลังเริ่มสถานการณ์จำลอง",
            "...",
            "...",
            "พิมพ์ \"help\" เพื่อเรียนรู้เพิ่มเติม",
            "พิมพ์  \"help\" เพื่อเรียนรู้เพิ่มเติม",
            "พิมพ์  \"help\" เพื่อเรียนรู้เพิ่มเติม",
            "...",
            "...",
            (PlayerPrefs.GetInt("CatPostcards", 0) == 17 && PlayerPrefs.GetInt("GameWin", 0) == 1) ? "ทำไมคุณยังอยู่ที่นี่" : "..."
            }, 1);

        localization.addLanguage(new string[]{
            "Dernière connexion: Sun Jan Nan Nan:Nan:Nan\n",
            "Initialization de la simulation...",
            "...",
            "...",
            "Impossible de Récupérer le Temps",
            "Impossible se connecter",
            "1 Erreur, 692 Avertissements.",
            ">>>",
            "Simulation Initialisée",
            "Démarrage de la Simulation",
            "...",
            "...",
            "Tapez \"help\" pour plus d'informations",
            "Tapez \"help\" pour plus d'informations",
            "Tapez \"help\" pour plus d'informations",
            "...",
            "...",
            (PlayerPrefs.GetInt("CatPostcards", 0) == 17 && PlayerPrefs.GetInt("GameWin", 0) == 1) ? "Pourquoi es-tu toujours là." : "..."
            }, 2);

        logIn = localization.getLanguage();
        pauseFor();

    }

    // Update is called once per frame
    void Update()
    {
        if(cantFuckingFindIt.activeSelf)
            return;
        shit.SetActive(true);
        Camera.main.backgroundColor = Color.black;

        if (Input.GetKey(KeyCode.Escape))
            SceneManager.LoadScene("BudgetTerminal");
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
                shit.GetComponent<Door>().provoke();
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
                localization.addLanguage("ถูกขัดจังหวะโดยแป้นพิมพ์\n[ENTER] เพื่อดำเนินการต่อ\n", 1);
                localization.addLanguage("Interruption du Clavier\n[ENTER] pour reprendre\n", 2);
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
                    LanguageLocalization<string[]> localization = new LanguageLocalization<string[]>();
                    localization.addLanguage(new string[] {
                        "List of commands:",
                        "List of Commands",
                        "Set volume",
                        "Terminate Program",
                        "Clear Save *DANGER*",
                        "Skip Simulation Bootup",
                        "Set Language",
                        "Update Achievements on Server",
                        "Prints out tips"
                        }, 0);
                    localization.addLanguage(new string[] {
                        "รายการคำสั่ง:",
                        "รายการคำสั่ง",
                        "ตั้งค่าระดับเสียง",
                        "บังคับปิดโปรแกรม",
                        "ล้างเกมที่บันทึกไว้ *อันตราย*",
                        "ข้ามการจำลองการทำงานของคอมพิวเตอร์",
                        "ตั้งค่าภาษา",
                        "อัปเดตความสำเร็จบนเซิร์ฟเวอร์",
                        "พิมพ์เคล็ดลับในการเล่น"
                        }, 1);
                    localization.addLanguage(new string[] {
                        "Liste des commandes:",
                        "Liste des Commandes",
                        "Rélger le volume",
                        "Programme du Terminal",
                        "Nettoyer la Sauvegarde *DANGER*",
                        "Passer le Démarrage de la Simulation",
                        "Régler la Langue",
                        "Actualiser les Succès sur le Serveur",
                        "Imprimer les astuces"
                        }, 2);
                    string[] temp = localization.getLanguage();
                    currTxt += temp[0] + "\n";
                    currTxt += "help - " + temp[1] + "\n";
                    currTxt += "volume [0-100] - " + temp[2] + "\n";
                    currTxt += "kill - " + temp[3] + "\n";
                    currTxt += "wipe - " + temp[4] + "\n";
                    currTxt += "skip - " + temp[5] + "\n";
                    currTxt += "push - " + temp[7] + "\n";
                    currTxt += "tips - " + temp[8] + "\n";
                    currTxt += "\nlanguage - " + temp[6] + ":\n{english=0}\n{ภาษาไทย=1} by Tidamard Malaithong\n{français=2} by Dorian\n";
                }
                else if(requestedCommand.Equals("kill"))
                {
                    Application.Quit();
                }else if (requestedCommand.Equals("skip"))
                {
                    GameObject.Find("Door").GetComponent<Door>().provoke();
                }
                else if (requestedCommand.Equals("push"))
                {
                    LanguageLocalization<string> localization = new LanguageLocalization<string>();
                    localization.addLanguage("Synced", 0);
                    localization.addLanguage("ซิงค์แล้ว", 1);
                    localization.addLanguage("Synchronisé", 2);
                    currTxt += localization.getLanguage() + "\n";
                    if(SteamManager.Initialized)
                    {
                        if (PlayerPrefs.GetInt("FIRST_DEATH", 0) == 1)
                            SteamUserStats.SetAchievement("FIRST_DEATH");
                        if (PlayerPrefs.GetInt("NO_POINT", 0) == 1)
                            SteamUserStats.SetAchievement("NO_POINT");
                        if (PlayerPrefs.GetInt("END", 0) == 1)
                            SteamUserStats.SetAchievement("END");
                        if (PlayerPrefs.GetInt("SINGLE", 0) == 1)
                            SteamUserStats.SetAchievement("SINGLE");
                        if (PlayerPrefs.GetInt("GOOD_BYE", 0) == 1)
                            SteamUserStats.SetAchievement("GOOD_BYE");
                        if (PlayerPrefs.GetInt("RAIN", 0) == 1)
                            SteamUserStats.SetAchievement("RAIN");
                        SteamUserStats.StoreStats();
                    }
                }
                else if (requestedCommand.Equals("ASDFasdf"))
                {
                    PlayerPrefs.SetInt("CatPostcards", 16);
                }
                else if (requestedCommand.Equals("wipe"))
                {
                    LanguageLocalization<string> localization = new LanguageLocalization<string>();
                    localization.addLanguage("Wiped", 0);
                    localization.addLanguage("ล้างแล้ว", 1);
                    localization.addLanguage("Nettoyé", 2);
                    currTxt += localization.getLanguage() + "\n";
                    PlayerPrefs.DeleteAll();
                }else if (requestedCommand.Equals("tips"))
                {
                    LanguageLocalization<string[]> tipsLo = new LanguageLocalization<string[]>();
                    tipsLo.addLanguage(new string[] {
                    "Learn how to live from trial and error. I will assist you with more information, each time you see me.",
                    "Make sure you go to school. Otherwise your satisfaction will decrease very fast.",
                    "Bouncing Icons indicate the task to go much faster.",
                    "The knife will increase your Instantaneous Happiness, but decrease happiness.",
                    "Talking to someone constantly will better positive effects they have on you.",
                    "Death Tolerance is influenced by Instantaneous Happiness.",
                    "Happiness is heavily influenced by Satisfaction.",
                    "Death is dependent only on Happiness and Death Tolerance.",
                    "Your Art, Coding, Friendship and School values influence Satisfaction.",
                    "Death Tolerance is somewhat influenced by Happiness.",
                    "Your Art, Coding, Friendship and School values decrease naturally.",
                    "Instantaneous Happiness is influenced by Happiness.",
                    "Playing Games and Watching Videos can increase Instantatious Happiness.",
                    "Listening to music will exacerbate Instantaneous Happiness.",
                    "The amount of sleep you get effects your satisfaction.",
                    "Happiness is influenced by Happiness Instantaneous Happiness is influnced by Instantaneous Happiness.\nSatisfaction is influenced by Satisfaction. Death Tolerance is influenced by Death Tolerance"
                    }, 0);

                    tipsLo.addLanguage(new string[] {
                    "เรียนรู้การใช้ชีวิตจากการลองผิดลองถูก เลาจะช่วยให้ข้อมูลเพิ่มเติมทุกครั้งที่นายเจอเลานะ",
                    "เอาให้แน่ใจว่านายเข้าเรียนเสมอ ไม่งั้นความพึงพอใจของนายจะลดลงอย่างรวดเร็ว",
                    "ไอค่อนที่เด้งบ่งบอกว่าการใช้งานมันจะทำให้เวลาเดินเร็วขึ้น",
                    "การใช้มีดจะทำให้เพิ่มความสุขชั่วขณะ แต่จะลดความสุขลง",
                    "การพูดคุยกับใครสักคนอย่างต่อเนื่อง จะทำให้พวกเขามองนายในแง่บวกมากขึ้น",
                    "ความอดทนต่อความตายนั้นได้รับอิทธิพลมาจากความสุขชั่วขณะ",
                    "ความสุขนั้นได้รับอิทธิพลเป็นอย่างมากจากความพึงพอใจ",
                    "ความตายนั้นขึ้นอยู่กับความสุขและความอดทนต่อความตายเท่านั้น",
                    "ค่าความสามารถด้านศิลปะ ด้านการเขียนโค้ด มิตรภาพ และการเข้าเรียน มีอิทธิพลต่อความพึงพอใจ",
                    "ความอดทนต่อความตายนั้นค่อนข้างได้รับอิทธิพลจากความสุข",
                    "ค่าความสามารถด้านศิลปะ ด้านการเขียนโค้ด มิตรภาพ และการเข้าเรียน นั้นลดลงอย่างธรรมชาติเป็นปกติ",
                    "ความสุขชั่วขณะนั้นได้รับอิทธิพลจากความสุข",
                    "การเล่นเกมและการดูวิดิโอสามารถเพิ่มความสุขชั่วขณะได้",
                    "การฟังเพลงนั้นจะทำให้ความสุขชั่วขณะรุนแรงขึ้น",
                    "ปริมาณการหลับที่นายได้รับนั้นส่งผลต่อความพึงพอใจของนาย",
                    "ความสุขได้รับอิทธิพลจากความสุข ความสุขชั่วขณะได้รับอิทธิพลจากความสุขชั่วขณะ\nความพึงพอใจได้รับอิทธิพลจากความพึงพอใจ ความอดทนต่อความตายได้รับอิทธิพลจากความอดทนต่อความตาย"
                    }, 1);

                    tipsLo.addLanguage(new string[] {
                    "Apprends comment rester en vie au fil des essais et des erreurs. Je t'aiderais avec des informations, à chaque fois que tu me verras.",
                    "Sois sûr d'aller à l'école. Sinon ta satisfaction va baisser très rapidement.",
                    "Les icônes qui sautillent indiquent les tâches qui se font plus rapidement.",
                    "Le couteau va accroître ton Bonheur Instantané, mais baisser le Bonheur.",
                    "Parler à quelqu'un de manière répétée va améliorer l'effet positif que cela a sur toi.",
                    "La Tolérance à la Mort est influencée par le Bonheur Instantané.",
                    "Le Bonheur est fortement influencé par la Satisfaction.",
                    "La Mort dépend uniquement du Bonheur et du Bonheur instantané.",
                    "La valeur d'Art, Codage, Amitié et École baisse naturellement.",
                    "Le Bonheur Instantané est influencé par le Bonheur.",
                    "Jouer à des jeux et regarder des vidéos peut accroître le Bonheur Instantané.",
                    "Écouter de la musique exacerbe fortement le Bonheur Instantané.",
                    "La quantité de sommeil que tu parviens à avoir affecte ta satisfaction.",
                    "Le Bonheur est influencé par le Bonheur, le Bonheur Instantané est influencé par le Bonheur instantané.\nLa Satisfaction est influencée par la Satisfaction. La Tolérance à la Mort est influencée par la Tolérance à la Mort"
                    }, 2);
                    for (int i = 0; i < PlayerPrefs.GetInt("CatPostcards", 0); i++)
                        if (i < tipsLo.getLanguage().Length)
                            currTxt += (i+1) + ": " + tipsLo.getLanguage()[i] + "\n";
                }
                else if (requestedCommand.Split(' ')[0].Equals("language"))
                {
                    PlayerPrefs.SetInt("language", int.Parse(requestedCommand.Split(' ')[1]));
                    if (PlayerPrefs.GetInt("language", 0) < 0 || PlayerPrefs.GetInt("language", 0) >= Language.languageAmt)
                    {
                        PlayerPrefs.SetInt("language", 0);
                        Language.language = PlayerPrefs.GetInt("language", 0);
                        LanguageLocalization<string> localization = new LanguageLocalization<string>();
                        localization.addLanguage("Out of bounds. Resetting to english", 0);
                        localization.addLanguage("นอกเหนือขอบเขต คืนค่าเป็นภาษาอังกฤษ", 1);
                        localization.addLanguage("Hors Limites. Réinitialisation à Anglais", 2);
                        currTxt += localization.getLanguage() + "\n";
                    }else
                    {
                        Language.language = PlayerPrefs.GetInt("language", 0);
                        LanguageLocalization<string> localization = new LanguageLocalization<string>();
                        localization.addLanguage("Language set to: ", 0);
                        localization.addLanguage("ตั้งค่าภาษาเป็น: ", 1);
                        localization.addLanguage("Langue réglée sur: ", 2);
                        currTxt += localization.getLanguage() + PlayerPrefs.GetInt("language", 0);
                    }
                }
                else if(requestedCommand.Split(' ')[0].Equals("volume"))
                {
                    LanguageLocalization<string> localization = new LanguageLocalization<string>();
                    localization.addLanguage("volume: ", 0);
                    localization.addLanguage("ระดับเสียง: ", 1);
                    localization.addLanguage("Volume: ", 2);
                    currTxt += localization.getLanguage() + PlayerPrefs.GetInt("volume", 50) + " => " + (int.Parse(requestedCommand.Split(' ')[1])) + "\n";
                    PlayerPrefs.SetInt("volume", int.Parse(requestedCommand.Split(' ')[1]));
                    AudioListener.volume = PlayerPrefs.GetInt("volume", 50)/ 100.0f;
                }else
                {
                    LanguageLocalization<string> localization = new LanguageLocalization<string>();
                    localization.addLanguage("Command {" + requestedCommand + "} was not found\nType \"help\" for more information", 0);
                    localization.addLanguage("คำสั่ง {" + requestedCommand + "} ไม่สามารถตรวจสอบได้\nพิมพ์ \"help\" เพื่อข้อมูลเพิ่มเติม", 1);
                    localization.addLanguage("La commande {" + requestedCommand + "} n'a pas été trouvée\nTappez \"help\" pour plus d'information", 3);
                    currTxt += localization.getLanguage() + "\n";
                }
                LanguageLocalization<string> language = new LanguageLocalization<string>();
                language.addLanguage("Resuming", 0);
                language.addLanguage("กลับสู่การทำงาน", 1);
                language.addLanguage("Reprise", 2);
                currTxt += "\n" + language.getLanguage() + "...\n";
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
                LanguageLocalization<string> language1 = new LanguageLocalization<string>();
                language1.addLanguage("Failed", 0);
                language1.addLanguage("ล้มเหลว", 1);
                language1.addLanguage("Échec", 2);
                currTxt = "";
                string front = "";
                //print(simulationRepeatCounter);
                if(simulationRepeatCounter > 75)
                    for (int i = 0; i < simulationRepeatCounter-75; i++)
                        front += string.Format("{0:X}", Random.Range(0,16));
                for (int i = 0; i < 100; i++)
                    currTxt += "<color=red>" + language1.getLanguage() + "</color> >>> Simulation 0x" + front + string.Format("{0:X}", currNum + i) + "\n";
                currNum = (int)(1.1f * currNum);
                simulationRepeatCounter++;
                if (currNum <= 50)
                {
                    LanguageLocalization<string> language2 = new LanguageLocalization<string>();
                    language2.addLanguage("Success", 0);
                    language2.addLanguage("สำเร็จ", 1);
                    language2.addLanguage("Succès", 2);
                    textComponent.alignment = TextAnchor.MiddleCenter;
                    currTxt = "<color=#66ff66ff>" + language2.getLanguage() + "</color>\nGoal: Make it to day 9. Past the rainy day.";//\n[Loading]\n[...]\n[...]\n";
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
                        LanguageLocalization<string> language1 = new LanguageLocalization<string>();
                        language1.addLanguage("Failed", 0);
                        language1.addLanguage("ล้มเหลว", 1);
                        language1.addLanguage("Échec", 2);
                        currTxt += "<color=red>" + language1.getLanguage() + "</color> >>> Simulation 0x" + string.Format("{0:X}", currNum) + "\n";
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
    public void pauseFor(float seconds) => pauseSeconds = seconds/4;
    public void pauseFor() => pauseFor(Random.Range(0.0f, 1.0f));
}
