using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCamera : MonoBehaviour {
    public static PauseCamera instance;
    public static bool pauseCameraActive { 
        set {
            instance.transform.parent.gameObject.SetActive(value);
        }
    }


    public float rotationSpeed = 30f;

    private void Awake() {
        instance = this;
    }

    void Update() {
        transform.parent.position = FriendlyCar.position;
        transform.RotateAround(transform.parent.position, Vector3.up, Time.unscaledDeltaTime * rotationSpeed);
    }
}
