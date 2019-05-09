using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResourcesGetter {

    public static GameObject explosionPrefab;
    public static GameObject GetExplosion() {
        if (explosionPrefab == null) {
            explosionPrefab = Resources.Load<GameObject>("Player/Explosion");
        }
        return MonoBehaviour.Instantiate<GameObject>(explosionPrefab);
    }

    public static GameObject enemyCarPrefab;
    public static GameObject GetEnemyCar() {
        if (enemyCarPrefab == null) {
            enemyCarPrefab = Resources.Load<GameObject>("Cars/EnemyCar");
        }
        return MonoBehaviour.Instantiate<GameObject>(enemyCarPrefab);
    }
}
