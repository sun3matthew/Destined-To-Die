using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemTime : MonoBehaviour
{
    private TextMesh text;
    private TimeDay time;
    private int actualDay;
    public int falseDay;
    private string[] months = { "Wed Nov", "Tue Dec", "Fri Jan", "Mon Feb", "Fri Mar", "Thu Apr", "Wed May", "Fri Jun", "Wed Nov"};
    private int[] days = {19, 28, 13, 13, 27, 17, 6, 27, 19};
    // Start is called before the first frame update
    void Start()
    {
        actualDay = 0;
        falseDay = 0;
        text = GetComponent<TextMesh>();
        time = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();
    }

    // Update is called once per frame
    void Update()
    {
        if(actualDay != time.day)
        {
            days[falseDay]++;
            actualDay = time.day;
        }

        //this fucker displays the stuff in text form
        text.text = days[falseDay] + " " + months[falseDay] + " " + (((int)time.timeDay % 12 == 0 ? 12 : (int)time.timeDay % 12) >= 10 ? "" : " ") + ((int)time.timeDay%12 == 0 ? 12 : (int)time.timeDay%12) + ":" + ((int)(60 * (time.timeDay - ((int)time.timeDay)))).ToString("00") + (((int)time.timeDay/12) == 0 ? " AM" : " PM");
    }
}
