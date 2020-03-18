using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    private Renderer render;
    void Start()
    {
        // get the needed components of this gameobject
        render = GetComponent<Renderer>();
    }

    public void HeartDisappear()
    {
        render.material.color = Color.clear;
    }
}
