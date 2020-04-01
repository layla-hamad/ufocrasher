using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// GameController is present over the whole game (Menu & Level) and controls for example the menu to game switch
/// </summary>
public class GameController : MonoBehaviour
{
    /// <summary>
    /// Instance of the singleton with a private setter and a public getter
    /// </summary>
    public static GameController Instance { get; private set; }


    /// <summary>
    /// Awake is called when the script instance is being loaded
    /// </summary>
    private void Awake()
    {
        //if already an instance exists destroy this gameobject
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            //make this object a singleton
            Instance = this;
            //do not destroy this object on scene switch
            DontDestroyOnLoad(gameObject);
        }
    }


    /// <summary>
    /// Loads the game scene, is called by Unity-button in menu scene
    /// </summary>
    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    /// <summary>
    /// Quits the game, is called by Unity-button in menu scene
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }


    /// <summary>
    /// Loads the menu scene, is called by pressing a key after a game over
    /// </summary>
    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
