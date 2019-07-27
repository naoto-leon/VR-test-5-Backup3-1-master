using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Point_Laser_Start : MonoBehaviour
{

    // 右手
    [SerializeField]
    private Transform _RightHandAnchor;

    // 左手
    [SerializeField]
    private Transform _LeftHandAnchor;

    // 目の中心
    [SerializeField]
    private Transform _CenterEyeAnchor;

    // 距離
    [SerializeField]
    private float _MaxDistance = 100.0f;

    // LineRenderer
    [SerializeField]
    private LineRenderer _LaserPointerRenderer;
    //LineRenderer = ラインの描画


    // コントローラー
    private Transform Pointer
    {
        get
        {
            // 現在アクティブなコントローラーを取得
            var controller = OVRInput.GetActiveController();
            if (controller == OVRInput.Controller.RTrackedRemote)
            {
                return _RightHandAnchor;
            }
            else if (controller == OVRInput.Controller.LTrackedRemote)
            {
                return _LeftHandAnchor;
            }

            //上が右手、下が左手　
            // どちらも取れなければ目の間からビームが出る
            return _CenterEyeAnchor;
        }
    }

    void Update()
    {



        // コントローラーを取得
        var pointer = Pointer;//var=transform pointer 

        // コントローラーがない or LineRendererがなければ何もしない
        if (pointer == null || _LaserPointerRenderer == null)
        {
            return;
        }

        // コントローラー位置からRayを飛ばす
        Ray pointerRay = new Ray(pointer.position, pointer.forward);

        // レーザーの起点
        _LaserPointerRenderer.SetPosition(0, pointerRay.origin);

        ///ここ謎　
        RaycastHit hitInfo;
        if (Physics.Raycast(pointerRay, out hitInfo, _MaxDistance))
        {
            // Rayがヒットしたらそこまで
            _LaserPointerRenderer.SetPosition(1, hitInfo.point);

            GameObject obj = hitInfo.collider.gameObject;

        }
        else
        {
            // Rayがヒットしなかったら向いている方向にMaxDistance伸ばす
            _LaserPointerRenderer.SetPosition(1, pointerRay.origin + pointerRay.direction * _MaxDistance);
        }

        if (hitInfo.collider.tag == "Start")
        {

            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                SceneManager.LoadScene("Main");
            }
        }

    }
}



//private void Shot(Transform pointer)
//{
//var BuletInstance = Instantiate(bulletPrefab, pointer.position, pointer.rotation) as GameObject;

///例えば，生成したオブジェクトの名前を変更する処理を行うとする．
///   弾丸を生成し，その弾丸の名前を"Bullet"にしたい場合，以下のスクリプトでできる．
///オブジェクトを変数名bulletで生成
///GameObject bullet = Instantiate(obj) as GameObject;
//名前を変更
///     bullet.name = "Bullet";
/// 生産したオブジェクトに対してなんらかの処理をしたい時,ここではrigidbodyにaddfoece　

//BuletInstance.GetComponent<Rigidbody>().AddForce(BuletInstance.transform.forward*powerbullet);
//https://docs.unity3d.com/ja/current/ScriptReference/Rigidbody.AddForce.html 

//Destroy(BuletInstance, 5F);










