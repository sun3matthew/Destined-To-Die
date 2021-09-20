using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionPtLd : MonoBehaviour
{
    [SerializeField]
    GameObject shit;
    private void Start()
    {
        for(int i = 0; i < Intersections.intersections.Length; i++)
        {
            GameObject temp = Instantiate(shit, new Vector3(Intersections.getPoint(i).x, Intersections.getPoint(i).y, 0), Quaternion.identity, transform);
            temp.name = "" + i;
            temp.transform.GetChild(0).GetComponent<MeshRenderer>().sortingLayerName = "9TextUI";
            temp.transform.GetChild(0).GetComponent<TextMesh>().text = "" + i;
        }
    }
    [ContextMenu("Print Formatted Points")]
    public void printfmPt()
    {
        string acc = "";
        for (int i = 0; i < transform.childCount; i++)
            acc += "\t\tnew Vector2(" + round100(transform.GetChild(i).position.x) + "f, " + round100(transform.GetChild(i).position.y) + "f)" + (i != transform.childCount - 1 ? "," : "") + "//" + i + "\n";
        print(acc);
    }
    private float round100(float x) => Mathf.Round(x * 10) / 10f;
}
