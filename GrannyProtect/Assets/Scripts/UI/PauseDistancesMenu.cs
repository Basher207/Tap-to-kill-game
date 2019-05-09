using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseDistancesMenu : MonoBehaviour
{

    Text text;

    void Start() {
        text = GetComponent<Text>();
    }

    void Update() {
        text.text = "Distance traveled in: \nPrevious attempt:\n" + FriendlyCar.totalDistanceDriven.ToXDecimalFigures(2) + "\nPersonal Best:\n" + FriendlyCar.bestDistanceDriven.ToXDecimalFigures(2);
    }
}
