using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController Instance { get; private set; }
    public GameObject Cutter;
    public GameObject GameOverScene;
    public bool goSol = false;
    public bool goSag = false;
    public bool Movement = true;

    // Start is called before the first frame update

    private void Awake()
    {
        
        if (!Instance)
        {
            Instance = this;
        }
    }


    void Start()
    {
        Cutter = GameObject.FindGameObjectWithTag("Player");
        GameOverScene = GameObject.FindGameObjectWithTag("GameOver");
        GameOverScene.SetActive(false);

    }

    public void GameOver()
    {
        GameOverScene.SetActive(true);
    }

    public void restartGame()
    {
        Application.LoadLevel(0);
    }

}
