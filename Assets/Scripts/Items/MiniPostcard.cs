using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPostcard : MonoBehaviour, Clickable
{
    [SerializeField]
    private GameObject postCard;

    public Sprite sprite;
    public int sortingOrder;
    private void Start() => name = "Postcard " + sortingOrder;
    public void clickedOn(bool type)
    {
        if (!type)
            return;
        if (GameObject.Find("CatPostcardR(Clone)") != null)
        {
            Destroy(GameObject.Find("CatPostcardR(Clone)"));
            return;
        }
        if (GameObject.Find("CatPostcard(Clone)") != null)
        {
            Destroy(GameObject.Find("CatPostcard(Clone)"));
            return;
        }
        SpriteRenderer temp = Instantiate(postCard, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<SpriteRenderer>();
        temp.sprite = sprite;
        temp.sortingOrder = sortingOrder;
    }
}
