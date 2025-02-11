using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 10;
    private float spawnRangeY = 7f;
    private float spawnPosZ = -6.5f;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomEnemy", spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            Random.Range(-spawnRangeY, spawnRangeY), spawnPosZ);

        Instantiate(enemyPrefabs[enemyIndex], enemyPrefabs[enemyIndex].transform.position,
            enemyPrefabs[enemyIndex].transform.rotation);

        spawnInterval = Random.Range(1, 5);

        Invoke("SpawnRandomEnemy", spawnInterval);
    }
}
