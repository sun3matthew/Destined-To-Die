using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected Animator an;

    [SerializeField]
    protected Vector2 moveToPos;

    [SerializeField]
    protected float speed;// = 1.7f;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
    }

    protected virtual void Update()
    {

    }
}
