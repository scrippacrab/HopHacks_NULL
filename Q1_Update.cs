using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Q1_Update : MonoBehaviour
{
    public TMP_Text r1;


    // Start is called before the first frame update
    void Start()
    {
        r1.text = ReadInput.input1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
