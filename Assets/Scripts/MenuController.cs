using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 
/// </summary>
public class MenuController : MonoBehaviour
{
    public void LoadGame()
    {
        GameController.Instance.LoadGame();
    }

    public void QuitGame()
    {
        GameController.Instance.QuitGame();
    }
}
