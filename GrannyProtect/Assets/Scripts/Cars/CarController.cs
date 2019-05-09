using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    //Y is ignored
    [HideInInspector] public Vector3 targetWorldLocation;
    [HideInInspector] public CarScript carScript;

    private void Awake() {
        carScript = GetComponent<CarScript>();
    }
    void FixedUpdate() {
        Vector3 deltaToTarget = targetWorldLocation - transform.position;
        deltaToTarget.y = 0f;
        Vector3 forward = transform.forward;
        forward.y = 0f;

        float angleDelta = Vector3.SignedAngle(deltaToTarget, forward, Vector3.up);

        carScript.torque = -angleDelta * Mathf.Deg2Rad / Mathf.PI;
        carScript.throtal = 1f - Mathf.Abs(carScript.torque);
    }
}
