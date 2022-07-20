using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Port2lvl : MonoBehaviour
{
    
   

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Player")

            if(killmob.hp==0)       
                {
               
                SceneManager.LoadScene(3);
                
                }

    }
}
