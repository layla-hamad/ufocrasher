﻿using UnityEngine;

/*06.04.20
 * UFOCrasher
 * Kimberly Schmid, Layla Hamad und Amrit Kaur
 * Aufteilung: Gemischt. Jede hatte probiert zu Programmieren und Kommentieren wo es ging. 
 * Bei Schwierigkeiten lösten wir dann den Teil zusammen. 
 * Hauptquelle: Keine 
 */
/// <summary>
/// Defines the properties of the UFO game object
/// </summary>
public class UFO : MonoBehaviour
{
    public Heart heart_1, heart_2, heart_3;

    /// <summary>
    /// Upwards force applied to the UFOs rigidbody when jump is pressed
    /// </summary>
    public float jumpforce = 600f;

    /// <summary>
    /// The period of time in which UFO is invincible after having taken damage
    /// </summary>
    public float deltaInvicibleTime = 2f;

    /// <summary>
    /// The color the UFO has after having taken damage
    /// </summary>
    public Color damageColor;

    /// <summary>
    /// The rigidbody controls the physics of this object
    /// </summary>
    private Rigidbody2D rigidbody;
    /// <summary>
    /// The renderer controls the appearance of this object
    /// </summary>
    private Renderer render;

    public int life = 3;
    private float timeUntilVunerable = 0f;

    /// <summary>
    /// The life of the UFO: when zero, UFO dies
    /// </summary>
    private int Life
    {
        get => life;
        set
        {
            life = value;
            if(life <= 0)
            {
                Die();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // get the needed components of this gameobject
        rigidbody = GetComponent<Rigidbody2D>();
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!LevelController.Instance.GameIsRunning)
            {
                LevelController.Instance.StartGame();
                rigidbody.isKinematic = false;
                rigidbody.AddForce(Vector2.down * jumpforce/2);
            }
            rigidbody.AddForce(Vector2.up * jumpforce);
        }
    }

    /// <summary>
    /// Damage the UFO, the UFO loses one life and is invicible for a short time.
    /// </summary>
    public void Damage()
    {
        if(Time.time > timeUntilVunerable)
        { 
            Life--;
            timeUntilVunerable = Time.time + deltaInvicibleTime;
            render.material.color = damageColor;
            // Invoke the method RevertDamageColor() after deltaInvincibleTime
            Invoke(nameof(RevertDamageColor), deltaInvicibleTime);
            switch (Life)
            {
                case 2:
                    heart_3.HeartDisappear();
                    break;
                case 1:
                    heart_2.HeartDisappear();
                    break;
                case 0:
                    heart_1.HeartDisappear();
                    break;
            }
        }
 
    }


    /// <summary>
    /// Reverts color to normal
    /// </summary>
    private void RevertDamageColor()
    {
        render.material.color = Color.white;
    }


    /// <summary>
    /// Destroys the UFO and ends the game
    /// </summary>
    public void Die()
    {
        Destroy(gameObject);
        LevelController.Instance.GameOver();
    }
}
