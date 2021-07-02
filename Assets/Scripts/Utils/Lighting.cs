using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
    [SerializeField]
    Sprite[] sprites = new Sprite[24];

    SpriteRenderer spriteRenderer;
    SpriteRenderer spriteInterpolate;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        GameObject interpolate = new GameObject("Interpolate");
        spriteInterpolate = interpolate.AddComponent<SpriteRenderer>();
        interpolate.transform.parent = transform;

        spriteInterpolate.sortingLayerName = spriteRenderer.sortingLayerName;
        spriteInterpolate.sortingOrder = spriteRenderer.sortingOrder + 1;

        if (sprites[0] == null)
            sprites[0] = spriteRenderer.sprite;
        for (int i = 1; i < sprites.Length; i++)
            if (sprites[i] == null)
                sprites[i] = sprites[i - 1];
    }

    public void changeLighting(float timeDay)
    {
        int day = (int)timeDay;
        //if()
        spriteRenderer.sprite = sprites[day];
        spriteInterpolate.sprite = sprites[day + 1 == 24 ? 0 : day + 1];
        if (spriteInterpolate.sprite == spriteRenderer.sprite)
        {
            spriteInterpolate.sprite = null;
            spriteRenderer.color = new Color(1, 1, 1, 1);
        }else
        {
            spriteRenderer.color = new Color(1, 1, 1, 1 - (timeDay - day));
            spriteInterpolate.color = new Color(1, 1, 1, timeDay - day);
        }
        //print(spriteInterpolate.sprite == spriteRenderer.sprite);
    }
}
