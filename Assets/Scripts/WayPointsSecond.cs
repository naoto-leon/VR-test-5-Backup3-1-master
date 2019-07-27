using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointsSecond : MonoBehaviour
{
    public static Transform[] Points;

    // Start is called before the first frame update
    void Awake()
    {
        Points = new Transform[transform.childCount];

        for (int i = 0; i < Points.Length; i++)
        {
            Points[i] = transform.GetChild(i);
        }
    }
}
