using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPassword : MonoBehaviour
{
    private string input;

    private void Start()
    {
        
    }

    public void ReadStringInput (string s)
    {
        input = s;
        Debug.Log(input);
    }

}
