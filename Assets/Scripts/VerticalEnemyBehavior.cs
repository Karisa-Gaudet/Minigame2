using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalEnemyBehavior : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 5;

    public float yRange = 9;
    public bool isMovingUp;

    private float startDelay = 2;
    //private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {

        Invoke("RandomThing", startDelay);
    }

    // Update is called once per frame
    void Update()
    {
        //The enemy is either moving up or down inside the bounds

        if (transform.position.y > yRange)
        {
            isMovingUp = false;
        }
        else if (transform.position.y < -yRange)
        {
            isMovingUp = true;
        }

        if (isMovingUp)
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
        Invoke("RandomThing", randomTime);
    }
    void SpawnProjectile()
    {
        //Launch a projectile from the enemy
        Instantiate(projectilePrefab, transform.position, transform.rotation);
    }
}
