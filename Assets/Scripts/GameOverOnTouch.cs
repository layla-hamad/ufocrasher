using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnTouch : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            // get the UFO componennt from the UFO Gameobject and call Damage
            collision.GetComponent<UFO>().Damage();
        }
    }
}
