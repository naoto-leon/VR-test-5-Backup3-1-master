using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxLine : MonoBehaviour
{
    [SerializeField]
     int NUM;


    public GameObject PrefabLineBox;
    public GameObject[] LineBox;

    [SerializeField]
    private float time0;
    [SerializeField]
    private float time1;
    [SerializeField]
    private float time2;
    [SerializeField]
    private float time3;
    [SerializeField]
    private float time4;
    [SerializeField]
    private float time5;
    [SerializeField]
    private float time6;
    [SerializeField]
    private float time7;
    [SerializeField]
    private float time8;
    [SerializeField]
    private float time9;
    [SerializeField]
    private float time10;

    [SerializeField]
    private float moveTime0;
    [SerializeField]
    private float moveTime1;
    [SerializeField]
    private float moveTime2;
    [SerializeField]
    private float moveTime3;
    [SerializeField]
    private float moveTime4;
    [SerializeField]
    private float moveTime5;
    [SerializeField]
    private float moveTime6;
    [SerializeField]
    private float moveTime7;
    [SerializeField]
    private float moveTime8;
    [SerializeField]
    private float moveTime9;
    [SerializeField]
    private float moveTime10;


    //MeshRenderer meshRenderer;


    // Start is called before the first frame update
    void Start()
    {
        var parent = this.transform;
        
        LineBox = new GameObject[NUM];
        
        //meshRenderer = GetComponent<MeshRenderer>();

        for (int i = 0; i < LineBox.Length; i++)
        {
            LineBox[i] = (GameObject)Instantiate(PrefabLineBox, new Vector3(0f, -1.2f, 70 - (i*5)), Quaternion.identity,parent);
            LineBox[i] = transform.GetChild(i).gameObject;

            //Debug.Log(LineBox[1]);

        }

        var LB0 = LineBox[0].GetComponent<MeshRenderer>();
        var LB1 = LineBox[1].GetComponent<MeshRenderer>();
        var LB2 = LineBox[2].GetComponent<MeshRenderer>();
        var LB3 = LineBox[3].GetComponent<MeshRenderer>();
        var LB4 = LineBox[4].GetComponent<MeshRenderer>();
        var LB5 = LineBox[5].GetComponent<MeshRenderer>();
        var LB6 = LineBox[6].GetComponent<MeshRenderer>();
        var LB7 = LineBox[7].GetComponent<MeshRenderer>();
        var LB8 = LineBox[8].GetComponent<MeshRenderer>();
        var LB9 = LineBox[9].GetComponent<MeshRenderer>();
        //var LB10 = LineBox[10].GetComponent<MeshRenderer>();



        LB0.material.SetFloat("_time", time0);
        LB1.material.SetFloat("_time", time1);
        LB2.material.SetFloat("_time", time2);
        LB3.material.SetFloat("_time", time3);
        LB4.material.SetFloat("_time", time4);
        LB5.material.SetFloat("_time", time5);
        LB6.material.SetFloat("_time", time6);
        LB7.material.SetFloat("_time", time7);
        LB8.material.SetFloat("_time", time8);
        LB9.material.SetFloat("_time", time9);
        //LB10.material.SetFloat("_time", time10);


        LB0.material.SetFloat("_moveTime", moveTime0);
        LB1.material.SetFloat("_moveTime", moveTime1);
        LB2.material.SetFloat("_moveTime", moveTime2);
        LB3.material.SetFloat("_moveTime", moveTime3);
        LB4.material.SetFloat("_moveTime", moveTime4);
        LB5.material.SetFloat("_moveTime", moveTime5);
        LB6.material.SetFloat("_moveTime", moveTime6);
        LB7.material.SetFloat("_moveTime", moveTime7);
        LB8.material.SetFloat("_moveTime", moveTime8);
        LB9.material.SetFloat("_moveTime", moveTime9);
        //LB10.material.SetFloat("_moveTime", moveTime10);

        //Debug.Log(LineBox[0]);
        //Debug.Log(LineBox[1]);
        //Debug.Log(LineBox[2]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
