using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject toSpawn;
    public List<Transform> spawnPoints;
    public Sun sun;
    public Transform botParent;

    public int defaultSpawnCount = 6;
    public int spawnCount;

    void Start() {
        spawnPoints = new List<Transform>(transform.GetComponentsInChildren<Transform>());
        spawnPoints.Remove(transform); //removing this game objects transform

        sun = GameObject.FindGameObjectWithTag("Sun").GetComponent<Sun>();

		int spawnCountOffset = 1;
		spawnCount = defaultSpawnCount + (spawnCountOffset * (int)(Settings.getDifficultySetting() - 1));
	}

    void Update() {
        if(sun.isNewDay())
            spawn(spawnCount);
    }

    void spawn(int spawnAmount) {
        foreach(Transform t in spawnPoints) {
            GameObject.Instantiate(toSpawn, t.position, new Quaternion(0f, 0f, 0f, 0f), botParent);
            spawnAmount--;

            if(spawnAmount <= 0) {
                return;
            }
        }

        spawn(spawnAmount);
    }
}
