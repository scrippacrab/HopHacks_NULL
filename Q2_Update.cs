using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Q2_Update : MonoBehaviour
{
    public TMP_Text r2;


    // Start is called before the first frame update
    void Start()
    {
        r2.text = ReadInput2.input2;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

