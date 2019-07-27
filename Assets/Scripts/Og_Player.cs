using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Og_Player : MonoBehaviour
{

    Rigidbody m_Rigidbody;

    // Use this for initialization
    void Start()
    {
        // 自分のRigidbodyを取ってくる
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = 0.0f;
        float z = 0.0f;
        Vector2 touchPadPt = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);

        //右方向
        if (touchPadPt.x > 0.5 && -0.5 < touchPadPt.y && touchPadPt.y < 0.5)
        {
            // 十字キーで首を左右に回す
            transform.Rotate(new Vector3(0.0f, 0.5f, 0.0f)); 
            x += 0.5f;
        }
        //左方向
        if (touchPadPt.x < -0.5 && -0.5 < touchPadPt.y && touchPadPt.y < 0.5)
        {
            // 十字キーで首を左右に回す
            transform.Rotate(new Vector3(0.0f, -0.5f, 0.0f));
            x -= 0.5f;
        }
        //上方向
        if (touchPadPt.y > 0.5 && -0.5 < touchPadPt.x && touchPadPt.x < 0.5)
        {
            z += 5.0f;
        }
        //下方向
        if (touchPadPt.y < -0.5 && -0.5 < touchPadPt.x && touchPadPt.x < 0.5)
        {
            z -= 5.0f;
        }

        m_Rigidbody.velocity = z * transform.forward + x * transform.right;
    }

}