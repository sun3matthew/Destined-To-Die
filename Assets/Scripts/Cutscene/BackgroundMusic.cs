using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    [SerializeField]
    AudioClip[] music = null;
    AudioSource audioPlayer;
    Player player;
    AudioLowPassFilter lp;
    AudioGlitch ag;

    int currFalseDay;

    bool fadeMusic;
    // Start is called before the first frame update
    void Start()
    {
        fadeMusic = false;
        currFalseDay = -1;
        audioPlayer = GetComponent<AudioSource>();
        player = GameObject.FindObjectOfType<Player>();
        lp = GetComponent<AudioLowPassFilter>();
        ag = GetComponent<AudioGlitch>();
    }

    // Update is called once per frame
    void Update()
    {
        lp.cutoffFrequency = Mathf.Pow((player.happySmooth + 100), 2) + 200;

        if (player.happySmooth > -20f)
            ag.newAmtRepeat = 0;
        else
            ag.newAmtRepeat = (int)(player.happySmooth / -10f) - 1;

        if (currFalseDay != player.falseDay)
        {
            currFalseDay = player.falseDay;
            if (currFalseDay >= music.Length)
                return;
            fadeMusic = true;
        }

        if(fadeMusic)
        {
            audioPlayer.volume -= 0.15f * Time.deltaTime;
            if (audioPlayer.volume <= 0.01)
            {
                audioPlayer.volume = 0;
                audioPlayer.clip = music[currFalseDay];
                audioPlayer.Play();
                fadeMusic = false;
            }
        }else if(audioPlayer.volume < 0.4)
        {
            audioPlayer.volume += 0.01f * Time.deltaTime;
        }

    }
}
