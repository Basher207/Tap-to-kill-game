using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseManager : MonoBehaviour {
    public static PauseManager instance;
    public static void Intialize () {
        if (!instance) {
            instance = new GameObject("PauseManager").AddComponent<PauseManager>();
            DontDestroyOnLoad(instance.gameObject);
        }
    }
    public static bool _paused;
    public static bool paused {
        get {
            return _paused;
        }
        set {
            if (!GameManager.quittingGame && FriendlyCar.instance != null && _paused != value) {
                _paused = value;
                Time.timeScale = _paused ? 0f : 1f;
                PauseCamera.pauseCameraActive = _paused;
            }
        }
    }
}
