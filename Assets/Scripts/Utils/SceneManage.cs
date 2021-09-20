using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage : MonoBehaviour
{
    // Start is called before the first frame update
    public HundredBound[] emotionsTransfer;
    public HundredBound[] abilityTransfer;
    public float hoursofhwTransfer;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (player != null)// && !player.unloading)
        {
            player.emotions = emotionsTransfer;
            player.abilities = abilityTransfer;
//            player.hoursOfHw = hoursofhwTransfer;
            GameObject.Destroy(gameObject);
        }
    }
}
