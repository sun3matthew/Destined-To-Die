using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    // Start is called before the first frame update
    private static float width = 30;

    public int emissionDensity;

    private int emissionIndx;

    [SerializeField]
    private GameObject raindrop;

    private Transform follow;

    private bool fullEnable;

    private RainDrop[] rainDrops;

    private float groupOffset = 0;
    private float windOffset = 0;


    private float perlinPos1, perlinPos2, perlinPos3 = 0;
    void Start()
    {
        perlinPos1 = Random.Range(0f, 100000f);
        perlinPos2 = Random.Range(0f, 100000f);
        rainDrops = new RainDrop[3000];
        Transform temp = GameObject.Find("RainDropHolder(Clone)").transform;//new GameObject("RainDropHolder").transform;
        for(int i = 0; i < rainDrops.Length; i++)
            rainDrops[i] = Instantiate(raindrop, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0), temp).GetComponent<RainDrop>();
        for (int i = 0; i < rainDrops.Length; i++)
        {
            int randomR = Random.Range(0, 5);
            SpriteRenderer srTemp = rainDrops[i].GetComponent<SpriteRenderer>();
            srTemp.sortingOrder = 100;
            if (randomR == 0)
            {
                srTemp.sortingLayerName = "Back1";
                srTemp.color = new Color(1, 1, 1, 0.4f);
            }
            else if( randomR == 1)
            {
                srTemp.sortingLayerName = "Back";
                srTemp.color = new Color(1, 1, 1, 0.55f);
            }
            else if (randomR == 2)
            {
                srTemp.sortingLayerName = "Mid";
                srTemp.color = new Color(1, 1, 1, 0.8f);
            }
            else if (randomR == 3)
            {
                srTemp.sortingLayerName = "Front1";
                srTemp.color = new Color(1, 1, 1, 0.95f);
            }
            else if (randomR == 4)
            {
                srTemp.sortingLayerName = "Front";
                srTemp.color = new Color(1, 1, 1, 1);
            }
            srTemp.color += new Color(0, 0, 0, Random.Range(-0.1f, 0.1f));
        }
        follow = null;//GameObject.FindGameObjectWithTag("Player").transform;
        transform.position = new Vector3(78.5f, 6.27f) + new Vector3(0, 8, 0);
        spriteShown(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (follow == null)
            follow = Camera.main.transform;
        if (fullEnable)
            transform.position = follow.position + new Vector3(0, 8, 0);
        //tempGroupPos = Mathf.PerlinNoise(perlinPos1, 0) * width/2 - wd;
        groupOffset = Mathf.PerlinNoise(perlinPos1, 0) * 24 - 12;
        windOffset = Mathf.PerlinNoise(perlinPos2, 0) * 4 - 2;
        //print(windOffset);
        for (int i = 0; i < emissionDensity; i += 2)
        {
            rainDrops[emissionIndx].setup(transform.position + new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(-1.0f, 1.0f)), Random.Range(1f, 3.5f), windOffset * 0.25f + Random.Range(-0.05f, 0.05f));
            rainDrops[emissionIndx+1].setup(transform.position + new Vector3(Random.Range(-3f, 3f) + groupOffset, Random.Range(-0.5f, 0.5f)), Random.Range(1.5f, 2f), windOffset + Random.Range(-0.05f, 0.05f));
            emissionIndx += 2;
            if (emissionIndx >= rainDrops.Length - 1)
                emissionIndx = 0;
        }
        perlinPos1 += 0.05f;
        perlinPos2 += 0.002f;
    }
    public void spriteShown(bool show)
    {
        fullEnable = show;
        for (int i = 0; i < rainDrops.Length; i++)
            rainDrops[i].GetComponent<SpriteRenderer>().enabled = fullEnable;
    }
}
