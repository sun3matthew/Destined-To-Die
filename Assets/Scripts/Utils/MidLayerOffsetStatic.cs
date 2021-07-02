using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidLayerOffsetStatic : MonoBehaviour
{
    [SerializeField]
    private float offset;
    void Start() => transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y - offset);
}
