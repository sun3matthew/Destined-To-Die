using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DontDestroyOnLoadManager
{
    static List<GameObject> imortalDicks = new List<GameObject>();
    public static void DontDestroyOnLoad(this GameObject gameobject)
    {
        UnityEngine.Object.DontDestroyOnLoad(gameobject);
        imortalDicks.Add(gameobject);
    }
    public static void becomeMortal()
    {
        for (int i = 0; i < imortalDicks.Count; i++)
            UnityEngine.Object.Destroy(imortalDicks[i]);
        imortalDicks.Clear();
        WindowManager.cleanHouse();
    }
}
