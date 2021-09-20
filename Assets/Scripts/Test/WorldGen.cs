using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] pref = null;
    void Start()
    {
        for(int y = 0; y < pref.Length; y++)
        {
            Vector2 offset = pref[y].transform.position;
            for (int i = -20; i < 20; i++)
            {
                GameObject.Instantiate(pref[y], offset + new Vector2(i * 4.63f, i * 2.31f), Quaternion.identity);
            }
        }
    }

}
