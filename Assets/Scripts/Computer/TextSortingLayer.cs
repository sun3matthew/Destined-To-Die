using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSortingLayer : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshRenderer text;
   
    void Start()
    {
        text = GetComponent<MeshRenderer>();
        text.sortingLayerName = "8WindowBar";
        text.sortingOrder = 2;
    }

}
