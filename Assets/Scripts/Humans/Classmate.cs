using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public abstract class Classmate : Human, Clickable
{
    [SerializeField]
    protected Vector2 house;

    protected string[] path;

    protected int currPoint;
    protected int humanNum;

    private bool talking;

    private int friendshipLvl;

    public string humanName;

    private Player player;

    protected string[] tcsPos;
    protected int personalityType;

    private TimeDay time;

    private SpriteRenderer sr;
    private BoxCollider2D bc;

    private string[] currPath;

    private float previousTime;

    public bool overrideHideBool;
    private float randomOffset;
    private Dictionary<string, Sprite> spriteSheet;

    public static int arrivalButNotTheMovie = 51;//1pm
    public static int arrivalButNotTheMoviePartTwo = 64;//1pm
    public static int arrivalButNotTheMoviePartThree = 68;//1pm

    public bool talkedTo;

    protected override void Start()
    {
        base.Start();
        speed = 1.2f;
        moveToPos = footPos();
        randomOffset = Random.Range(-0.15f, 0.15f);
        friendshipLvl = 0;
        talkedTo = false;
        tcsPos = new string[8];
        path = new string[96];
        for (int i = 0; i < path.Length; i++)
            path[i] = "-1";
        for (int i = 0; i < tcsPos.Length; i++)
            tcsPos[i] = "{ERROR} - Unable to find friendship";
        path[arrivalButNotTheMovie + 6] = "52";
        path[arrivalButNotTheMoviePartThree + 8] = "0";
        initPaths();
        initHome();
        initHumanNum();
        initConvos();
        initPersonality();

        humanName += "ff";
        for (int i = 0; i < tcsPos.Length; i++)
        {
            string[] temp = tcsPos[i].Split('|');
            tcsPos[i] = "";
            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j][0] == '\'')
                    temp[j] = "<color=" + humanName + ">" + temp[j].Substring(1, temp[j].Length - 2) + "</color>";
                tcsPos[i] += '|' + temp[j];
            }
            tcsPos[i] = tcsPos[i].Substring(1);
        }

        setPosition(Intersections.getPoint(0));
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        time = GameObject.Find("Time(Clone)").GetComponent<TimeDay>();
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
        spriteSheet = Resources.LoadAll<Sprite>("Person" + (humanNum)).ToDictionary(x => x.name, x => x);
        overrideHideBool = true;
        currPath = path[(int)(time.timeDay * 4)].Split(' ');
        name = "Classmate " + humanNum;
        hide();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (talking)
        {
            if (!player.cutsceneDone())
                moveCmd(0, 0, false);
            else
                talking = false;
        }
        updateMovement(false);
    }
    protected void LateUpdate() => sr.sprite = spriteSheet[sr.sprite.name];


    protected void moveCmd(int movX, int movY, bool ff)
    {
        if (!talking)
        {
            if(ff)
            {
                float tempSpeed = speed * Time.deltaTime;
                if (movY == 1) transform.position += new Vector3(tempSpeed, tempSpeed / 2);
                else if (movY == -1) transform.position += new Vector3(-tempSpeed, -tempSpeed / 2);
                else if (movX == 1) transform.position += new Vector3(tempSpeed, -tempSpeed / 2);
                else if (movX == -1) transform.position += new Vector3(-tempSpeed, tempSpeed / 2);
            }else
            {
                if (movY == 1) rb.velocity = new Vector2(speed, speed / 2);
                else if (movY == -1) rb.velocity = new Vector2(-speed, -speed / 2);
                else if (movX == 1) rb.velocity = new Vector2(speed, -speed / 2);
                else if (movX == -1) rb.velocity = new Vector2(-speed, speed / 2);
                else rb.velocity = new Vector2();
                if (movX != 0 || movY != 0)
                {
                    an.SetBool("Move", true);
                    an.SetFloat("Move X", movX);
                    an.SetFloat("Move Y", movY);
                }
                else
                {
                    an.SetBool("Move", false);
                }
            }
        }else
        {
            rb.velocity = new Vector2();
            an.SetBool("Move", false);
        }
    }
    public void updateMovement(bool ff)
    {
        sr.enabled = !overrideHideBool;
        bc.enabled = !overrideHideBool;
        if (currPoint < currPath.Length)//if still pathing and the current path is not a stop
        {
            if (int.Parse(currPath[currPoint]) == -1)//if is negative one aka hide
            {
                currPoint++;
            }
            else
            {
                //visable();
                moveToPos = Intersections.getPoint(int.Parse(currPath[currPoint]));
                if (atPoint())
                    currPoint++;
                Vector2 foot = footPos();
                if (!moveToPos.Equals(foot))
                {
                    int movX = 0;
                    int movY = 0;
                    Vector2 playerPos2D = new Vector2(-1 * (foot.y - foot.x / 2), foot.x / 2 + foot.y);
                    Vector2 moveToPos2D = new Vector2(-1 * (moveToPos.y - moveToPos.x / 2), moveToPos.x / 2 + moveToPos.y);
                    if (Mathf.Abs(playerPos2D.y - moveToPos2D.y) < 0.1)
                    {
                        if (playerPos2D.x < moveToPos2D.x) movX++;
                        else if (playerPos2D.x > moveToPos2D.x) movX--;
                    }
                    else
                    {
                        if (playerPos2D.y < moveToPos2D.y) movY++;
                        else if (playerPos2D.y > moveToPos2D.y) movY--;
                    }
                    moveCmd(movX, movY, ff);
                }
            }
        }
        else//next
        {
            moveCmd(0, 0, ff);
            currPoint = 0;
            if((int)((time.timeDay + randomOffset) * 4) < 96)
                currPath = path[(int)((time.timeDay + randomOffset) * 4)].Split(' ');
        }
    }
    public void setPosition(Vector2 newPos)
    {
        transform.position = newPos;
        moveToPos = footPos();
    }
    public void hide()
    {
        sr.enabled = false;
        bc.enabled = false;
    }
    public void visable()
    {
        if (overrideHideBool)
            return;
        sr.enabled = true;
        bc.enabled = true;
    }
    private Vector2 getPoint(int num)
    {
        if (num == 0)
            return house;
        return Intersections.getPoint(num);
    }
    /*
     * Sets a range from start to end to a number
     * only for when path is being loaded.
     */    
    protected void pathInterval(int start, int end, string value)
    {
        for (int i = start; i < end; i++)
            path[i] = value;
    }
    protected bool atPoint() => Vector2.Distance(moveToPos, footPos()) <= 0.5;
    protected Vector2 footPos() => new Vector2(transform.position.x, transform.position.y - 0.65f);

    protected abstract void initConvos();
    protected abstract void initHome();
    protected abstract void initPaths();
    protected abstract void initHumanNum();
    protected abstract void initPersonality();

    public void clickedOn(bool type)
    {
        if(type)
        {
            if (!talkedTo)
            {
                if (player.talkedToAmt < 5)
                {
                    player.talkedToAmt++;
                    talkedTo = true;
                    Cutscene.cutscene(tcsPos[friendshipLvl]);
                    friendshipLvl++;
                    if (time.day != 8)
                        player.emotions[personalityType].changeValue(friendshipLvl * 1.5f);
                    talking = true;
                }
                else
                {
                    LanguageLocalization<string> localization = new LanguageLocalization<string>();
                    localization.addLanguage("My social battery is drained.", 0);
                    localization.addLanguage("我太累了不想和人说话", 1);
                    localization.addLanguage("我太累了不想和人說話", 2);
                    Cutscene.cutscene(localization.getLanguage());
                }
            }
            else
            {
                LanguageLocalization<string> localization = new LanguageLocalization<string>();
                localization.addLanguage("I already talked to them.", 0);
                localization.addLanguage("我已经和他们谈过了。", 1);
                localization.addLanguage("我已經和他們談過了。", 2);
                Cutscene.cutscene(localization.getLanguage());
            }
        }
    }
}