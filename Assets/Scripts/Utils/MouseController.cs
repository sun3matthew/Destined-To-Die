using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour
{
    // Use this for initialization
    private float mouseClickCooldown;
    public Vector3 prevMouse;
    private Vector3 newMouse;

    private Clickable mouseDownOn;

    [SerializeField]
    private Texture2D mouse1;
    [SerializeField]
    private Texture2D mouse2;
    private void Start()
    {
        newMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        prevMouse = newMouse;
    }
    // Update is called once per frame
    void Update()
    {
        prevMouse = newMouse;
        newMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (clickable())
            Cursor.SetCursor(mouse2, new Vector2(11,0), CursorMode.Auto);
        else
            Cursor.SetCursor(mouse1, Vector2.zero, CursorMode.Auto);
        
        if (Input.GetMouseButton(0))
            mouseClickCooldown += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
            mouseDownOn = getClickedOn();

        if (Input.GetMouseButtonUp(0))
        {
            mouseClickCooldown = 0;
            Clickable temp = getClickedOn();
            if (temp != null && temp == mouseDownOn)
                temp.clickedOn(true);
        }
        if(mouseClickCooldown > 0.4 || (Input.GetMouseButton(0) && Vector2.Distance(prevMouse, newMouse) > 0.01))
        {
            mouseClickCooldown = 1;
            Clickable temp = getClickedOn();
            if (temp != null)
                temp.clickedOn(false);
        }
    }


    private Clickable getClickedOn()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(prevMouse, 0.001f);
        int size = 0;
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject.GetComponent<Clickable>() != null)
            {
                colliders[size] = colliders[i];
                size++;
            }
        }

        SpriteRenderer[] srs = new SpriteRenderer[size];
        for (int i = 0; i < srs.Length; i++)
            srs[i] = colliders[i].gameObject.GetComponent<SpriteRenderer>();
        if (size < 1)
            return null;
        int sortingLayer = srs[0].sortingLayerName[0] - '0';
        int sortingOrder = srs[0].sortingOrder;
        int maxIndex = 0;
        for (int i = 1; i < srs.Length; i++)
        {
            if (srs[i].sortingLayerName[0] - '0' > sortingLayer)
            {
                sortingLayer = srs[i].sortingLayerName[0] - '0';
                sortingOrder = srs[i].sortingOrder;
                maxIndex = i;
            }
            else if (srs[i].sortingLayerName[0] - '0' == sortingLayer)
            {
                if (srs[i].sortingOrder > sortingOrder)
                {
                    sortingOrder = srs[i].sortingOrder;
                    maxIndex = i;
                }
            }
        }
        //print(sortingLayer + ":" + sortingOrder + ":" + maxIndex);
        //print(sortingLayer + ":" + sortingOrder + ":" + (srs[maxIndex].gameObject.name));
        return srs[maxIndex].gameObject.GetComponent<Clickable>();
    }
    private bool clickable()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(prevMouse, 0.001f);
        for (int i = 0; i < colliders.Length; i++)
            if (colliders[i].gameObject.GetComponent<Clickable>() != null)
                return true;
        return false;
    }
}
