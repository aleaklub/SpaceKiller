using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    public float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate = 2f;
    float nextSpawn = 0.0f;
    void Start()
    {

    }

    
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(RandX, RandX);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
    
}

