using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class open : MonoBehaviour
{
    public GameObject door;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            Destroy(door);

    }
}
