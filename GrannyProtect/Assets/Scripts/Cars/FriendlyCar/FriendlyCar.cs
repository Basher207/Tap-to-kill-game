using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyCar : MonoBehaviour {
    public static FriendlyCar instance;
    public static float totalDistanceDriven;
    public static float bestDistanceDriven;
    public static Vector3 position {
        get {
            if (instance)
                return instance.transform.position;
            return Vector3.zero;
        }
    }



    public Vector3 previousPos;
    [HideInInspector] public CarScript carScript;
    [HideInInspector] public float personalDistanceDriven;
    void Start() {
        GameManager.Intialize();
        instance = GetComponent<FriendlyCar>();
        carScript = GetComponent<CarScript>();
        personalDistanceDriven = 0f;
        previousPos = transform.position;
    }

    void Update() {
        if (!carScript.dead) {
            personalDistanceDriven += Vector3.Distance(transform.position, previousPos);
            previousPos = transform.position;
            if (personalDistanceDriven > bestDistanceDriven) {
                bestDistanceDriven = personalDistanceDriven;
            }
            if (!PauseManager.paused) {
                totalDistanceDriven = personalDistanceDriven;
            }
        }
    }
    private void OnDestroy() {
        GameManager.EndGame();
    }
}
