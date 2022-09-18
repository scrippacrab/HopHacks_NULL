using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput2 : MonoBehaviour
{

    public static string input2;

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

        input2 = s;
        Debug.Log(input2);
    }
}
