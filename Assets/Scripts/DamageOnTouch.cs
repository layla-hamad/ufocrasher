using UnityEngine;

/// <summary>
/// Causes the player to take damage when colliding with a game object which uses this script
/// </summary>
public class DamageOnTouch : MonoBehaviour
{

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this object (2D physics only)
    /// </summary>
    /// <param name="collision">The other Collider2D involved in this collision</param>
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // if the colliding object is the player
        if(collision.tag == "Player")
        {
            // get the UFO component from the UFO Gameobject and call Damage
            collision.GetComponent<UFO>().Damage();
        }
    }
}
