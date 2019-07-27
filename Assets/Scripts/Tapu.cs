using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tapu : MonoBehaviour
{

    MeshRenderer meshRenderer;

    public GameObject HeartEfect;
    public static bool TapuEect;

    Transform trans;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        TapuEect = false;

        //Vector3 pos = trans.position;
        //pos.y = +0.2f;
        

        //trans.position = pos;

    }

    // Update is called once per frame
   public void Update()
    {
        if (TapuEect == true)
        {
            meshRenderer.material.SetFloat("_TapuTapuHigh", Player.Point);
            GameObject HeartPact = (GameObject)Instantiate(HeartEfect, transform.position, transform.rotation);
            Destroy(HeartPact, .1f);

            TapuEect = false;
        }


    }
}
