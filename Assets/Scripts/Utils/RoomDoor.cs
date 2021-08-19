using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoomDoor : MonoBehaviour
{
    // Start is called before the first frame update
    //private Transform camPos;
    private Image img;
    private Image cat;
    private Text txt;
    private float counter;// = -1;

    [SerializeField]
    bool dontStart;
    [SerializeField]
    string sceneName = null;
    [SerializeField]
    Vector2 enterPos;

    private TimeDay time;

    private bool intro;
    void Start()
    {
        img = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        cat = transform.GetChild(0).GetChild(1).GetComponent<Image>();
        txt = transform.GetChild(0).GetChild(2).GetComponent<Text>();
        counter = dontStart ? -1 : 0.30f;
        intro = !dontStart;
        time = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();
        if (PlayerPrefs.GetInt("CatPostcards", 0) == 17)
            transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter >= 0)
        {
            if (intro)
            {
                counter -= Time.deltaTime;
                if (counter < 0)
                    intro = false;
            }
            else
            {
                counter += Time.deltaTime;
                if (counter >= 0.25)
                {
                    SceneManager.LoadScene(sceneName);
                    if (GameObject.FindGameObjectWithTag("Player") != null)
                        GameObject.FindGameObjectWithTag("Player").transform.position = enterPos;
                    Classmate[] classmates = FindObjectsOfType<Classmate>();
                    for (int i = 0; i < classmates.Length; i++)
                        classmates[i].overrideHideBool = sceneName.Equals("Room");
                }
            }
        }
        img.color = new Color(0, 0, 0, counter / 0.25f);
        cat.color = new Color(1, 1, 1, counter / 0.25f);
        txt.color = new Color(1, 1, 1, counter / 0.25f);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            provoke();
    }
    public void provoke()
    {
        if(time.timeDay > 12.5 && time.timeDay < 17.5)
        {
            counter = 0;
            intro = false;
        }
        else
        {
            LanguageLocalization<string> localization = new LanguageLocalization<string>();
            localization.addLanguage("Practice has not started yet.", 0);
            localization.addLanguage("ยังไม่ถึงเวลาซ้อม", 1);
            Cutscene.cutscene(localization.getLanguage());
        }
    }
}
