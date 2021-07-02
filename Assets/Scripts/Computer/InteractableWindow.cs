using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableWindow : Window
{
    [SerializeField]
    private Sprite[] anim;
    [SerializeField]
    private float speed;

    private float timeCounter;
    public int frameCounter;
    private SpriteRenderer sr;

    protected TimeDay time;
    protected Player player;

    public int toggleMulti;

    public bool toggled;

    private GameObject notification;
    private Icon icon;

    protected override void Start()
    {
        base.Start();
        initToggleMulti();
        sr = gameObject.GetComponent<SpriteRenderer>();
        time = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();
        player = Player.player();
        notification = transform.parent.Find("IconNotification") != null ? transform.parent.Find("IconNotification").gameObject : null;
        icon = transform.parent.GetComponent<Icon>();
        frameCounter = Random.Range(1, 5);
        sr.sprite = anim[frameCounter];
    }

    private void Update()
    {
        if (notification != null && !notification.activeSelf)
            backToIdle();
        if (toggled)
        {
            float multi = (200 - WindowManager.getToggleAmt() + toggleMulti) / 200f;
            if (multi < 0)
                multi = 0f;
            //Multi: amt of windows open
            //MotivationValue: in the mood, for spice
            //Emotion: amt of sleep
            timeCounter += Time.deltaTime * multi * icon.motivationValue;
            if (timeCounter > speed)
            {
                timeCounter = 0;
                frameCounter++;
                if (frameCounter >= 30)
                {
                    provoke();
                    frameCounter = 0;
                }
                sr.sprite = anim[frameCounter];
            }
            time.fastFowards(0.3f * Time.deltaTime * (1f / WindowManager.getNumToggled()));
        }
    }
    public override void clickedOn(bool type)
    {
        if (type && WindowManager.focused(this))
        {
            if (notification != null && !notification.activeSelf)
            {
                Cutscene.cutscene(notification.GetComponentInParent<IconNotificationManage>().badStatus());
            }
            else
            {
                toggled = !toggled;
                if (toggled)
                    WindowManager.addToggle(this);
                else
                    WindowManager.removeToggle(this);
            }
        }
        base.clickedOn(type);
    }
    public override void turnOff()
    {
        backToIdle();
        base.turnOff();
    }
    public void backToIdle()
    {
        if (toggled)
        {
            toggled = false;
            WindowManager.removeToggle(this);
        }
    }
    protected abstract void provoke();
    protected abstract void initToggleMulti();
}
