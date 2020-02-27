﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static GameController instance;
    public static GameController Instance => instance;



    private void Awake()
    {
        //if already an instance exists destroy this gameobject
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            //make this object a singleton
            instance = this;
            //do not destroy this object on scene switch
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
