using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput3 : MonoBehaviour
{

    public static string input3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {

        input3 = s;
        Debug.Log(input3);
    }
}
