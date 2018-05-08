﻿
using UnityEngine;

public class Playermovement : MonoBehaviour {

    public Rigidbody rb;
    public float moveForward = 2000f;
    public float sidewaysForce = 500f;


    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(0, 0, moveForward * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce( sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
