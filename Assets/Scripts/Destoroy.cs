using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoroy : MonoBehaviour
{


     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BoxIcon")
        {
            Destroy(other.gameObject);
            Player.Combo = 0;
        }
    }
}
