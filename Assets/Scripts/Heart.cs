using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Behaviour of one heart
/// </summary>
public class Heart : MonoBehaviour
{
    private Image image;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // get the needed components of this gameobject
        image = GetComponent<Image>();
    }


    /// <summary>
    /// Makes the heart disappear
    /// </summary>
    public void HeartDisappear()
    {
        image.color = Color.clear;
    }
}
