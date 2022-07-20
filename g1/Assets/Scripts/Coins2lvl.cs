using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins2lvl : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            MoneyText2lvl.Coins2lvl+= 1;
            
            Destroy(gameObject);
        }

    }
}
