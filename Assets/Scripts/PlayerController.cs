using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] projectilePrefabs;

    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 9;

    public float verticalInput;
    public float yRange = 4.8f;

    //Vector3 targetEulerAngles;

    // Start is called before the first frame update
    void Start()
    {
        //targetEulerAngles = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        

        Movement();

        //if (horizontalInput > 0) targetEulerAngles.x = -90;
        //if (horizontalInput < 0) targetEulerAngles.x = 90;
        //if (verticalInput < 0) targetEulerAngles.x = 180;
        //if (verticalInput > 0) targetEulerAngles.x = 0;



        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRandomProjectile();
        }

        
    }

    void Movement()
    {
        //Get movement inputs

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //Keep player in bounds

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
    }

    void SpawnRandomProjectile()
    {
        int projectileIndex = Random.Range(0, projectilePrefabs.Length);
        //Launch a projectile
        Instantiate(projectilePrefabs[projectileIndex], transform.position, transform.rotation);
    }
}
