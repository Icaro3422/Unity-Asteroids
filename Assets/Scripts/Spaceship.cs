using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public float thrust;
    public float turningSpeed;
    public float bulletSpeed;
    public GameObject bulletPrefab;

    private Rigidbody myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") > 0)
            myRigidBody.AddForce(transform.up * Input.GetAxis("Vertical") * thrust, ForceMode.Acceleration);
        transform.Rotate(new Vector3(1,0,0), Input.GetAxis("Horizontal") * turningSpeed);

        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }

    void Shoot()
    {
        GameObject bullet = Object.Instantiate(bulletPrefab, transform.position + transform.up * 2, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.up * bulletSpeed, ForceMode.VelocityChange);
    }

}
