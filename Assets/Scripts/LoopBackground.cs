using UnityEngine;

/// <summary>
/// Loops the background image horizontally
/// </summary>
public class LoopBackground : MonoBehaviour
{
    public float speed = 0.5f;
    private float offset = 0f;
    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        // if the game is not running do not spawn loop background
        if (!LevelController.Instance.GameIsRunning) return;

        /*
         * set the x offset of the texture.
         * when bigger than 1, start at 0 again (Mathf.Repeat)
         */
        offset = Mathf.Repeat(offset + Time.deltaTime * speed, 1f);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }


    /// <summary>
    /// Resets the texture offset, because this will otherwise be preserved in the materials
    /// </summary>
    private void OnDestroy()
    {
        renderer.sharedMaterial.SetTextureOffset("_MainTex", new Vector2(0, 0));
    }
}
