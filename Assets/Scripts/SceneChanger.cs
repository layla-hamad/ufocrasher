using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public void SelectScene()
    {
        switch (this.gameObject.name)
        {
            case "StartGameButton":
                SceneManager.LoadScene("GameScene");
                break;
            case "QuitGameButton":
                Application.Quit();
                break;
        }

    }
}
