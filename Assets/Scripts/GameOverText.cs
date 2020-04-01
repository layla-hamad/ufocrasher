using UnityEngine;
using TMPro;

public class GameOverText : MonoBehaviour
{
    private TMP_Text gameOverText;
    public Color gameOverColor;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        gameOverText = GetComponent<TMP_Text>();
        gameOverText.color = Color.clear;
    }


    /// <summary>
    /// Shows the gameOverText
    /// </summary>
    public void ShowGameOver()
    {
        gameOverText.color = gameOverColor;
    }
}
