using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceExit : MonoBehaviour
{
    // Start is called before the first frame update
    TimeDay time;
    private bool done;
    void Start()
    {
        done = false;
        time = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time.timeDay > 17.8f && !done)
        {
            done = true;
            GameObject.Find("Door").transform.GetComponent<Door>().provoke();
        }
    }
}
