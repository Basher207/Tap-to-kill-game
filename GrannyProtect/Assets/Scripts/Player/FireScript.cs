using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {


    void Update() {
        if (!PauseManager.paused && Input.GetKeyDown(KeyCode.Mouse0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMasks.groundLayerMask)) {
                ResourcesGetter.GetExplosion().transform.position = hit.point;
            }
        }
    }
}
