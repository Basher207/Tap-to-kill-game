using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveToPause : MonoBehaviour {
    public bool invert;
    void Update() {
        for (int i = 0; i < transform.childCount; i++) {
            transform.GetChild(i).gameObject.SetActive(invert ^ PauseManager.paused);
        }
    }
}
