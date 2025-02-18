using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnBall : MonoBehaviour
{
    public GameObject[] projectilePrefabs;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRandomProjectile();
            
        }
    }

    void SpawnRandomProjectile()
    {
        int projectileIndex = Random.Range(0, projectilePrefabs.Length);
        //Launch a projectile
        Instantiate(projectilePrefabs[projectileIndex], transform.position, transform.rotation);
    }

    
}
