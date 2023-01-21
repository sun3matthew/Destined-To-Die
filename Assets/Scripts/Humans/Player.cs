using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Steamworks;

public class Player : Human
{
    public HundredBound[] emotions;//happy, happyImp, satisfaction, mentalEnergy, deathTolerance
    public HundredBound[] abilities;//art, coding, education, friendship

    private HundredBound[] emotionsPrev;//happy, happyImp, satisfaction, mentalEnergy, deathTolerance
    private HundredBound[] abilitiesPrev;//art, coding, education, friendship

    public float hoursOfSleep;
    public int mood;

    TimeDay timeDayObj;

    [SerializeField]
    private GameObject cat;

    private Cutscene cutscene;
    private TextCutscreen textCutscreen;
    private SystemTime systemTime;
    private GameObject computerWindow;

    public int falseDay;

    private int prio;
    private int psAmt;

    public bool wentToClass;
    public bool wentToPractice;
    public bool wentToBed;

    public int talkedToAmt;

    public float happySmooth;
    public float graySmooth;

    private string[] statsTranslated;

    [SerializeField]
    private GameObject textPref;

    protected override void Start()
    {
        FadeAwayText.numTexts = 0;

        timeDayObj = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();
        cutscene = GameObject.Find("Cutscene(Clone)").GetComponent<Cutscene>();
        textCutscreen = GameObject.Find("TextCutscene(Clone)").GetComponent<TextCutscreen>();
        systemTime = GameObject.Find("ComputerB(Clone)").transform.GetChild(0).GetChild(1).GetComponent<SystemTime>();
        psAmt = PlayerPrefs.GetInt("CatPostcards", 0);
        computerWindow = GameObject.Find("ComputerB(Clone)").transform.GetChild(0).gameObject;

        LanguageLocalization<string[]> localization = new LanguageLocalization<string[]>();
        localization.addLanguage(new string[] {"AMOUNT OF SLEEP", "HAPPY", "INSTANTANEOUS HAPPY", "SATISFACTION", "DEATH TOLERANCE", "ART", "CODE", "SCHOOL", "FRIEND", "WENT TO CLASS"}, 0);
        localization.addLanguage(new string[] { "ปริมาณการนอนหลับ", "ความสุข", "ความสุขชั่วขณะ", "ความพึงพอใจ", "ความอดทนต่อความตาย", "ศิลปะ", "การเขียนโค้ด", "การเข้าเรียน", "เพื่อน", "การเข้าคาบเรียน"}, 1);
        localization.addLanguage(new string[] { "QUANTITÉ DE SOMMEIL", "BONHEUR", "BONHEUR INSTANTANÉ", "SATISFACTION", "TOLÉRANCE À LA MORT", "ART", "CODE", "ÉCOLE", "AMIS", "EST ALLÉ EN COURS"}, 2);
        statsTranslated = localization.getLanguage();

        emotions = new HundredBound[5];
        abilities = new HundredBound[4];
        emotionsPrev = new HundredBound[5];
        abilitiesPrev = new HundredBound[4];

        for (int i = 0; i < emotions.Length; i++){
            if(i == 3){
                emotions[i] = new HundredBound(statsTranslated[0], textPref);
            }else if(i == 4){
                emotions[i] = new HundredBound(statsTranslated[4], textPref);
            }else{
                emotions[i] = new HundredBound(statsTranslated[i + 1], textPref);
            }
        }
        for (int i = 0; i < abilities.Length; i++)
            abilities[i] = new HundredBound(statsTranslated[i + emotions.Length], textPref);

        for (int i = 0; i < emotions.Length; i++)
            emotions[i].setValue(Random.Range(-10, 5));
        for (int i = 0; i < abilities.Length; i++)
            abilities[i].setValue(Random.Range(-10, 10));

        for (int i = 0; i < emotionsPrev.Length; i++)
            emotionsPrev[i] = new HundredBound(statsTranslated[i], textPref);
        for (int i = 0; i < abilitiesPrev.Length; i++)
            abilitiesPrev[i] = new HundredBound(statsTranslated[i + emotions.Length], textPref);

        for (int i = 0; i < emotionsPrev.Length; i++)
            emotionsPrev[i].setValue(emotions[i].getValue());
        for (int i = 0; i < abilitiesPrev.Length; i++)
            abilitiesPrev[i].setValue(abilities[i].getValue());

        wentToClass = false;
        wentToPractice = false;
        wentToBed = false;
        hoursOfSleep = 8;
        falseDay = 0;
        emotions[3].setValue(Random.Range(60, 80));
        base.Start();

        //PlayerPrefs.SetInt("CatPostcards", 14);
    }
    // Update is called once per frame
    protected override void Update()
    {
        if (wentToBed && timeDayObj.timeDay > 7 && timeDayObj.timeDay < 8)
            wentToBed = false;
        if(!wentToBed && timeDayObj.timeDay > 4.5 && timeDayObj.timeDay < 5 && GameObject.Find("BedB") != null)
            GameObject.Find("BedB").GetComponent<Bed>().clickedOn(true);
        happySmooth += ((emotions[1].getValue() - happySmooth) / 10) * Time.deltaTime;
        graySmooth += ((emotions[4].getValue() - graySmooth) / 10) * Time.deltaTime;
        if (cutsceneDone() && !(computerWindow != null && computerWindow.activeSelf))
        {
            //if no keys are pressed, you are not moving, otherwise is somthing is just pressed, direction to the latest one. But if a key is released then prio is reasined to a new one
            if (!(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow)))
                prio = 0;
            else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                prio = 1;
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
                prio = 2;
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
                prio = 3;
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
                prio = 4;
            else if ((Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow)))
            {
                if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                    prio = 1;
                else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                    prio = 2;
                else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                    prio = 3;
                else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                    prio = 4;
            }
        }
        else
        {
            prio = 0;
        }
        moveCmd();
        base.Update();
    }

    public void resetDay()
    {
        hoursOfSleep = 24.0f + 5.5f - timeDayObj.timeDay;
        if (hoursOfSleep > 24)
            hoursOfSleep -= 24;

        for (int i = 0; i < emotions.Length; i++)
            emotions[i].changeValue((emotions[i].getValue() - 50) < 0 ? (emotions[i].getValue() - 50) * 0.1f : 0);//emotions by snowball

        for (int i = 0; i < emotions.Length; i++)
            emotions[i].changeValue(timeDayObj.day * -4);//emotions by "Intentional Game Design'


        emotions[4].changeValue(emotions[1].getValue() < 0 ? emotions[1].getValue() * 4f : 0);//deathTolerance by depression handling - pre reset

        emotions[2].changeValue((emotions[3].getValue()-40) * 0.1f);//satisfaction by Mental energy - slow

        emotions[3].setValue(((hoursOfSleep * 12f) * 2) - 110);//Mental energy by hours of sleep

        if (!wentToClass)//parents
        {
            emotions[2].changeValue(-70);//happy by class-skip
            emotions[1].changeValue(-30);
            emotions[2].changeValue(abilities[2].getValue() < 0 ? abilities[2].getValue() : 0);//happy by school ability
        }

        if (!wentToPractice)//guilt
            emotions[4].changeValue(-50);

        for (int i = 0; i < abilities.Length; i++)
        {
            abilities[i].changeValue(Random.Range(-20, 0));//ability deteriorate
            emotions[2].changeValue(abilities[i].getValue() * 0.4f);//satisfaction by abilities
        }

        emotions[0].changeValue(emotions[2].getValue() * 0.7f);//happy by satisfaction
        emotions[4].changeValue(emotions[0].getValue() * 0.25f);//deathTolerance by happy

        emotions[0].changeValue(timeDayObj.day * -3);//happy by "Intentional Game Design"

        emotions[1].changeValue(emotions[0].getValue());//happyImp by happy
        emotions[1].changeValue(timeDayObj.day * -6);//happyImp by "Intentional Game Design'

        if(psAmt < 3)
            for (int i = 0; i < emotions.Length; i++)
                emotions[i].changeValue(timeDayObj.day * -1);//emotions by "Intentional Game Design'
        if (psAmt < 9)
            for (int i = 0; i < emotions.Length; i++)
                emotions[i].changeValue(timeDayObj.day * -1);//emotions by "Intentional Game Design'
        if (psAmt < 12)
            for (int i = 0; i < emotions.Length; i++)
                emotions[i].changeValue(timeDayObj.day * -1);//emotions by "Intentional Game Design'
        if (psAmt < 16)
            for (int i = 0; i < emotions.Length; i++)
                emotions[i].changeValue(timeDayObj.day * -1);//emotions by "Intentional Game Design'

        if (PlayerPrefs.GetInt("Difficulty" , 1) == 0)
            for (int i = 0; i < emotions.Length; i++)
                emotions[i].changeValue(timeDayObj.day * -3);//emotions by "Intentional Game Design'
        if (PlayerPrefs.GetInt("Difficulty" , 1) == 1)
            for (int i = 0; i < emotions.Length; i++)
                emotions[i].changeValue(timeDayObj.day * -1);//emotions by "Intentional Game Design'

        wentToClass = false;
        wentToPractice = false;
        wentToBed = true;

        talkedToAmt = 0;

        Classmate[] classmates = FindObjectsOfType<Classmate>();
        for (int i = 0; i < classmates.Length; i++)
            classmates[i].talkedTo = false;

        systemTime.falseDay++;
        falseDay++;
        timeDayObj.rollTime(5.5f);

        string outputText = statsTranslated[0] + ": " + emotions[3].getIntValue() + "\n\n";

        if (psAmt >= 9)
            outputText += statsTranslated[1] + ": " + emotionsPrev[0].getIntValue() + " => " + emotions[0].getIntValue() + "\n";
        else if (psAmt >= 1)
            outputText += statsTranslated[1] + ": " + (emotions[0].getValue() - emotionsPrev[0].getValue() > 0 ? "+" : "-") + "\n";

        if (psAmt >= 10)
            outputText += statsTranslated[2] + ": " + emotionsPrev[1].getIntValue() + " => " + emotions[1].getIntValue() + "\n";
        else if (psAmt >= 2)
            outputText += statsTranslated[2] + ": " + (emotions[1].getValue() - emotionsPrev[1].getValue() > 0 ? "+" : "-") + "\n";

        if (psAmt >= 11)
            outputText += statsTranslated[3] + ": " + emotionsPrev[2].getIntValue() + " => " + emotions[2].getIntValue() + "\n";
        else if (psAmt >= 3)
            outputText += statsTranslated[3] + ": " + (emotions[2].getValue() - emotionsPrev[2].getValue() > 0 ? "+" : "-") + "\n";

        if (psAmt >= 12)
            outputText += statsTranslated[4] + ": " + emotionsPrev[4].getIntValue() + " => " + emotions[4].getIntValue() + "\n\n";
        else if (psAmt >= 4)
            outputText += statsTranslated[4] + ": " + (emotions[4].getValue() - emotionsPrev[4].getValue() > 0 ? "+" : "-") + "\n\n";


        if (psAmt >= 13)
            outputText += statsTranslated[5] + ": " + abilitiesPrev[0].getIntValue() + " => " + abilities[0].getIntValue() + "\n";
        else if (psAmt >= 5)
            outputText += statsTranslated[5] + ": " + (abilities[0].getValue() - abilitiesPrev[0].getValue() > 0 ? "+" : "-") + "\n";

        if (psAmt >= 14)
            outputText += statsTranslated[6] + ": " + abilitiesPrev[1].getIntValue() + " => " + abilities[1].getIntValue() + "\n";
        else if (psAmt >= 6)
            outputText += statsTranslated[6] + ": " + (abilities[1].getValue() - abilitiesPrev[1].getValue() > 0 ? "+" : "-") + "\n";

        if (psAmt >= 15)
            outputText += statsTranslated[7] + ": " + abilitiesPrev[2].getIntValue() + " => " + abilities[2].getIntValue() + "\n";
        else if (psAmt >= 7)
            outputText += statsTranslated[7] + ": " + (abilities[2].getValue() - abilitiesPrev[2].getValue() > 0 ? "+" : "-") + "\n";

        if (psAmt >= 16)
            outputText += statsTranslated[8] + ": " + abilitiesPrev[3].getIntValue() + " => " + abilities[3].getIntValue();
        else if (psAmt >= 8)
            outputText += statsTranslated[8] + ": " + (abilities[3].getValue() - abilitiesPrev[3].getValue() > 0 ? "+" : "-");

        for (int i = 0; i < emotionsPrev.Length; i++)
            emotionsPrev[i].setValue(emotions[i].getValue());
        for (int i = 0; i < abilitiesPrev.Length; i++)
            abilitiesPrev[i].setValue(abilities[i].getValue());

        Cutscene.cutscene(emotions[0].getIntValue() / 10);
        Cutscene.cutscene(outputText);

        if (emotions[0].getValue() < -80 && emotions[4].getValue() < -80)
        {
            if (PlayerPrefs.GetInt("FIRST_DEATH", 0) == 0)
            {
                PlayerPrefs.SetInt("FIRST_DEATH", 1);
                if (SteamManager.Initialized)
                {
                    SteamUserStats.SetAchievement("FIRST_DEATH");
                    SteamUserStats.StoreStats();
                }
            }
            if (PlayerPrefs.GetInt("CatPostcards", 0) >= 7 && PlayerPrefs.GetInt("NO_POINT", 0) == 0)
            {
                PlayerPrefs.SetInt("NO_POINT", 1);
                if (SteamManager.Initialized)
                {
                    SteamUserStats.SetAchievement("NO_POINT");
                    SteamUserStats.StoreStats();
                }
            }
            GameObject.Find("Music(Clone)").GetComponent<AudioSource>().pitch = -0.6f;
            death();
            return;
        }
        if ((timeDayObj.day == 7 && timeDayObj.timeDay > 7) || timeDayObj.day >= 8)//not the start of day 7, or it's 8
        {
            Debug.Log("fuck: " + PlayerPrefs.GetInt("CatPostcards", 0));
            PlayerPrefs.SetInt("GameWin", 1);
            if (PlayerPrefs.GetInt("CatPostcards", 0) >= 17)
            {
                if (PlayerPrefs.GetInt("END", 0) == 0)
                {
                    PlayerPrefs.SetInt("END", 1);
                    if (SteamManager.Initialized)
                    {
                        SteamUserStats.SetAchievement("END");
                        SteamUserStats.StoreStats();
                    }
                }
                DontDestroyOnLoadManager.becomeMortal();
                DontDestroyOnLoadManager.endType = true;
                SceneManager.LoadScene("Win");
            }
            else
                death();
            return;
        }

        printEmotions();
        printAbilities();
    }

    public bool cutsceneDone() => cutscene.inactive() && textCutscreen.inactive();

    [ContextMenu("Death")]
    private void death()
    {
        Instantiate(cat, new Vector2(-1.833f, -1.231f), Quaternion.identity);
        DontDestroyOnLoad(new GameObject("DeathDayTransfer", typeof(DeathDayTransfer)).GetComponent<DeathDayTransfer>().setDay(timeDayObj.day));
        Destroy(GameObject.Find("Door"));
        Destroy(GameObject.Find("ComputerB(Clone)"));
        Destroy(GameObject.Find("WindowB").transform.GetChild(0).gameObject);
        Interactable[] interactables = FindObjectsOfType<Interactable>();
        for (int i = 0; i < interactables.Length; i++)
            interactables[i].gameObject.SetActive(false);
        for (int i = 0; i < emotions.Length; i++)
            emotions[i] = new HundredBound(statsTranslated[i], textPref);
        timeDayObj.fastFowards(100000);
    }

    protected void moveCmd()
    {
        if (prio == 0) rb.velocity = new Vector2();
        else if (prio == 1) rb.velocity = new Vector2(speed, speed / 2);
        else if (prio == 2) rb.velocity = new Vector2(-speed, speed / 2);
        else if (prio == 3) rb.velocity = new Vector2(-speed, -speed / 2);
        else if (prio == 4) rb.velocity = new Vector2(speed, -speed / 2);

        an.SetBool("Move", prio != 0);
        if(prio == 1)
        {
            an.SetFloat("Move Y", 1);
            an.SetFloat("Move X", 0);
        }
        else if(prio == 2)
        {
            an.SetFloat("Move Y", 0);
            an.SetFloat("Move X", -1);
        }
        else if (prio == 3)
        {
            an.SetFloat("Move Y", -1);
            an.SetFloat("Move X", 0);
        }
        else if (prio == 4)
        {
            an.SetFloat("Move Y", 0);
            an.SetFloat("Move X", 1);
        }
    }
    [ContextMenu("Print Emotions")]
    void printEmotions()
    {
        for(int i = 0; i < emotions.Length; i++)
            print("Emotion " + i + ": " + emotions[i].getValue());
    }
    [ContextMenu("Print Abilities")]
    void printAbilities()
    {
        for (int i = 0; i < abilities.Length; i++)
            print("Ability " + i + ": " + abilities[i].getValue());
    }


    public static Player player() => GameObject.Find("Player(Clone)").GetComponent<Player>();
}
