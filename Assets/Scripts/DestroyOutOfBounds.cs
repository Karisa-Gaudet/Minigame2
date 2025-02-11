using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float yBound = 11;
    private float xBound = 14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >  yBound || transform.position.y < -yBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > xBound || transform.position.x < -xBound)
        {
            Destroy(gameObject);
        }
    }
}
