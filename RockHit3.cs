using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockHit3 : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {

        SceneManager.LoadScene(11);
    }

}
