using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneMoreTime : MonoBehaviour
{
    float counter;
    [SerializeField]
    Image img;
    [SerializeField]
    Text txt;

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter > 4 && counter < 7){
            img.color = new Color(1, 1, 1, 1 - ((counter - 4) / 3));
            txt.color = new Color(0, 0, 0, ((counter - 4) / 3));
        }        
    }
}
