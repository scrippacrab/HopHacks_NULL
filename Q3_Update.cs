using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Q3_Update : MonoBehaviour
{
    public TMP_Text r3;


    // Start is called before the first frame update
    void Start()
    {
        r3.text = ReadInput3.input3;
    }

    // Update is called once per frame
    void Update()
    {

    }
}