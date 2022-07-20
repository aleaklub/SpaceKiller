using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed;
    public Vector2 dir;

    void Update()
    {
        transform.Translate(speed * dir * Time.deltaTime);
    }


   
}

