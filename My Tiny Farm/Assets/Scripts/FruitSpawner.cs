using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] fruits;
    public float spawnWaitTime;

    void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits()
    {
        yield return new WaitForSeconds(3f);
        for(int i=0; i< spawnPoints.Length; i++)
        {
            GameObject randomFruit = fruits[Random.Range(0, fruits.Length)];
            Instantiate(randomFruit, spawnPoints[i].position, spawnPoints[i].rotation);
            yield return new WaitForSeconds(spawnWaitTime);
        }


    }

}
