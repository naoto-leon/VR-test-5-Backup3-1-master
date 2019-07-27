using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectramSounded : MonoBehaviour
{
    public AudioSpectrum spectrum;
    public GameObject[] box;
    public GameObject[] box2;
    public float Scale;

    public GameObject preBox;
    public GameObject preBox2;

    [SerializeField]
    int NUM;

    // Start is called before the first frame update
    void Start()
    {
        box = new GameObject[NUM];
        box2 = new GameObject[NUM];

        var parent = this.transform;

        for (int i = 0; i < box.Length; i++)
        {
            box[i] = Instantiate(preBox, new Vector3(32f, +3f, 2 + (i * 2)), Quaternion.identity, parent);
            box2[i] = Instantiate(preBox2, new Vector3(-32f, +3f, 2 + (i * 2)), Quaternion.identity, parent);

            //Debug.Log(LineBox[1]);

        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < box.Length; i++)
        {
            var tests = box[i];
            var localScale = tests.transform.localScale;
            localScale.y = spectrum.MeanLevels[i] * Scale;
            tests.transform.localScale = localScale;

        }
        for (int i = 0; i < box2.Length; i++)
        {
            var testss = box2[i];
            var localScale = testss.transform.localScale;
            localScale.y = spectrum.MeanLevels[i] * Scale;
            testss.transform.localScale = localScale;

        }
    }
}


