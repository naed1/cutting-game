using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   public static GameController Instance { get; private set; }

    bool control = false;

    private void Awake()
    {

        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
