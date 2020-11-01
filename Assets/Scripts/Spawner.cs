using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;
    public List<Transform> spawnPoints;
    public int spawnCount;
    public Sun sun;

    void Start() {
        spawnPoints = new List<Transform>(transform.GetComponentsInChildren<Transform>());
        spawnPoints.Remove(transform); //removing this game objects transform

        sun = GameObject.FindGameObjectWithTag("Sun").GetComponent<Sun>();
    }

    void Update() {
        if(sun.isNewDay())
            spawn(spawnCount);
    }

    void spawn(int spawnAmount) {
        foreach(Transform t in spawnPoints) {
            GameObject.Instantiate(toSpawn, t.position, new Quaternion(0f, 0f, 0f, 0f));
            spawnAmount--;

            if(spawnAmount <= 0) {
                return;
            }
        }

        spawn(spawnAmount);
    }
}
