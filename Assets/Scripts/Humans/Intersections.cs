using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Intersections
{
    //[SerializeField]
    public static Vector2[] intersections = {
        new Vector2(88.2f, 10.3f),//0
        new Vector2(87f, 10.9f),//1
        new Vector2(85.9f, 11.4f),//2
        new Vector2(84.8f, 11.9f),//3
        new Vector2(82.1f, 10.5f),//4
        new Vector2(83.2f, 10f),//5
        new Vector2(84.4f, 9.5f),//6
        new Vector2(85.6f, 8.9f),//7
        new Vector2(79.2f, 9.1f),//8
        new Vector2(80.3f, 8.6f),//9
        new Vector2(81.4f, 8.1f),//10
        new Vector2(82.6f, 7.5f),//11
        new Vector2(75.2f, 7.1f),//12
        new Vector2(76.3f, 6.6f),//13
        new Vector2(77.4f, 6.1f),//14
        new Vector2(78.6f, 5.5f),//15
        new Vector2(71f, 7.8f),//16
        new Vector2(72.1f, 7.2f),//17
        new Vector2(73.1f, 6.7f),//18
        new Vector2(74.2f, 6.2f),//19
        new Vector2(75.3f, 5.7f),//20
        new Vector2(76.2f, 5.1f),//21
        new Vector2(70.2f, 6.7f),//22
        new Vector2(71.3f, 6.2f),//23
        new Vector2(72.3f, 5.7f),//24
        new Vector2(73.4f, 5.1f),//25
        new Vector2(74.5f, 4.6f),//26
        new Vector2(75.5f, 4f),//27
        new Vector2(68.2f, 6.3f),//28
        new Vector2(69.3f, 5.8f),//29
        new Vector2(70.3f, 5.3f),//30
        new Vector2(71.4f, 4.7f),//31
        new Vector2(72.5f, 4.2f),//32
        new Vector2(73.4f, 3.6f),//33
        new Vector2(67.1f, 5.1f),//34
        new Vector2(68.2f, 4.6f),//35
        new Vector2(69.2f, 4.1f),//36
        new Vector2(70.3f, 3.5f),//37
        new Vector2(71.4f, 3f),//38
        new Vector2(72.3f, 2.4f),//39
        new Vector2(64.9f, 4.6f),//40
        new Vector2(66f, 4.1f),//41
        new Vector2(67f, 3.6f),//42
        new Vector2(68.1f, 3f),//43
        new Vector2(69.2f, 2.5f),//44
        new Vector2(70.1f, 1.9f),//45
        new Vector2(63.7f, 3.4f),//46
        new Vector2(64.7f, 2.9f),//47
        new Vector2(65.8f, 2.4f),//48
        new Vector2(66.8f, 1.9f),//49
        new Vector2(67.9f, 1.4f),//50
        new Vector2(68.9f, 0.8f),//51
        new Vector2(60.2f, -1.3f)//52

    };
    public static Vector2 getPoint(int value) => intersections[value];
}