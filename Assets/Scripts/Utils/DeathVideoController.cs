using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class DeathVideoController : MonoBehaviour
{
    [SerializeField]
    VideoClip[] clips;

    [SerializeField]
    GameObject[] days;

    private SpriteRenderer dsr;
    private VideoPlayer vp;

    private bool donePlay;
    private float time;
    void Start()
    {
        int day = -1;
        if (GameObject.Find("DeathDayTransfer") == null)
            day = GameObject.Find("DDTTEST").GetComponent<DeathDayTransfer>().getDay();
        else
            day = GameObject.Find("DeathDayTransfer").GetComponent<DeathDayTransfer>().getDay();
        dsr = Instantiate(days[day], new Vector3(0, 0, 0), Quaternion.identity).GetComponent<SpriteRenderer>();
        dsr.color = new Color(1f, 1f, 1f, 0f);
        vp = transform.GetComponent<VideoPlayer>();
        vp.clip = clips[day];

    }
    private void Update()
    {
        if(PlayerPrefs.GetInt("Censored", 0) == 1)
            vp.audioOutputMode = VideoAudioOutputMode.None;
        time += Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("BudgetTerminal");
        if (time > 34)
        {
            SceneManager.LoadScene("BudgetTerminal");
        }

        if (time < 1)
        {
            dsr.color = new Color(1f, 1f, 1f, time);
        }
        else if (time < 4)
        {
            dsr.color = new Color(1f, 1f, 1f, 1 - ((time - 1) / 3f));
        }
        else if (time < 31)
        {
            dsr.enabled = false;
            if (!donePlay && !vp.isPlaying)
            {
                donePlay = true;
                vp.Play();
            }
        }
    }
}