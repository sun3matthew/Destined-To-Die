using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mailleave : MonoBehaviour
{
    private MeshRenderer text;
    private SpriteRenderer parentSR;
    void Start()
    {
        text = transform.GetChild(0).GetChild(1).GetComponent<MeshRenderer>();
        if (PlayerPrefs.GetInt("CatPostcards", 0) == 17 && PlayerPrefs.GetInt("GameWin", 0) == 1)
        {
            text.enabled = true;
            transform.GetChild(1).gameObject.SetActive(true);
        }
        text.sortingLayerName = "7OSWindow";
        parentSR = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        text.sortingOrder = parentSR.sortingOrder + 1;
    }
}
