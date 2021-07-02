using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuckLetterBoxing : MonoBehaviour
{
    void Start() => Screen.SetResolution(Screen.resolutions[Screen.resolutions.Length - 1].width, Screen.resolutions[Screen.resolutions.Length - 1].height, true);
}
