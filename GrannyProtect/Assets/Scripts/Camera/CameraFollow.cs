using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    //For smooth transitions between level loads.
    public static Vector3 currentPos;

    [Header("Editor button")]
    public bool updateRelativePositionValue;
    public Vector3 relativePosition;

    void Start() {
        if (currentPos == default) {
            currentPos = FriendlyCar.position + relativePosition;
            FixedUpdate();
        }
    }

    void FixedUpdate() {
        currentPos = Vector3.Lerp(currentPos, relativePosition + FriendlyCar.position, Time.deltaTime * 4f);
        transform.position = currentPos;
    }
    private void OnDrawGizmosSelected() {
        //This is used as an editor tool to update the relative position of the camera to the car
        if (updateRelativePositionValue) {
            updateRelativePositionValue = false;
            FriendlyCar car = FindObjectOfType<FriendlyCar>();
            if (car)
                relativePosition = transform.position - car.transform.position;
        }
    }
}
