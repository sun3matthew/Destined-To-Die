using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneDarken : MonoBehaviour
{
    private Transform camPos;
    private Image img;
    private float counter;
    // Start is called before the first frame update
    void Start()
    {
        img = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        if (camPos == null)
            camPos = Camera.main.transform;
        transform.position = camPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        img.color = new Color(0, 0, 0, counter/3.0f);
    }
}
