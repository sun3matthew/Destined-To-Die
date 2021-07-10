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

    void Start()
    {
        animator = transform.GetComponent<Animator>();
        endGame = -1;
        alClickedOn = false;
        if (PlayerPrefs.GetInt("CatPostcards", 0) >= 17)
        {

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
            if (endGame > 4)
            {
                DontDestroyOnLoadManager.becomeMortal();
                SceneManager.LoadScene("Death");
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
            localization.addLanguage("Remaining Postcards Acquired!|You're already dead.|Why are you still here?|You should be gone.|*Yawn*", 0);
            localization.addLanguage("剩余明信片已购！|你已经死了。|你怎么还在这里？|你应该走了。|待会见", 1);
            localization.addLanguage("剩余明信片已購！|你已經死了。|你怎麼還在這裡？|你應該走了。|待會見", 2);
            Cutscene.cutscene(localization.getLanguage());
            PlayerPrefs.SetInt("CatPostcards", 17);
        }
        else
        {
            if(PlayerPrefs.GetInt("CatPostcards", 0) == 16)
            {
                if (SteamManager.Initialized)
                {
                    SteamUserStats.SetAchievement("GOOD_BYE");
                    SteamUserStats.StoreStats();
                }
                localization.addLanguage("Remember me, please. I don't want to disappear again", 0);
                localization.addLanguage("记住我。我不想再消失", 1);
                localization.addLanguage("記住我。我不想再消失", 2);
                Cutscene.cutscene(localization.getLanguage());
            }
            else
            {
                localization.addLanguage("Postcard Acquired!|You're already dead.|Why are you still here?|You should be gone.|*Yawn*", 0);
                localization.addLanguage("获得明信片！|你已经死了。|你怎么还在这里？|你应该走了。|待会见", 1);
                localization.addLanguage("獲得明信片！|你已經死了。|你怎麼還在這裡？|你應該走了。|待會見", 2);
                Cutscene.cutscene(localization.getLanguage());
            }
            PlayerPrefs.SetInt("CatPostcards", PlayerPrefs.GetInt("CatPostcards", 0) + 1);
        }
        endGame = 1;
    }
}
