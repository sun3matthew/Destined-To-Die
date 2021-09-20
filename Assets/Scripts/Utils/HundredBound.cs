using UnityEngine;
public class HundredBound
{
    private float value;//-100 to 100
    public float getValue() => value;
    public int getIntValue() => Mathf.RoundToInt(value);
    public void changeValue(float amt) => value = hundredToHundred(value + amt);
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
