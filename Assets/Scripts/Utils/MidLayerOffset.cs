using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidLayerOffset : MonoBehaviour
{
    [SerializeField]
    private float offset;
    void Update() => transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y - offset);
}
