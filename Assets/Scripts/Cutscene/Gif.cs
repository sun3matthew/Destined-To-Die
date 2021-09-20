using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gif : MonoBehaviour
{
    public string gifName;
    public int pot;//-10 to 10
    public Sprite[] frames;

    [ContextMenu("Sort Frames by Name")]
    public void DoSortFrames()
    {
        System.Array.Sort(frames, (a, b) => (int.Parse(a.name.Substring(6))) - (int.Parse(b.name.Substring(6))));
        //Debug.Log(gameObject.name + ".frames have been sorted alphabetically.");
    }
}
