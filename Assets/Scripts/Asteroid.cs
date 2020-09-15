using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float minVelocity;
    public float maxVelocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Random.onUnitSphere * (minVelocity + Random.value * maxVelocity), ForceMode.VelocityChange);
        transform.SetPositionAndRotation(new Vector3(Random.Range(-22,22), 0, Random.Range(-10,10)), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
