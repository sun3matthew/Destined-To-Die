using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{

    protected TimeDay time;

    protected string[] tcs;

    protected Player player;

    private SpriteRenderer sr;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        tcs = new string[21];
        time = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();
        for (int i = 0; i < tcs.Length; i++)
        tcs[i] = "Not Yet Implemented " + i + "|Not Yet Implemented part two " + i;
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    protected void tcsAt(HundredBound val)
    {
        string[] temp = tcs[(val.getIntValue() / 10) + 10].Split('|');
        Cutscene.cutscene(temp[Random.Range(0, temp.Length)]);// + "|{value}:" + val.getIntValue());
    }
    /*protected void tcsAt(string val)
    {
        string[] temp = val.Split('|');
        Cutscene.cutscene(temp[Random.Range(0, temp.Length)]);
    }*/
}
