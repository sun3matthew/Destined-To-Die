using UnityEngine;
using System.Collections;

public class WindowBar : MonoBehaviour, Clickable
{
    private bool status;
    //private Vector3 originalMouse;
    //private Vector3 newMouse;
    private Vector3 mouseOffset;
    private Transform window;
    private Window windowS;

    private void Start()
    {
        window = transform.parent;
        windowS = window.gameObject.GetComponent<Window>();
    }
    private void Update()
    {
        //print(status);
        if (status)
        {
            if(Input.GetMouseButton(0))
            {
                Vector2 temp = Camera.main.ScreenToWorldPoint(Input.mousePosition) + mouseOffset;
                window.position = new Vector3(Mathf.Round(temp.x * 100) / 100.0f, Mathf.Round(temp.y * 100) / 100.0f, 0);
            }
            else
                status = false;
        }
    }

    public void clickedOn(bool type)
    {
        WindowManager.focus(windowS);
        if (!type)
        {
            if (!status)
            {
                mouseOffset = transform.position - GameObject.Find("MouseController(Clone)").GetComponent<MouseController>().prevMouse;
                status = true;
            }
        }
    }
}
