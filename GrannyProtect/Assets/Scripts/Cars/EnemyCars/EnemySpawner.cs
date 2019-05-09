using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    [Header("1 = maxSpawnDelta time")]
    public AnimationCurve spawningCurve;
    public float maxSpawnDelta = 5f;
    public float timeForMaxSpawn = 60f;
    [HideInInspector] public float timeForNextSpawn = 0f;
    [HideInInspector] public float timeSinceStart;
    [HideInInspector] public CarScript carScript;


    private void Awake() {
        carScript = GetComponent<CarScript>();

    }
    void Update() {
        if (carScript.dead) {
            Destroy(this);
            return;
        }
        timeSinceStart += Time.deltaTime;
        timeForNextSpawn -= Time.deltaTime;
        if (timeForNextSpawn < 0f) {
            Spawn();
        }
    }
    public void Spawn () {
        //0.1f is the minimum time between spawns to prevent spawning too much and crash during testing :)) 
        timeForNextSpawn = Mathf.Max (0.1f, 1f * spawningCurve.Evaluate(timeSinceStart / timeForMaxSpawn) * maxSpawnDelta);

        float angle = Random.Range(-180f, 180f);
        float randomDistance = Random.Range(30f, 50f);

        Vector3 spawnDelta = Quaternion.AngleAxis(angle, Vector3.up) * Vector3.forward * randomDistance;
        Vector3 pos = transform.position + spawnDelta;

        ResourcesGetter.GetEnemyCar().transform.position = pos;
    }

}
