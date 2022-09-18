using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionMoveScene : MonoBehaviour
{

   void getIndex() {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.buildIndex);
        SceneManager.LoadScene(scene.buildIndex + 1);

    }

    private void OnTriggerEnter2D()
    {
      
        getIndex();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
