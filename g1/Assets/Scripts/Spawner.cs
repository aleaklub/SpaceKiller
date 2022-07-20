using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{ 
    public Transform SpawnPos;
public GameObject Ball;
    public float TimeSpawn;
    float RandX;

    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
 IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        RandX = Random.Range(1f, 1f);
        Repeat();
    }


  
}
