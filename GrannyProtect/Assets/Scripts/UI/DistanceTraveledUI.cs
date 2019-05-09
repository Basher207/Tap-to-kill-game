using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceTraveledUI : MonoBehaviour {

    Text text;

    [Header("Divde the distance by:")] float distanceScale = 100f;
    private void Awake() {
        text = GetComponent<Text>();
    }
    void Update() {
        float distanceTraveled = FriendlyCar.totalDistanceDriven / distanceScale;
        text.text = "Distance traveled: " + distanceTraveled.ToXDecimalFigures(2).ToString();
    }
}
