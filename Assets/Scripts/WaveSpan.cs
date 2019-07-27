using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpan : MonoBehaviour
{
    //public AudioSpectrum spectrum;

    public GameObject[] Cubes;
    public Transform[] Points;

    public GameObject StarParticle;

    // Update is called once per frame
    void Update()
    {
        if (Music.IsJustChangedBeat())
        {
            
            GameObject cube = Instantiate(Cubes[Random.Range(0, 4)], Points[Random.Range(0, 2)]);
           
            GameObject StPa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
            Destroy(StPa, .5f);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward * 90, Random.Range(0, 2));

            //新しいparticle -1ようのを作れば　ダブル可能　（実証済みだがそこまでw猛者を感じない）
            //GameObject cuben = Instantiate(Cubes[Random.Range(0, 2)], Points[Random.Range(3, 4)]);
            //GameObject StPaa = (GameObject)Instantiate(StarParticle, cube.transform.position, cube.transform.rotation);
            //Destroy(StPaa, .5f);
            //cuben.transform.localPosition = Vector3.zero;
            //cuben.transform.Rotate(transform.forward * 90, Random.Range(0, 4));
        }

        //for (int i = 0; i < Points.Length; i++)
        //{
            //if (spectrum.MeanLevels[0]*100 < 1f)
            //{
            //    GameObject cube = Instantiate(Cubes[Random.Range(0, 2)], Points[0]);
            //    cube.transform.localPosition = Vector3.zero;
            //    cube.transform.Rotate(transform.forward * 90, Random.Range(0, 4));

              
            //}
            //if (spectrum.MeanLevels[1] < 0.005f)
            //{
            //    GameObject cube = Instantiate(Cubes[Random.Range(0, 2)], Points[1]);
            //    cube.transform.localPosition = Vector3.zero;
            //    cube.transform.Rotate(transform.forward * 90, Random.Range(0, 4));
            //}
            //if (spectrum.MeanLevels[2] < 0.005f)
            //{
            //    GameObject cube = Instantiate(Cubes[Random.Range(0, 2)], Points[2]);
            //    cube.transform.localPosition = Vector3.zero;
            //    cube.transform.Rotate(transform.forward * 90, Random.Range(0, 4));
            //}
            //if (spectrum.MeanLevels[3] < 0.005f)
            //{
            //    GameObject cube = Instantiate(Cubes[Random.Range(0, 2)], Points[3]);
            //    cube.transform.localPosition = Vector3.zero;
            //    cube.transform.Rotate(transform.forward * 90, Random.Range(0, 4));
            //}


        }




    void SpanWave()
    {

    }


}
