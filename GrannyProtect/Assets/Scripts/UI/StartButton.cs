using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

    [HideInInspector] public Text text;

    private void Awake() {
        text = GetComponent<Text>();
    }
    void Update() {

    }
    public void Unpause () {
        text.text = "Unpause";
        PauseManager.paused = false;
    }
}
