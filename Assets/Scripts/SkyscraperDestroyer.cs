using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Destroys the skyscaper on collision
/// </summary>
public class SkyscraperDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Skyscraper")
        {
            Destroy(collision.gameObject);
        }
    }
}
