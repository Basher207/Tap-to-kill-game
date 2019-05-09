using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [Header("Editor button")]
    public bool updateRelativePositionValue;
    public Vector3 relativePosition;

    void Start() {
        
    }

    void FixedUpdate() {
        transform.position = Vector3.Lerp(transform.position, relativePosition + FriendlyCar.instance.transform.position, Time.deltaTime * 4f);
    }
    private void OnDrawGizmosSelected() {
        //This is used as an editor tool to update the relative position of the camera to the car
        if (updateRelativePositionValue) {
            updateRelativePositionValue = false;
            FriendlyCar car = GameObject.FindObjectOfType<FriendlyCar>();
            if (car)
                relativePosition = transform.position - car.transform.position;

        }
    }
}
