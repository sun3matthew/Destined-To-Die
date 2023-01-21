using UnityEngine;
public class HundredBound
{
    private GameObject prefab;
    public static bool stopShow;
    private string name;
    public HundredBound(string name, GameObject prefab){
        this.name = name; 
        this.prefab = prefab;
    }
    private float value;//-100 to 100
    public float getValue() => value;
    public int getIntValue() => Mathf.RoundToInt(value);
    public void changeValue(float amt){
        value = hundredToHundred(value + amt);
        if(stopShow || PlayerPrefs.GetInt("Difficulty" , 1) == 2)
            return;    
        GameObject.Instantiate(prefab).GetComponent<FadeAwayText>().init(name + " " + (Mathf.Sign(amt) == 1 ? "+" : "-") + Mathf.Abs(amt).ToString("n1"));
    }
    public void setValue(float amt) => value = hundredToHundred(amt);
    private float hundredToHundred(float num)
    {
        if (num > 100)
            return 100;
        if (num < -100)
            return -100;
        return num;
    }
}
