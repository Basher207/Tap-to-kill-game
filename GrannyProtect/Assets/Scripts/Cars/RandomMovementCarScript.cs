using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovementCarScript : MonoBehaviour {

    [HideInInspector] public CarScript carScript;
    [HideInInspector] public Vector3 targetWorldLocation;
    [HideInInspector] public CarController carController;

    void Awake() {
        carScript = GetComponent<CarScript>();
        carController = GetComponent<CarController>();
        GenerateNewRandomLocation();
    }
    void GenerateNewRandomLocation () {
        targetWorldLocation = new Vector3(Random.Range(-20f, 20f), 0f, Random.Range(-20f, 20f));
        carController.targetWorldLocation = targetWorldLocation;
    }

    void FixedUpdate() {
        Vector3 deltaToTarget = targetWorldLocation - transform.position;
        deltaToTarget.y = 0f;
        if (deltaToTarget.magnitude < 2f) {
            GenerateNewRandomLocation();
        }
    }
}
