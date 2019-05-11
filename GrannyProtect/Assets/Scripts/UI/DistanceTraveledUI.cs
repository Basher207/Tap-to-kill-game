using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceTraveledUI : MonoBehaviour {

    Text text;

    private void Awake() {
        text = GetComponent<Text>();
    }
    void Update() {
        float distanceTraveled = FriendlyCar.totalDistanceDriven;
        text.text = "Distance traveled: " + distanceTraveled.ToXDecimalFigures(2).ToString();
    }
}
