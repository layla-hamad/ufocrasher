using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverText : MonoBehaviour
{
    // Start is called before the first frame update

    private TMP_Text gameOverText;
    public Color gameOverColor;

    void Start()
    {
        gameOverText = GetComponent<TMP_Text>();
        gameOverText.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowGameOver()
    {
        gameOverText.color = gameOverColor;
    }
}
