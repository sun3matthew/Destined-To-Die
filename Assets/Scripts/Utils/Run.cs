using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{
    // Start is called before the first frame update
    //private Transform camPos;
    private Image img;

    private float counter;

    private int state;
    private TimeDay time;
    private bool used;

    void Start()
    {
        img = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        time = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();
        counter = -1;
        used = false;
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter >= 0)
        {
            if(state == 2)
            {
                counter -= Time.deltaTime;
            }else if(state == 1)
            {
                counter += Time.deltaTime;
                if (counter >= 1)
                {
                    state++;
                    counter = 0.5f;
                }
            }
            else
            {
                counter += Time.deltaTime;
                if (counter >= 0.5)
                {
                    state++;
                    time.setTime(16f);
                }
            }
        }
        img.color = new Color(0, 0, 0, counter / 0.5f);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (used)
            return;
        //print(time.timeDay);
        if (collision.CompareTag("Player") && time.timeDay > 12 && time.timeDay < 15.6f)
        {
            int miles = Mathf.RoundToInt((16 - time.timeDay) * 3f);
            LanguageLocalization<string> localization = new LanguageLocalization<string>(); 
            localization.addLanguage("You ran " + miles + " mile" + (miles == 1 ? "" : "s"), 0);
            localization.addLanguage("คุณวิ่งไป " + miles + " ไมล์", 1);
            Cutscene.cutscene(localization.getLanguage());
            Player.player().abilities[3].changeValue(miles * 2f);
            Player.player().wentToPractice = true;
            used = true;
            counter = 0;
        }
        else
        {
            LanguageLocalization<string> localization = new LanguageLocalization<string>();
            localization.addLanguage("It's too late to run", 0);
            localization.addLanguage("คุณมาวิ่งช้าเกินไป", 1);
            Cutscene.cutscene(localization.getLanguage());
        }
    }
}
