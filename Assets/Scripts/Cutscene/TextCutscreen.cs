using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TextCutscreen : MonoBehaviour, Clickable
{
    // Start is called before the first frame update
    private string[] tcs;

    private int currC;
    private int currS = -1;

    private float counterC;

    private Transform camPos;

    private Text tp;

    private string sceneName;
    //private FuckTextFuckFuckFuck tp;

    void Start()
    {
        tp = transform.GetChild(0).GetChild(1).GetComponent<Text>();
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetComponent<BoxCollider2D>().enabled = false;
        sceneName = SceneManager.GetActiveScene().name;

    }

    // Update is called once per frame
    void Update()
    {
        if (!sceneName.Equals(SceneManager.GetActiveScene().name))//kill if new scene
        {
            sceneName = SceneManager.GetActiveScene().name;
            currS = -1;
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetComponent<BoxCollider2D>().enabled = false;
            return;
        }
        if (currS == -1)
            return;
        if (camPos == null)
            camPos = Camera.main.transform;
        transform.position = camPos.position;
        counterC += Time.deltaTime;
        if (counterC > 0.02 && currC <= tcs[currS].Length)//nextchar
        {
            tp.text = tcs[currS].Substring(0, currC);
            //tp.setText(tcs[currS].Substring(0, currC));
            currC++;
            counterC = 0;
        }
    }
    public void provoke()
    {
        if (currC > tcs[currS].Length - 1)//next line
        {
            currS++;
            if (currS > tcs.Length - 1)//finshed
            {
                currS = -1;
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetComponent<BoxCollider2D>().enabled = false;
            }
            checkColor();
            currC = 0;
            tp.text = "";
            counterC = 0;
        }
        if (currC > 1)
            currC = tcs[currS].Length;
    }
    private void checkColor()
    {
        if (currS >= 0 && tcs[currS][0] == '<')
        {
            Color newCol;
            ColorUtility.TryParseHtmlString(tcs[currS].Substring(7, 9), out newCol);
            tp.color = newCol;
            tcs[currS] = tcs[currS].Substring(tcs[currS].IndexOf('>') + 1, tcs[currS].LastIndexOf('<') - tcs[currS].IndexOf('>') - 1);
        }
        else
            tp.color = Color.white;
    }
    public void playTCS(string tcsIn)
    {
        tcs = tcsIn.Split('|');
        currC = 0;
        currS = 0;
        counterC = 0;
        tp.text = "";
        checkColor();

        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetComponent<BoxCollider2D>().enabled = true;
    }
    public bool inactive() => currS == -1;

    public void clickedOn(bool type)
    {
        if(type)
        {
            if (currC > tcs[currS].Length - 1)//next line
            {
                currS++;
                if (currS > tcs.Length - 1)//finshed
                {
                    currS = -1;
                    transform.GetChild(0).gameObject.SetActive(false);
                    transform.GetComponent<BoxCollider2D>().enabled = false;
                }
                checkColor();
                currC = 0;
                tp.text = "";
                //tp.setText("");
                counterC = 0;
            }
            if (currC > 1)
                currC = tcs[currS].Length;
        }
    }
}
