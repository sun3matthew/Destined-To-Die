using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager
{
    private static Color gray = new Color(0.95f, 0.95f, 0.95f);
    private static Color white = new Color(1f, 1f, 1f);

    private static int toggleAmt;
    private static int numToggled;

    public static List<Window> windows = new List<Window>();
    public static void add(Window window)
    {
        windows.Add(window);
        resetOrder();
    }
    public static void focus(Window window)
    {
        if (focused(window))
            return;
        windows.Remove(window);
        add(window);
    }
    public static bool focused(Window window) => windows[windows.Count-1] == window;
    public static void addToggle(InteractableWindow window)
    {
        numToggled++;
        toggleAmt += window.toggleMulti;
    }
    public static void removeToggle(InteractableWindow window)
    {
        numToggled--;
        toggleAmt -= window.toggleMulti;
    }
    private static void resetOrder()//clean and correct sprite orders
    {
        for (int i = 0; i < windows.Count; i++)
        {
            windows[i].GetComponent<SpriteRenderer>().color = gray;
            windows[i].GetComponent<SpriteRenderer>().sortingOrder = 1 + i * 3;
            windows[i].transform.GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = 2 + i * 3;
            windows[i].transform.GetChild(0).GetChild(0).GetComponent<SpriteRenderer>().sortingOrder = 3 + i * 3;
        }
        windows[windows.Count - 1].GetComponent<SpriteRenderer>().color = white;
    }
    public static int getToggleAmt() => toggleAmt;
    public static int getNumToggled() => numToggled;

    public static void cleanHouse()
    {
        toggleAmt = 0;
        numToggled = 0;
        windows.Clear();
    }

    public static void closeAllToggle()//I don't trust my code, but it works well enough but I think it'll brake
    {
        for (int i = 0; i < windows.Count; i++)
            if (windows[i] is InteractableWindow)
                ((InteractableWindow)windows[i]).backToIdle();
        toggleAmt = 0;
        numToggled = 0;
    }
}
