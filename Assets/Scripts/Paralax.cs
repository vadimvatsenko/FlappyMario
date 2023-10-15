using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    private MeshRenderer m_Renderer;
    public float animationSpeed = 0.1f;

    private void Awake()
    {
        m_Renderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        m_Renderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
