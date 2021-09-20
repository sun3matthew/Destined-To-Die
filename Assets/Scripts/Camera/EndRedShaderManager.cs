using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRedShaderManager : MonoBehaviour
{
    [SerializeField]
    public Shader shader;
    private Material material;

    private float timer;

    void Start()
    {
        timer = 0;
        material = new Material(shader);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        timer += Time.deltaTime;
        float multi = 0;
        if(timer > 23)
            multi = (29-timer) / 6f;
        else
            multi = (timer - 5) / 17f;
        if (multi < 0)
            multi = 0;
        material.SetFloat("r", 0.6f * multi);
        Graphics.Blit(source, destination, material);
    }
}
