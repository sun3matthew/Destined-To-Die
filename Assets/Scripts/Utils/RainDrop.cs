using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrop : MonoBehaviour
{
    // Start is called before the first frame update
    private static float speed = 5.0f;

    [SerializeField]
    private Sprite[] raindropAnim;

    private bool done;

    private float timeToLive;

    [SerializeField]
    private Vector3 speedCache;

    private SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        done = true;
        timeToLive = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if(!done)
        {
            timeToLive -= Time.deltaTime;
            if(timeToLive < 0)
            {
                done = true;
                sr.sprite = null;
            }else if(timeToLive < 0.1f)
            {
                sr.sprite = raindropAnim[3];
            }else if (timeToLive < 0.2f)
            {
                sr.sprite = raindropAnim[2];
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (timeToLive < 0.3f)
            {
                sr.sprite = raindropAnim[1];
            }
            else
            {
                transform.position -= speedCache;
            }
        }
    }

    public void setup(Vector2 pos, float death, float horizSpeed)
    {
        done = false;
        transform.position = pos;
        timeToLive = death;
        sr.sprite = raindropAnim[0];
        speedCache = new Vector3(Time.deltaTime * horizSpeed, Time.deltaTime * speed);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * Mathf.Atan2(speed, horizSpeed) - 90);
    }
}
