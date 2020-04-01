using UnityEngine;


/// <summary>
/// Spawns skycrapers at an interval of a randomly generated number of seconds between deltaSpawnTimeMin 
/// and deltaSpawnTimeMax in a random position between - deltaHeight and deltaHeight
/// </summary>
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


    /// <summary>
    /// Draws lines in the editor to display the max and min spawn position
    /// </summary>
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position - new Vector3(0.5f, deltaHeight), transform.position - new Vector3(-0.5f, deltaHeight));
        Gizmos.DrawLine(transform.position + new Vector3(0.5f, deltaHeight), transform.position + new Vector3(-0.5f, deltaHeight));
    }


    /// <summary>
    /// Returns a random float between deltaSpawnTimeMin and deltaSpawnTimeMax
    /// </summary>
    private float GetRandomTimeDelta()
    {
        return Random.Range(deltaSpawnTimeMin, deltaSpawnTimeMax);
    }


    /// <summary>
    /// Returns a random position between - deltaHeight and deltaHeight
    /// </summary>
    private Vector2 GetRandomPos()
    {
        var y = Random.Range(transform.position.y - deltaHeight, transform.position.y + deltaHeight);
        return new Vector2(transform.position.x, y);
    }
}
