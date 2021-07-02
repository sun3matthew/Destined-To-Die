using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDay : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeDay;
    public int day;

    private ShaderManager shaderShit;
    float r, g, b;

    private float fowardsAmt;
    private Lighting[] lighting;
    private Classmate[] classmates;
    void Start()
    {
        shaderShit = GameObject.Find("Main Camera").GetComponent<ShaderManager>();
        updateLighting();
        timeDay = 0;
        day = 0;
        fowardsAmt = -1;
        GameObject.FindWithTag("Player").transform.GetComponent<Player>().transform.position = (new Vector2(-0.2f, -0.5f));
        classmates = FindObjectsOfType<Classmate>();
        setTime(5.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (shaderShit == null)
        {
            shaderShit = GameObject.Find("Main Camera").GetComponent<ShaderManager>();
            updateLighting();
        }
        if (classmates == null)
        {
            classmates = FindObjectsOfType<Classmate>();
        }

        if(fowardsAmt > 0)
        {
            fowardsAmt -= 0.05f;
            updateTime(0.05f);
            for (int i = 0; i < classmates.Length; i++)
                for(int j = 0; j < 60; j++)//ig 60 is a arbitary number
                    classmates[i].updateMovement(true);
        }else
        {
            updateTime();
        }
        for (int i = 0; i < lighting.Length; i++)
            lighting[i].changeLighting(timeDay);
        if(shaderShit != null)
        {
            shaderShit.r = r;
            shaderShit.g = g;
            shaderShit.b = b;
        }
    }
    private void updateTime(float amt)
    {
        timeDay += amt;
        amt *= 1 / 2.0f;//Time.deltaTime*25;// (Time.deltaTime *);
        if(timeDay < 3)
        {
            r = -0f;
            g = -0.1f;
            b = -0.2f;
        }else if (timeDay < 4)//(initial - final) * (Time.deltaTime/90) * (1.0f/difference)
        {
            //night
            r = -0.6f;
            g = -0.4f;
            b = -0.15f;
        }
        else if (timeDay < 6)//sunrise
        {
            //to sunrise
            r -= (-0.6f) * amt;//0
            g -= (-0.4f + 0.25f) * amt;//-0.25
            b -= (-0.15f + 0.4f) * amt;//-0.4
        }
        else if (timeDay < 8)//day
        {
            //to day
            //r -= (0 + ) * multi;//0
            g -= (-0.25f) * amt;//0
            b -= (-0.4f) * amt;//0
        }
        else if (timeDay < 15)
        {
            r = 0;
            g = 0;
            b = 0;
        }
        else if (timeDay < 17)//sunset
        {
            //to sunset
            //r -= (0 + 0) * multi;//0
            g -= 0.25f * amt;//-0.25
            b -= 0.4f * amt;//-0.4
        }
        else if (timeDay < 18f)
        {
            //to night
            r -= 0.6f * amt;//-0.6
            g -= (-0.25f + 0.4f) * amt;//-0.4
            b -= (-0.4f + 0.15f) * amt;//-0.15
        }
        else
        {
            r = -0f;
            g = -0.1f;
            b = -0.2f;
        }
        if (timeDay > 24)
        {
            timeDay = 0;
            day++;
        }
    }
    private void updateTime() => updateTime(Time.deltaTime / 20);
    private void updateLighting()
    {

        GameObject[] temp = GameObject.FindGameObjectsWithTag("Lighting");
        Lighting[] spriteTemp = new Lighting[temp.Length];
        for (int i = 0; i < temp.Length; i++)
            spriteTemp[i] = temp[i].GetComponent<Lighting>();
        lighting = spriteTemp;
    }
    public void fastFowards(float amt) => fowardsAmt += amt;
    public void rollTime(float time)
    {
        if (timeDay > time)
            time += 24;
        fowardsAmt += time - timeDay;
    }
    public void setTime(float time)
    {
        //print(time);
        if (timeDay > time)
            time += 24;
        for (float fowardsAmtLocal = time - timeDay; fowardsAmtLocal > 0; fowardsAmtLocal -= 0.05f)
        {
            updateTime(0.05f);
            for (int i = 0; i < classmates.Length; i++)
                for(int j = 0; j < 60; j++)//ig 60 is a arbitary number
                    classmates[i].updateMovement(true);
        }
    }
}
