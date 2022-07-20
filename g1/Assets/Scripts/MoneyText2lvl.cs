using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyText2lvl : MonoBehaviour
{
    public static int Coins2lvl;

    Text text;
    
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = Coins2lvl.ToString();

    }
}
