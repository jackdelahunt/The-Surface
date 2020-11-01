using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;
    public List<Transform> spawnPoints;
    public int spawnCount;

    void Start() {
        spawnPoints = new List<Transform>(transform.GetComponentsInChildren<Transform>());
        spawnPoints.Remove(transform); //removing this game objects transform

        spawn();
    }

    void spawn() {
        int left = spawnCount;
        foreach(Transform t in spawnPoints) {
            GameObject.Instantiate(toSpawn, t.position, new Quaternion(0f, 0f, 0f, 0f));
            left--;

            if(left <= 0) {
                return;
            }
        }
    }
}
