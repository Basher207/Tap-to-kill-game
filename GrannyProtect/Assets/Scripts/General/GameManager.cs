using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public const float levelLength = 60f;
    public static GameManager instance;
    public static bool quittingGame;
    public static float timeLeft;
    public static float normTimeLeft {
        get {
            return  timeLeft / levelLength;
        }
    }
    public static void Intialize () {
        if (!instance) {
            new GameObject("GameManager").AddComponent<GameManager>();
        }
    }
    public static void EndGame () {
        if (instance != null &&  Application.isPlaying && !quittingGame) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void Awake() {
        instance = this;
    }
    void Start() {
        PauseManager.paused = true;
        timeLeft = 61f;
    }
    void Update() {
        timeLeft -= Time.deltaTime;
        if (FriendlyCar.instance && !FriendlyCar.instance.carScript.dead) {
            if (Input.GetKeyDown (KeyCode.Escape)) {
                PauseManager.paused = !PauseManager.paused;
            }
        }
    }
    private void OnApplicationQuit() {
        quittingGame = true;
    }
}
