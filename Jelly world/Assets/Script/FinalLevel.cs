using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevel : MonoBehaviour
{
 
    public int index;

    // Update is called once per frame
    void Update()
    {
        
        //print(GameObject.FindGameObjectsWithTag("Enemy").Length);

        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0) // To Complete the game
        {
           
           SceneManager.LoadScene(index);
        }
    }
}
