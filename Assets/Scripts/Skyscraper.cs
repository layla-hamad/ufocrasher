using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyscraper : MonoBehaviour
{
    /// <summary>
    /// The transition speed of the skyscraper
    /// </summary>
    public float speed = 4f;

    private Transform ufoTransform;

    // true when the player got already a point for this skyscraper
    private bool alreadyCounted = false;
    private void Start()
    {
        ufoTransform = LevelController.Instance.ufo.transform;
    }


    // Update is called once per frame
    private void Update()
    {
        // if the game is not running do not move
        if (!LevelController.Instance.GameIsRunning) return;
        /*
         * Moves the object to left with the factor speed, normalized 
         * with the deltaTime (time between the last frame and this frame)
         */
        transform.position += Vector3.left * speed * Time.deltaTime;


        /*  
         *  if the skyscrapers have passed the UFO and the Point has not been counted yet,
         *  the score will be increased by 1.
         */
        if(!alreadyCounted && transform.position.x < ufoTransform.position.x)
        {
            LevelController.Instance.score.GameScore++;
            alreadyCounted = true;
        }
    }
}
