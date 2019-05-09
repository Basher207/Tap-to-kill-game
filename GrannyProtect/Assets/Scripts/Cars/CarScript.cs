using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour {

    //A generic script to control any car
    //Maximum forces to apply
    public float maxThrotal = 8f;
    public float maxTorque = 4f;

    //Normalized values of currently applied forces
    [HideInInspector] [Range(0, 1)] public float throtal;
    [HideInInspector] [Range(-1, 1)] public float torque;

    [HideInInspector] public Rigidbody rigidBod;


    void Start() {
        rigidBod = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate() {
        rigidBod.AddForce(transform.forward * Mathf.Clamp01(throtal) * maxThrotal);
        rigidBod.AddTorque(Mathf.Clamp(torque, -1f, 1f) * maxTorque * Vector3.up);
    }
}
