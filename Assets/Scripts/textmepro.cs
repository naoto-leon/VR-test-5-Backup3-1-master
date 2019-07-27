using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textmepro : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI CountText;

  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       CountText = gameObject.GetComponent<TextMeshProUGUI>();
        CountText.text = Player.Combo.ToString();
    }
}
