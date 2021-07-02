using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    [SerializeField]
    private float max;

    private InteractableWindow interactableWindow;
    private SpriteRenderer sr;
    private SpriteRenderer psr;
    private Vector3 scale;
    void Start()
    {
        interactableWindow = transform.parent.parent.GetComponent<InteractableWindow>();
        scale = transform.localScale;
        sr = GetComponent<SpriteRenderer>();
        psr = transform.parent.GetComponent<SpriteRenderer>();
        sr.color = new Color(0,0,0.9f,0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        sr.sortingOrder = psr.sortingOrder;
        scale.x = max * (interactableWindow.frameCounter / 30f);
        transform.localScale = scale;
        if(interactableWindow.toggled)
            sr.color = new Color(0, 0, 0.9f, 0.6f);
        else
            sr.color = new Color(0.8f, 0, 0, 0.6f);
    }
}
