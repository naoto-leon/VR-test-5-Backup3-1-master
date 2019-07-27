using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioSpectrum spectrum;
    public GameObject[] BallParticle;

    private float m1st;
    private float m2st;
    private float m3st;



    ParticleSystem.MainModule main1;
    ParticleSystem.MainModule main2;
    ParticleSystem.MainModule main3;


    // Start is called before the first frame update
    void Start()
    {

        m1st = 41.5f;
        m2st = 38f;
        m3st = 45;

        BallParticle = new GameObject[transform.childCount];

        for (int i = 0; i < BallParticle.Length; i++)
        {
            BallParticle[0] = transform.GetChild(0).gameObject;
            BallParticle[1] = transform.GetChild(1).gameObject;
            BallParticle[2] = transform.GetChild(2).gameObject;

            var Par1 = BallParticle[0].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var Par2 = BallParticle[1].GetComponent(typeof(ParticleSystem)) as ParticleSystem;
            var Par3 = BallParticle[2].GetComponent(typeof(ParticleSystem)) as ParticleSystem;

            main1 = Par1.main;
            main2 = Par2.main;
            main3 = Par3.main;

        }


    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < BallParticle.Length; i++)
        {
            main1.startSize = (spectrum.MeanLevels[0]*500) + m1st;
            main2.startSize = (spectrum.MeanLevels[1]*500) + m2st;
            main3.startSize = (spectrum.MeanLevels[2]*500) + m3st;

        }

    }

}
