using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyCar : MonoBehaviour {
    public static FriendlyCar instance;
     
    void Start() {
        instance = GetComponent<FriendlyCar>();
    }

    void Update() {

    }
}
