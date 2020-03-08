using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the levelflow, is a singleton (only one instance exists)
/// </summary>
public class LevelController : MonoBehaviour
{

    public Score score; // reference to Score-behaviour
    public UFO ufo; // reference to UFO-behaviour
    public GameOverText gameovertext; // reference to GameOverText-behaviour


    /// <summary>
    /// Reference to the singleton
    /// C# Property public setter private getter
    /// </summary>
    public static LevelController Instance { get; private set; }

    /// <summary>
    /// True when the game is running and the player is alive.
    /// C# Property public setter private getter
    /// </summary>
    public bool GameIsRunning { get; private set; }

    private void Awake()
    {
        // if already an instance exists destroy this gameObject
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            //make this object a singleton
            Instance = this;
        }
    }

    public void StartGame()
    {
        GameIsRunning = true;
    }

    public void GameOver()
    {
        GameIsRunning = false;
        gameovertext.ShowGameOver();
    }
}
