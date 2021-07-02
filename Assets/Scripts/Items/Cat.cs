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
        if (PlayerPrefs.GetInt("GameWin", 0) == 1)
        {
            Cutscene.cutscene("Remaining Postcards Aquired!|You're already dead.|Why are you still here?|You should be gone.|*Yawn*");
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
                Cutscene.cutscene("Remember me, please. I don't want to disappear again");
            }
            else
            {
                Cutscene.cutscene("Postcard Aquired!|You're already dead.|Why are you still here?|You should be gone.|*Yawn*");
            }
            PlayerPrefs.SetInt("CatPostcards", PlayerPrefs.GetInt("CatPostcards", 0) + 1);
        }
        endGame = 1;
    }
}
