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
            PlayerPrefs.SetInt("CatPostcards", 17);
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
                DontDestroyOnLoadManager.endType = true;
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
            localization.addLanguage("นายไม่จำเป็นต้องมีเลาหรอก ถึงไม่มีเลานายก็ชนะได้|โปสการ์ดที่ได้รับคงเหลืออยู่ 16/16|นายตายไปแล้วนะ|ทำไมนายถึงยังอยู่ที่นี่อีกหล่ะ?|นายควรจะหายไปแล้วนี่นา|*หาว*", 1);
            localization.addLanguage("Tu n'as pas besoin de moi. Tu peux gagner seul.|Cartes Postales Restantes Obtenues. 16/16|Tu es déjà mort.|Pourquoi es-tu toujours ici?|Tu devrais être parti.|*Baîllement*", 2);
            Cutscene.cutscene(localization.getLanguage());
            catGone = true;
        }
        else
        {
            int updateAmt = 1;
            if( PlayerPrefs.GetInt("CatPostcards", 0) < 15 && PlayerPrefs.GetInt("Speed", 0) == 1)
                updateAmt = 2;
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
                localization.addLanguage("ได้โปรดจดจำเลาไว้ ขอร้องหล่ะ เลาไม่อยากหายไปอีกแล้ว|ถึงนายจะลืมว่าเลาคือใคร|ก็ขอให้นายจำชื่อเลาไว้เถอะนะ|Curry.|ลาก่อน", 1);
                localization.addLanguage("Souviens-toi de moi, s'il te plaît. Je ne veux pas disparaître une fois de plus.|Même si tu oublies qui je suis.|Souviens-toi de mon nom.|Curry.|Au revoir.", 2);
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
                localization.addLanguage("Postcard Acquired! " + (PlayerPrefs.GetInt("CatPostcards", 0)+updateAmt) + "/16\nTip: " + tipsLo.getLanguage()[PlayerPrefs.GetInt("CatPostcards", 0)] + "|You're already dead.|Why are you still here?|You should be gone.|*Yawn*", 0);
                localization.addLanguage("ได้รับโปสการ์ด! " + (PlayerPrefs.GetInt("CatPostcards", 0) + 1) + "/16\nเคล็ดลับ: " + tipsLo.getLanguage()[PlayerPrefs.GetInt("CatPostcards", 0)] + "|นายตายไปแล้วนะ|ทำไมนายถึงยังอยู่ที่นี่อีกหล่ะ?|นายควรจะไปได้แล้ว|*หาว*", 1);
                localization.addLanguage("Carte Postale Obtenue! " + (PlayerPrefs.GetInt("CatPostcards", 0) + 1) + "/16\nAstuce: " + tipsLo.getLanguage()[PlayerPrefs.GetInt("CatPostcards", 0)] + "|Tu es déjà mort.|Pourquoi es-tu toujours ici?|Tu devrais être parti|*Baîllement*", 2);
                Cutscene.cutscene(localization.getLanguage());
                catGone = false;
            }
            PlayerPrefs.SetInt("CatPostcards", PlayerPrefs.GetInt("CatPostcards", 0) + updateAmt);
        }
        endGame = 1;
    }
}
