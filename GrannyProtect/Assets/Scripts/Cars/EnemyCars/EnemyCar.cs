using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour {

    [HideInInspector] public CarScript carScript;
    [HideInInspector] public CarController carController;

    void Awake()
    {
        carScript = GetComponent<CarScript>();
        carController = GetComponent<CarController>();
    }

    void FixedUpdate() {
        carController.targetWorldLocation = FriendlyCar.position;
    }
}
