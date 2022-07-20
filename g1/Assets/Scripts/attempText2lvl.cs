using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attempText2lvl : MonoBehaviour
{
    public static int PlayerGo;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = PlayerGo.ToString();

    }
}
