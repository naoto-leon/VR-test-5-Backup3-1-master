using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Renderer co;


    // Start is called before the first frame update
    void Start()
    {
        co = GetComponent<Renderer>();
  
    }

    // Update is called once per frame
    void Update()
    {
     

        if (Music.IsJustChanged)
        {       // ユニットが変わったフレームで true になる
            co.material.color = Color.red;
        }

        if (Music.IsJustChangedBar())
        {   // 小節に来たフレームで true になる
            //こない　
            co.material.color = Color.blue;
        }

        if (Music.IsJustChangedBeat())
        {   // 拍に来たフレームで true になる
            co.material.color = Color.yellow;
        }

        //if (Music.IsJustChangedAt())
        //{// 指定した小節、拍、ユニットに来たフレームで true になる
        //    print("IsJustChangedAt");
        //    co.material.color = Color.blue;
        //}
    }
}
