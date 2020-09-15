using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBound : MonoBehaviour
{
    private float verticalLimit = 10;
    private float horizontalLimit = 22;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckBoundaries();
    }

    void CheckBoundaries()
    {
        if (transform.position.x > horizontalLimit)
            transform.SetPositionAndRotation(new Vector3(-horizontalLimit, transform.position.y, transform.position.z), transform.rotation);
        else if (transform.position.x < -horizontalLimit)
            transform.SetPositionAndRotation(new Vector3(horizontalLimit, transform.position.y, transform.position.z), transform.rotation);
        if (transform.position.z > verticalLimit)
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y, -verticalLimit), transform.rotation);
        else if (transform.position.z < -verticalLimit)
            transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y, verticalLimit), transform.rotation);
    }
}
