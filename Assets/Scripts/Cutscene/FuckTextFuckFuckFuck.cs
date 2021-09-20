using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FuckTextFuckFuckFuck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Text>().text = resolveTextSize(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setText(string input)
    {    
        string[] words = input.Split(" "[0]);
        string result = "";
        string line = "";    
        foreach (string s in words)
        {
            string temp = line + " " + s;
            if (temp.Length > 50)
            {
                result += line + "\n";
                line = s;
            }
            else
            {
                line = temp;
            }
        }      
        result += line;
        gameObject.GetComponent<Text>().text = result.Substring(1, result.Length - 1);
        //return result.Substring(1, result.Length - 1);
    }
}
