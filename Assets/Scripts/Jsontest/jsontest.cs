using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class jsontest : MonoBehaviour
{
    [System.Serializable]
    public class MakeNote
    {
        //public float Timing[];
        public float[] MusicScore;
        public int[] NoteKind;
     
    }
    float TimeCount;

    // Start is called before the first frame update
    void Start()
    {
        MakeNote mk = new MakeNote();
        string json = File.ReadAllText("Assets//Test.json");
        JsonUtility.FromJsonOverwrite(json, mk);
        //読み込んだ内容がmsに反映されます。

        //Debug.Log(mk);

    }

    // Update is called once per frame
    void Update()
    {

        TimeCount += Time.deltaTime;

        //if (TimeCount >= mk.MusicScore[i])
    }
}
