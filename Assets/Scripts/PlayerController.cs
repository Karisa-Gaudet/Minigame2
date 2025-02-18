using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerController : MonoBehaviour
{
    
    public Transform playerSpawner;

    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 9;

    public float verticalInput;
    public float yRange = 4.8f;

    //Vector3 targetEulerAngles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Vector3.up;

        Movement();

        if (horizontalInput > 0) playerSpawner.forward = Vector3.left;
        if (horizontalInput < 0) playerSpawner.forward = Vector3.right;
        if (verticalInput < 0) playerSpawner.forward = Vector3.up;
        if (verticalInput > 0) playerSpawner.forward = Vector3.down;


        



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

    
}
