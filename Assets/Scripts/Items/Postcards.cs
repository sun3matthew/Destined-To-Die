using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postcards : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Sprite[] catPS;

    [SerializeField]
    private Sprite[] catPSMini;

    [SerializeField]
    private Sprite[] catPSD;

    [SerializeField]
    private Sprite[] catPSMiniD;

    [SerializeField]
    private bool[] catPSRotated;

    [SerializeField]
    private GameObject miniPc;

    [SerializeField]
    private GameObject miniPcR;

    //[SerializeField]
    //private bool useDick = false;
    private void Start()
    {
        int ps = PlayerPrefs.GetInt("CatPostcards", 0);
        //ps = 16;
        if (ps == 17)
        {
            catPS = catPSD;
            catPSMini = catPSMiniD;
            ps = 16;
        }
        int x = 0;
        int y = 0;
        for(int i = 0; i < ps; i++)
        {
            if(catPSRotated[i])
            {
                GameObject temp = Instantiate(miniPcR, new Vector3((x * 0.5f) - 2.04f, ((-y * 0.5f) + (x * 0.25f)) + 0.66f, 0), Quaternion.identity, transform);
                temp.GetComponent<SpriteRenderer>().sprite = catPSMini[i];
                temp.GetComponent<MiniPostcard>().sprite = catPS[i];
                temp.GetComponent<MiniPostcard>().sortingOrder = i;
            }
            else
            {
                GameObject temp = Instantiate(miniPc, new Vector3((x * 0.5f) - 2.04f, ((-y * 0.5f) + (x * 0.25f)) + 0.66f, 0), Quaternion.identity, transform);
                temp.GetComponent<SpriteRenderer>().sprite = catPSMini[i];
                temp.GetComponent<MiniPostcard>().sprite = catPS[i];
                temp.GetComponent<MiniPostcard>().sortingOrder = i;
            }
            y++;
            if (y > 3)
            {
                y = 0;
                x++;
            }
        }
    }
}
