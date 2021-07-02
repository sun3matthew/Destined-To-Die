using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesText : MonoBehaviour
{
    private MeshRenderer text;
    private SpriteRenderer parentSR;
    void Start()
    {
        text = GetComponent<MeshRenderer>();
        text.sortingLayerName = "7OSWindow";
        parentSR = transform.parent.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        text.sortingOrder = parentSR.sortingOrder + 1;
    }
}
