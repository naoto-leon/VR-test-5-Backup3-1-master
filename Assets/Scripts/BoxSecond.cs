using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSecond : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;

    private Transform target;

    private int PointIndex = 0;

    void Start()
    {
        target = WayPointsSecond.Points[0];
    }



    void Update()
    {
        //transform.position += Time.deltaTime * transform.forward * speed;


        //実験　発生後移動　boxの種類ごとにスクリプトを変える
        Vector3 dir = target.position - transform.position;

        //向き取得　

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= .4f)
        {
            GetNextWaypoint();
        }

    }


    void GetNextWaypoint()
    {
        PointIndex++;

        target = WayPointsSecond.Points[PointIndex];
    }



}
