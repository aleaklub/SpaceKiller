using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheackpoint : MonoBehaviour
{
    public static int score;
    
    void Start()
    {
        
        if (PlayerPrefs.GetInt("PositionPlayer") == 1)
        {
            transform.position = new Vector2(-36, -3);
        }
        else if (PlayerPrefs.GetInt("PositionPlayer") == 0)
        {
            transform.position = new Vector2(66, 0);
        }

       
    }
    void Update()
    {
        score= PlayerPrefs.GetInt("Score");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("cheackpoint"))
        {
            PlayerPrefs.SetInt("PositionPlayer", 1);
            PlayerPrefs.SetInt("Score", MoneyText2lvl.Coins2lvl);
          
}

       
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("PositionPlayer", 0);
        PlayerPrefs.SetInt("Score", MoneyText.Coins);
    }
}