using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    [Header("Radius is the size of the explosion at max")]
    public float pushPower = 30f;
    ScaleAnimation explosionAnimation;
    void Start() {
        explosionAnimation = GetComponent<ScaleAnimation>();
    }

    void Update() {
        if (explosionAnimation.normPosition > 0.1f) {
            Destroy(this);
            //This assumes that the explosion is a sphere, so .x is the radius
            Collider [] cars = Physics.OverlapSphere(transform.position, explosionAnimation.startScale.x/2f);

            foreach (Collider carCollider in cars) {
                CarScript car = carCollider.GetComponent<CarScript>();
                if (car) {
                    car.dead = true;
                    car.rigidBod.constraints = RigidbodyConstraints.None;
                    car.rigidBod.velocity += (car.transform.position - transform.position).normalized * pushPower;
                    car.rigidBod.drag = 0f;
                    car.rigidBod.angularDrag = 0f;
                    car.rigidBod.useGravity = false;

                    Collider[] carColliders = car.GetComponentsInChildren<Collider>();

                    foreach (Collider coll in carColliders) {
                        Destroy(coll);
                    }
                    Destroy(car.gameObject, 3f);
                }
            }
        }
    }
}
