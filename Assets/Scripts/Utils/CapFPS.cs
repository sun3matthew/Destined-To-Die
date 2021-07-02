using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapFPS : MonoBehaviour
{
    void Awake()
    {
        QualitySettings.vSyncCount = Mathf.RoundToInt(Screen.resolutions[Screen.resolutions.Length - 1].refreshRate/60f);
        //Application.targetFrameRate = 60;
    }
}
 