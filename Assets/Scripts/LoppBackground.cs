using UnityEngine;

public class LoppBackground : MonoBehaviour
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
        offset = Mathf.Repeat(offset + Time.deltaTime * speed, 1f);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
