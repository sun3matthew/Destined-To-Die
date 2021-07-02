using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        GetComponent<CinemachineVirtualCamera>().Follow = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
