using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLimit : MonoBehaviour
{
    public int fpsLimit = 15;
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = fpsLimit;
    }
}
