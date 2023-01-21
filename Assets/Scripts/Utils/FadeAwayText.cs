using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAwayText : MonoBehaviour
{
    private TextMesh textMesh;
    private float counter;
    public static int numTexts;
    public void init(string text){
        if(numTexts < 0)
            numTexts = 0;
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) + (Vector2.down * numTexts * 0.15f) + new Vector2(0, 0.03f); 
        textMesh = GetComponent<TextMesh>();
        GetComponent<MeshRenderer>().sortingLayerName = "9TextUI";
        textMesh.text = text;
        numTexts++;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        textMesh.color = new Color(0.9f,0.9f, 0.9f, 1 - (counter/3.0f));
        transform.position = (Vector2)transform.position + Vector2.up * 0.2f * Time.deltaTime;    
        if(counter > 3){
            numTexts--;
            GameObject.Destroy(gameObject);
        }

    }
}
