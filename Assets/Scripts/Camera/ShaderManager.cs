using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderManager : MonoBehaviour
{
    [SerializeField]
    public Shader shader;
    private Material material;

    private Player player;
    private AudioLowPassFilter lp;
    private GameObject computer;

    private float happy;
    private float gray;

    public float r,b,g;

    private float timer;
    private float happyTime;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        computer = GameObject.Find("ComputerB(Clone)").transform.GetChild(0).gameObject;
        material = new Material(shader);
        lp = GetComponent<AudioLowPassFilter>();
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        happy = player.happySmooth;
        gray = player.graySmooth;
        material.SetFloat("grayscale", gray < -10 ? (gray + 10) / 100 : 0);

        if(happy > -20 || computer.activeSelf)
        {
            material.SetFloat("offsetUpAmt", 0);
            material.SetFloat("offsetDownAmt", 0);
            material.SetVector("glitch", new Vector4());
        }
        else
        {
            float happyNorm = (happy * -1) / 100f;
            timer += Time.deltaTime;
            if(timer > (happyTime/3f) * 2f)
            {
                material.SetFloat("offsetUpAmt", 0);
                material.SetFloat("offsetDownAmt", 0);
                material.SetVector("glitch", new Vector4());
            }
            if (timer > happyTime)
            {
                print("ASDADASDAS");
                timer = 0;
                happyTime = Random.Range(0.5f, 6f - 5f * happyNorm);
                material.SetFloat("offsetUpAmt", Random.Range(0, 2));
                material.SetFloat("offsetDownAmt", Random.Range(0, 2));
                material.SetVector("glitch", new Vector4(Random.Range(-1f, 1f) * happyNorm, Random.Range(-1f, 1f) * happyNorm, 1, 0));
            }
        }
        lp.cutoffFrequency = Mathf.Pow((happy + 100), 2) + 200;
        material.SetFloat("r", r);
        material.SetFloat("g", g);
        material.SetFloat("b", b);
        Graphics.Blit(source, destination, material);
    }
}
