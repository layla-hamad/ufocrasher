using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyscraper : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Moves the object to left with the factor speed, normalized 
         * with the deltaTime (time between the last frame and this frame)
         */
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
