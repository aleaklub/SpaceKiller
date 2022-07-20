using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public static int attemp;
    void Start()
    {
       
    }

    
    void Update()
    {
        attemp = PlayerPrefs.GetInt("attemp", attempText.PlayerGo);
    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Player")
         
           if (MoneyText.Coins >= 18)
        {
               PlayerPrefs.SetInt("attemp", attempText.PlayerGo);
                SceneManager.LoadScene(2);
                MoneyText2lvl.Coins2lvl = MoneyText.Coins;
                attempText2lvl.PlayerGo = attempText.PlayerGo;
        }

    }
}
