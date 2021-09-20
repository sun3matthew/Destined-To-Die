using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private VideoPlayer videoPlayer1;
    private VideoPlayer videoPlayer2;

    private float counter = 0;
    private bool toggle;
    private bool play;

    void Start()
    {
        toggle = false;
        videoPlayer1 = transform.GetChild(0).GetComponent<VideoPlayer>();
        videoPlayer2 = transform.GetChild(1).GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!play)
            return;
        if (videoPlayer1.targetCamera == null)
            videoPlayer1.targetCamera = Camera.main;
        if (videoPlayer2.targetCamera == null)
            videoPlayer2.targetCamera = Camera.main;
        //print("test : " + videoPlayer1.frame);
        if (toggle ? videoPlayer2.frame > 110 : videoPlayer1.frame > 110)
        {
            if (toggle)
            {
                print("1");
                videoPlayer2.frame = 0;
                //videoPlayer2.enabled = false;
                videoPlayer1.enabled = true;
                videoPlayer2.Pause();
                videoPlayer1.Play();
            }
            else
            {
                print("2");
                videoPlayer1.frame = 0;
                videoPlayer1.enabled = false;
                //videoPlayer2.enabled = true;
                videoPlayer1.Pause();
                videoPlayer2.Play();
            }
            toggle = !toggle;
        }
    }
    public void playVideo(VideoClip clip)
    {
        videoPlayer1.clip = clip;
        videoPlayer2.clip = clip;
        videoPlayer1.enabled = true;
        videoPlayer2.enabled = true;
        videoPlayer1.frame = 1;
        videoPlayer2.frame = 1;
        toggle = false;
        videoPlayer1.Play();
        play = true;
    }
    public void pauseVideo()
    {
        videoPlayer1.enabled = false;
        videoPlayer2.enabled = false;
        videoPlayer1.Pause();
        videoPlayer2.Pause();
        play = false;
    }
}
