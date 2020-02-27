using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshPro

public class Score : MonoBehaviour
{

    private TMP_Text scoreText;

    public int GameScore
    {
        get
        {
            return int.Parse(scoreText.text);
        }
        set
        {
            scoreText.text = value.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }
}
