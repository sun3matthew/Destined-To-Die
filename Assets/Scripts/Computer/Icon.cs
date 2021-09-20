using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour, Clickable
{
    public float motivationValue;
    private float seed;

    private bool interactable;
    private SpriteRenderer sr;

    private static readonly float[] velocityGraph = { 0, 4, 4, 3, 3, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 0, 0, 0, -1, -1, -1, -1, -1, -2, -2, -2, -3, -3, -3, -3, -4, -4, 3, 2, 2, 1, 1, 1, 0, 0, -1, -1, -1, -2, -2, -3, 2, 1, 1, 0, -1, -1, -2, 0, 0, 0 };//listen, fuck off, ik this is shit code but hey. I'm lazy
    private int animCounter;
    private float animTimer;
    private Vector3 move;

    private GameObject notification;

    private Transform child;
    void Start()
    {
        move = new Vector3();
        child = transform.GetChild(0);
        motivationValue = 0;
        seed = Random.Range(0, 10000);
        sr = GetComponent<SpriteRenderer>();
        animCounter = -1;
        notification = transform.Find("IconNotification") != null ? transform.Find("IconNotification").gameObject : null;
        if (transform.GetChild(0).gameObject.GetComponent<Window>() is InteractableWindow)
            interactable = true;
    }
    void Update()
    {
        if(interactable)
        {
            motivationValue = Mathf.PerlinNoise(Time.time * 0.05f, seed);
            if (motivationValue < 0.4)
                motivationValue = 0.4f;
            if (motivationValue > 0.7f && animCounter < 0 && (notification == null || notification.activeSelf))
                animCounter = 0;

            if (motivationValue < 0.6)
                motivationValue /= 2f;
            if (motivationValue > 0.7)
                motivationValue *= 2f;

            if (animCounter == -1)
                return;
            if(animCounter >= velocityGraph.Length)
            {
                animCounter = -1;
                transform.localPosition = new Vector3(transform.position.x, 0, 0);
            }
            else
            {
                animTimer += Time.deltaTime;
                if(animTimer > 0.01)
                {
                    move.y = velocityGraph[animCounter]*0.005f;
                    animCounter++;
                    transform.position += move;
                    child.position -= move;
                    animTimer = 0;
                }                    
            }


            //sr.color = new Color(motivationValue, motivationValue, motivationValue);
        }
    }
    public void clickedOn(bool type)
    {
        if(type)
        {
            //if (!transform.GetChild(0).gameObject.activeSelf)//if window is hidden, un hide

            if (transform.GetChild(0).gameObject.activeSelf && WindowManager.focused(transform.GetChild(0).GetComponent<Window>()))//if window is already in focus, close it
                transform.GetChild(0).gameObject.GetComponent<Window>().turnOff();
            else
            {
                transform.GetChild(0).gameObject.SetActive(true);
                WindowManager.focus(transform.GetChild(0).GetComponent<Window>());//if window is not in focus, focus it

            }
        }
    }
}
