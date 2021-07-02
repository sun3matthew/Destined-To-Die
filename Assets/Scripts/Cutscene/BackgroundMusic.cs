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
    float counter;
    float randomWaitTime;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        randomWaitTime = Random.Range(0, 5f);
        audioPlayer = GetComponent<AudioSource>();
        player = GameObject.FindObjectOfType<Player>();
        lp = GetComponent<AudioLowPassFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Camera.main.transform.position;
        lp.cutoffFrequency = Mathf.Pow((player.happySmooth + 100), 2) + 200;
        if (!audioPlayer.isPlaying)
        {
            counter += Time.deltaTime;
            if(counter > randomWaitTime)
            {
                audioPlayer.clip = music[Random.Range(0, music.Length)]; //PlayOneShot(music[Random.Range(0, music.Length)]);
                audioPlayer.Play();
                counter = 0;
                randomWaitTime = Random.Range(0, 30f);
            }
        }

    }
}
