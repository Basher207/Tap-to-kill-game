﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public static void Intialize () {
        if (!instance) {
            new GameObject("GameManager").AddComponent<GameManager>();
        }
    }
    public static void EndGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void Awake() {
        instance = this;
        PauseManager.paused = true;
    }
    void Update() {
        if (FriendlyCar.instance && !FriendlyCar.instance.carScript.dead) {
            if (Input.GetKeyDown (KeyCode.Escape)) {
                PauseManager.paused = !PauseManager.paused;
            }
        }
    }
}