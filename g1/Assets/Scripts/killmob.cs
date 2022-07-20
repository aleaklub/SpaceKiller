using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killmob : MonoBehaviour
{
    public GameObject other;
    public static int hp=5;
   

   
    void Update()
    {
        if (hp == 0)
        {
            Destroy(other);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hp-= 1;
            
        }
    }
}
