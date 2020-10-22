using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("tick", 0f, 1f);
    }

    public void tick() {
        print("Tick");
    }

}
