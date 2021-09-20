using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : Interactable
{
    [SerializeField]
    private GameObject map;

    [SerializeField]
    private Sprite mapSprite;
    protected override void Start()
    {
        base.Start();
    }
    /*public override void provoke()
    {
        Instantiate(map, player.transform.position, Quaternion.Euler(Vector3.forward * Random.Range(-5, 5))).GetComponent<SpriteRenderer>().sprite = mapSprite;
    }*/
}

