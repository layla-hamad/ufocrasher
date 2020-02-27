using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyscraperSpawner : MonoBehaviour
{
    public GameObject skyscraper;
    public float deltaSpawnTimeMin;
    public float deltaSpawnTimeMax;

    public float deltaHeight;

    private float nextSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time + GetRandomTimeDelta();
    }

    // Update is called once per frame
    void Update()
    {
        // if the game is not running do not spawn skyscrapers
        if (!LevelController.Instance.GameIsRunning) return;

        // when the delta spawn time was awaited
        if (Time.time > nextSpawnTime)
        {
            // set the next spawn time to a time in the future
            nextSpawnTime = Time.time + GetRandomTimeDelta();

            // spawn a new skyscraper at a random position with no rotation
            Instantiate(skyscraper, GetRandomPos(), Quaternion.identity);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position - new Vector3(0.5f, deltaHeight), transform.position - new Vector3(-0.5f, deltaHeight));
        Gizmos.DrawLine(transform.position + new Vector3(0.5f, deltaHeight), transform.position + new Vector3(-0.5f, deltaHeight));

    }

    private float GetRandomTimeDelta()
    {
        return Random.Range(deltaSpawnTimeMin, deltaSpawnTimeMax);
    }

    private Vector2 GetRandomPos()
    {
        var y = Random.Range(transform.position.y - deltaHeight, transform.position.y + deltaHeight);
        return new Vector2(transform.position.x, y);
    }
}
