using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalEnemyBehavior : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 5;
   
    public float xRange = 13;
    public bool isMovingRight;

    private float startDelay = 1;
    //private float spawnInterval = 1.5f;

    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RandomThing", startDelay);
    }

    // Update is called once per frame
    void Update()
    {
        //The enemy is either moving to the right or moving to the left inside the bounds

        if (transform.position.x > xRange)
        {
            isMovingRight = false;
        }
        else if (transform.position.x < -xRange)
        {
            isMovingRight = true;
        }

        if (isMovingRight)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

    }

    void RandomThing()
    {
        float randomTime = Random.Range(3, 5);
        SpawnProjectile();
        Invoke("RandomThing",randomTime);
    }

    void SpawnProjectile()
    {
        //Launch a projectile from the enemy
        Instantiate(projectilePrefab, transform.position, transform.rotation);
    }
}
