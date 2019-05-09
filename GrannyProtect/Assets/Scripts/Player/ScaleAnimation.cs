using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAnimation : MonoBehaviour {

    public AnimationCurve scaleCurve;

    public bool destroyOnEnd;
    //For changing the start of the animation in the inspector
    public float normPosition;
    public float animationLength = 1f;

    [HideInInspector] public Vector3 startScale;

    void Awake() {
        startScale = transform.localScale;
        Update();
    }

    void Update() {
        normPosition += Time.deltaTime / animationLength;
        transform.localScale = startScale * scaleCurve.Evaluate(normPosition);
        if (destroyOnEnd && normPosition > 1f) {
            Destroy(gameObject);
        }
    }
}
