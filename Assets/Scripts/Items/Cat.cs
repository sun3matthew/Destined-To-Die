using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Steamworks;

public class Cat : MonoBehaviour, Clickable
{
    // Start is called before the first frame update
    private float counter;
    private float wagTime;
    private Animator animator;
    private float endGame;
    private bool alClickedOn;
    private int stopAt;

    private bool catGone;

    string[] tips;
    void Start()
    {
        catGone = false;
        animator = transform.GetComponent<Animator>();
        endGame = -1;
        stopAt = 10;
        alClickedOn = false;
        tips = new string[] {
            "Make sure you go to school. Otherwise your satisfaction will decrease very fast.",
            "Going to practice is beneficial for Instantaneous Happiness.",
            "The amount of sleep you get effects your satisfaction.",
            "The knife will increase your Instantaneous Happiness, but decrease happiness.",
            "Talking to someone constantly will better positive effects they have on you.",
            "Death Tolerance is heavily influenced by Instantaneous Happiness.",
            "Happiness is heavily influenced by Satisfaction.",
            "Death is dependent only on Happiness and Death Tolerance.",
            "Your Art, Coding, Friendship and School values influence Satisfaction.",
            "Death Tolerance is somewhat influenced by Happiness.",
            "Your Art, Coding, Friendship and School values decrease naturally.",
            "Instantaneous Happiness is influenced by Happiness.",
            "Playing Games and Watching Videos can increase Instantatious Happiness.",
            "Listening to music will exacerbate Instantaneous Happiness.",
            "Friendships with different people will have different effects upon your emotions.",
            "Happiness is influenced by Happiness."
        };
        if (PlayerPrefs.GetInt("CatPostcards", 0) >= 17)
        {
            stopAt = 15;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<PolygonCollider2D>().enabled = false;
            animator.enabled = false;
            endGame = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter > wagTime)
        {
            if(counter > wagTime + 0.5f)
            {
                animator.SetBool("Wag", false);
                wagTime = Random.Range(3f, 15f);
            }else
            {
                animator.SetBool("Wag", true);
            }
        }else
        {
            animator.SetBool("Wag", false);
        }
        if(endGame > 0)
        {
            endGame += Time.deltaTime;
            if (endGame > stopAt)
            {
                DontDestroyOnLoadManager.becomeMortal();
                SceneManager.LoadScene(catGone ? "CatGone" : "Death");
            }
        }
    }

    public void clickedOn(bool type)
    {
        if (alClickedOn)
            return;
        alClickedOn = true;
        LanguageLocalization<string> localization = new LanguageLocalization<string>();
        if (PlayerPrefs.GetInt("GameWin", 0) == 1)
        {
            PlayerPrefs.SetInt("CatPostcards", 17);
            localization.addLanguage("You don't need me. You can win alone.|Remaining Postcards Acquired. 16/16|You're already dead.|Why are you still here?|You should be gone.|*Yawn*", 0);
            localization.addLanguage("剩余明信片已购！|你已经死了。|你怎么还在这里？|你应该走了。|待会见", 1);
            localization.addLanguage("剩余明信片已購！|你已經死了。|你怎麼還在這裡？|你應該走了。|待會見", 2);
            Cutscene.cutscene(localization.getLanguage());
            catGone = true;
        }
        else
        {
            if(PlayerPrefs.GetInt("CatPostcards", 0) == 16)
            {
                if(PlayerPrefs.GetInt("GOOD_BYE", 0) == 0)
                {
                    PlayerPrefs.SetInt("GOOD_BYE", 1);
                    if (SteamManager.Initialized)
                    {
                        SteamUserStats.SetAchievement("GOOD_BYE");
                        SteamUserStats.StoreStats();
                    }
                }
                localization.addLanguage("Remember me, please. I don't want to disappear again.|Even if you forget who I am.|Remember my name.|Curry.|Goodbye.", 0);
                localization.addLanguage("记住我。我不想再消失", 1);
                localization.addLanguage("記住我。我不想再消失", 2);
                Cutscene.cutscene(localization.getLanguage());
                catGone = true;
            }
            else
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
                    "一定要上学，不然你的满足感会下降的很快。",
                    "跑步有益于瞬间的幸福。",
                    "弹跳图标表示任务进行得更快。",
                    "刀会增加你的瞬间幸福感，但会降低幸福感。",
                    "不断地与某人交谈，他们会对你产生更好的积极影响。",
                    "死亡容忍受到瞬间幸福的影响。",
                    "幸福在很大程度上受满足感的影响。",
                    "死亡只取决于幸福和死亡容忍。",
                    "你的艺术、编码、友谊和学校价值观影响满意度。",
                    "死亡容忍在某种程度上受到幸福的影响。",
                    "你的艺术、编码、友谊和学校价值自然下降。",
                    "瞬间的幸福受幸福的影响。",
                    "玩游戏和看视频可以增加瞬间的幸福感。",
                    "听音乐会加剧瞬间的幸福感。",
                    "睡眠时间长短会影响你的满意度。",
                    "幸福受幸福的影响。"}
                    , 1);
                tipsLo.addLanguage(new string[] {
                    "一定要上學，不然你的滿足感會下降的很快。",
                    "跑步有益於瞬間的幸福。",
                    "彈跳圖標表示任務進行得更快。",
                    "刀會增加你的瞬間幸福感，但會降低幸福感。",
                    "不斷地與某人交談，他們會對你產生更好的積極影響。",
                    "死亡容忍受到瞬間幸福的影響。",
                    "幸福在很大程度上受滿足感的影響。",
                    "死亡只取決於幸福和死亡容忍。",
                    "你的藝術、編碼、友誼和學校價值觀影響滿意度。",
                    "死亡容忍在某種程度上受到幸福的影響。",
                    "你的藝術、編碼、友誼和學校價值自然下降。",
                    "瞬間的幸福受幸福的影響。",
                    "玩遊戲和看視頻可以增加瞬間的幸福感。",
                    "聽音樂會加劇瞬間的幸福感。",
                    "睡眠時間長短會影響你的滿意度。",
                    "幸福受幸福的影響。"}
                    , 2);
                localization.addLanguage("Postcard Acquired! " + (PlayerPrefs.GetInt("CatPostcards", 0)+1) + "/16\nTip: " + tipsLo.getLanguage()[PlayerPrefs.GetInt("CatPostcards", 0)] + "|You're already dead.|Why are you still here?|You should be gone.|*Yawn*", 0);
                localization.addLanguage("获得明信片！|你已经死了。|你怎么还在这里？|你应该走了。|待会见", 1);
                localization.addLanguage("獲得明信片！|你已經死了。|你怎麼還在這裡？|你應該走了。|待會見", 2);
                Cutscene.cutscene(localization.getLanguage());
                catGone = false;
            }
            PlayerPrefs.SetInt("CatPostcards", PlayerPrefs.GetInt("CatPostcards", 0) + 1);
        }
        endGame = 1;
    }
}
