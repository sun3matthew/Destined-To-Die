using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using Steamworks;

public class Cutscene : MonoBehaviour
{
    private string[][] cutsceneRefs = {
        new string[]{"CutHead", "BloodMouth", "WristBloodDrip", "BloodFlower", "ReachOutBloodWrist", "WristCut", "WristCuttingLine", "AngelOfDeath", "BurnWrist", "AbCutScarPullShow", "AbCutTwoHandShow", "FallFlipStart", "FallSoftBody", "BloodTallyList", "DrownHeadUpDown", "DrownReachUp", "FingerGunShoulder", "FingerGunWristHold"},//-10
        new string[]{"GunDeath", "CutKnife", "ReachOut", "FreshWoundBloodDrip", "WristDripDown", "BloodHandDrip", "StomachStab", "SmokeHandHoldTwoFinger", "SuicideLookDown", "BurnScar", "AbCutBellyButton", "FallFlatRotate", "FallHandReach", "FallOneKneeBent", "BloodTallyCrossOut", "FingerGunChin"},//-9
        new string[]{"KnifeNeck", "BloodyTissue", "BloodDripArm", "ArmBruises", "ReachOutBlood", "ReachOutHandHurt", "BloodWristDrip", "BurnFinger", "SmokeBlowOut", "SmokeHandMouth", "VomitSpillOutHand", "BurnBlister", "BloodTallyNewCut", "DrownHeadUpTilt", "DrownSplash", "FallDrown", "FingerGunHair"},//-8
        new string[]{"CryYell", "Pill", "BedConfusion", "WatchCut", "ChokeBloodNails", "HandOnBlood", "BloodButterfly", "PillowHugTwoHands", "EatLessScale", "VomitToiletSide", "HandReachOutHalfSleeve", "BurnWristSide", "BloodTallyFive", "DrownFlat", "DrownLegUp", "DrownTwoHand", "FingerGunPalmHold"},//-7
        new string[]{"Spiral", "SmileRip", "CutBleedScar", "ChokeBlood", "ReachOutFlatBlood", "WristCutSleeve", "BloodWristBruises", "PillowHugOneHand", "EatLessCutPea", "VomitHoldMouth", "VomitToiletTopDown", "AbCutScarShow", "DrownBigSplash", "DrownHandReach", "FingerGunBase", "FingerGunFace"},//-6
        new string[]{"BloodChoke", "ArmCutBlood", "BoxCutterWristCut", "HeadGrabHold", "FreshWristCutDrip", "HandGrabScar", "KnifeFallBloodDrip", "BurnCandle", "BurnLighterHold", "BurnLighterHoldFinger", "AbCutHandHold", "AbCutScarHandPull", "BloodTallyKnife", "FallCurlHug", "FingerGunTilt"},//-5
        new string[]{"Choke", "Rose", "CryArm", "BoxCutterBlood", "CryClench", "HandFallBed", "HandTogetherDown", "SleepHeadCrazy", "HeadDownKnee", "EatLessStomachPain", "WristGrabBloodHand", "ArmGrabHeadKnees", "AbCutHandPull", "DrownStraightTilt", "FakeSmileCrySilent", "ShowerHeadBack"},//-4
        new string[]{"Cry", "ShirtGrab", "BedCry", "LookDownSad", "BloodDripDownKnife", "CryBlueTiltHead", "HandsAroundLeg", "KnifeRaise", "BoxCutterBloodDripSpot", "ReachOutSlightClench", "AbCutKnifeKill", "FallDrownBent", "FakeSmileFinger", "ShowerBangsDown", "ShowerHeadLookDown"},//-3
        new string[]{"HeadDown", "CrySleeve", "LookDownSide", "BloodReachOutUp", "HandHeadSpock", "BloodFlowerGround", "EarbudsHandHold", "HeadphoneHandHold", "BurnLighterHoldThumb", "AbCutKnifeHold", "AbCutScarMouthHold", "FingerGunAfter", "ShowerHandDrip", "ShowerScream"},//-2
        new string[]{"SleepingPill", "CoverEar", "Hoodie", "Sleep", "CryHandsTwoHands", "CrySleeve2", "HandHeadEyeHair", "InstantNoodlesStack", "BurnMatch", "BurnMatchHold", "FallBendBack", "FallFullExtend", "FakeSmileCry", "ShowerHandWall", "ShowerHeadDown"},//-1
        new string[]{"LookUpSkyClouds", "UmbrellaHand", "FistClench", "HandHoldSelfComfort", "LayDownHeadDown", "HandFallSlightClench", "MoonCloud", "FakeSmileHand", "FakeSmileZipCry", "ShowerFaceBack", "ShowerHairDrip", "ShowerHandReach"},//0
        new string[]{"LookHorizon", "SadHandUpHair", "HandHoldGirlHead", "LoveTouchWater", "LoveUmbrella", "LoveHugWanted", "LoveHoldHug"},//1
        new string[]{"Friends", "LiePapers", "LieRoof", "LoveHandPickUp", "LovePinkyPromise", "LoveTwoHeadSide", "LovePinkyPromise2"},//2
        new string[]{"LookUpClouds", "LoveArmGrabWrap", "LoveDateStandTogether", "LoveHeadPat", "LoveHeart", "LoveSelfWorthWanted", "LoveHeadPat2"},//3
        new string[]{"NightMarket", "LoveComfortHug", "LoveHandGrabWrist", "LoveHandHoldNextTo", "LoveTwoHandMakeHeart", "LoveHeartFly"}//4
    };

    private int playCS = -1;
    private float turnOffCounter;
    private bool turnOn;
    private bool type;

    private TextCutscreen tcs;
    private AudioSource audioPlay;
    private VideoPlayer videoplayer;
    private GameObject blackOut;

    //private VideoManager videoManager;

    void Start()
    {
        audioPlay = GetComponent<AudioSource>();
        videoplayer = GameObject.Find("CutscenePlayer").GetComponent<VideoPlayer>();
        tcs = GameObject.Find("TextCutscene(Clone)").GetComponent<TextCutscreen>();
        transform.GetComponent<BoxCollider2D>().enabled = false;
//        videoManager = transform.GetChild(0).GetComponent<VideoManager>();
        turnOn = false;

        //videoplayer.sendFrameReadyEvents = true;
        //videoplayer.frameReady += Videoplayer_FrameReady;
    }

    void Videoplayer_FrameReady(VideoPlayer source, long frameIdx)
    {
        //print("test");//BRO WHAT THE FUCKING FUCK FUCK FUCK YOU FUCK
        if (frameIdx >= 110)
            source.frame = 0;
    }


    void Update()
    {
        if(blackOut == null)
            blackOut = transform.GetChild(0).gameObject;
        if (videoplayer == null && SceneManager.GetActiveScene().name.Equals("Room"))
            videoplayer = GameObject.Find("CutscenePlayer").GetComponent<VideoPlayer>();
        if (playCS == -1)//activated yet?
            return;
        if (tcs.inactive())
        {
            if (turnOffCounter > 7) //if playing for more then 7 seconds, turn off
            {
                playCS = -1;
                audioPlay.mute = true;
                blackOut.SetActive(false);//transform.GetChild(0).gameObject.SetActive(false);
                transform.GetComponent<BoxCollider2D>().enabled = false;
                videoplayer.enabled = false;
                videoplayer.Pause();
                //turnOn = false;
            }
            turnOffCounter += Time.deltaTime;
        }
    }
    [ContextMenu("Play Test")]
    public void playTest() => playEmotion(Random.Range(-10, 4));
    public void playEmotion(int num)
    {
        type = true;
        playCS = num + 10;
        playCS += Random.Range(-1, 2);
        if (playCS < 0)
            playCS = 0;
        if (playCS > 14)
            playCS = 14;
//        print((num+10) + "\t\t" + playCS);
        turnOffCounter = 0.0f;
        string nameOfCS = cutsceneRefs[playCS][Random.Range(0, cutsceneRefs[playCS].Length)];
        videoplayer.clip = Resources.Load<VideoClip>(nameOfCS);
        if(nameOfCS.Equals("LoveTwoHandMakeHeart"))
        {
            if (SteamManager.Initialized)
            {
                SteamUserStats.SetAchievement("SINGLE");
                SteamUserStats.StoreStats();
            }
        }
        audioPlay.mute = false;
        videoplayer.enabled = true;
        blackOut.SetActive(true);
        transform.GetComponent<BoxCollider2D>().enabled = true;
        videoplayer.Play();
    }

    public void remindEmotion()
    {
        type = false;
        turnOffCounter = 0.0f;
    }

    public bool inactive() => playCS == -1;
    public static void cutscene(string text) => GameObject.Find("TextCutscene(Clone)").GetComponent<TextCutscreen>().playTCS(text);
    public static void cutscene(int gif) => GameObject.Find("Cutscene(Clone)").GetComponent<Cutscene>().playEmotion(gif);
    public static void cutscene() => GameObject.Find("Cutscene(Clone)").GetComponent<Cutscene>().remindEmotion();
}
