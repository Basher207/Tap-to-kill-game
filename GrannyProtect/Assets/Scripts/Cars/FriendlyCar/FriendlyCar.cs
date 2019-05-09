using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyCar : MonoBehaviour {
    public static FriendlyCar instance;
    public static float totalDistanceDriven;
    public static Vector3 position {
        get {
            if (instance)
                return instance.transform.position;
            return Vector3.zero;
        }
    }

    Vector2 previousPos;
    [HideInInspector] public CarScript carScript;

    void Start() {
        GameManager.Intialize();
        instance = GetComponent<FriendlyCar>();
        carScript = GetComponent<CarScript>();
        totalDistanceDriven = 0f;
        previousPos = transform.position;
    }

    void Update() {
        if (!carScript.dead) {
            totalDistanceDriven += Vector3.Distance(transform.position, previousPos);
            previousPos = transform.position;
        }
    }
    private void OnDestroy() {
        GameManager.EndGame();
    }
}
