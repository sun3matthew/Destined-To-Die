using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinExit : MonoBehaviour
{
    private VideoPlayer vp;

    private Image fade1;
    private Text maintxt;
    private Text lovetxt;
    private Text titleTxt;

    private float counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        LanguageLocalization<string> localization = new LanguageLocalization<string>();
        localization.addLanguage("English", 0);
        localization.addLanguage("ChineseS", 1);
        localization.addLanguage("ChineseT", 2);

        vp = GameObject.Find("Video Player").GetComponent<VideoPlayer>();
        fade1 = GameObject.Find(localization.getLanguage()).transform.GetChild(2).GetComponent<Image>();
        maintxt = GameObject.Find(localization.getLanguage()).transform.GetChild(0).GetComponent<Text>();
        lovetxt = GameObject.Find(localization.getLanguage()).transform.GetChild(1).GetComponent<Text>();
        titleTxt = GameObject.Find(localization.getLanguage()).transform.GetChild(3).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter < 4)
        {
            maintxt.color = new Color(1, 1, 1, counter / 4f);
        } else if (counter < 7)
        {
            lovetxt.color = new Color(1, 0, 0, (counter - 4) / 3f);
        }
        else if (counter < 12)
        {
            fade1.color = new Color(0, 0, 0, (counter - 8) / 4f);
        }else if(counter < 13)
        {
            maintxt.enabled = false;
            lovetxt.enabled = false;
            vp.enabled = true;
        }else if(counter < 14)
        {
            fade1.color = new Color(0, 0, 0, 1-((counter - 13) / 1f));
        }else if(counter < 69)
        {
            if(counter > 60)
                titleTxt.color = new Color(1, 1, 1, (counter - 60) / 4f);
        }
        else
        {
            SceneManager.LoadScene("BudgetTerminal");
        }
        //print(counter);//52

        //if (!vp.isPlaying)
        //    SceneManager.LoadScene("BudgetTerminal");
    }
}
