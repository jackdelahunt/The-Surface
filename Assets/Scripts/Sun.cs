using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float timeMultiplier = 1f;
    
    float sunInitialIntensity;

    private float lastTime = 0f;
    private float thisTime = 0f;
    
    void Update() {
        lastTime = thisTime;
        transform.Rotate (timeMultiplier * Time.deltaTime, 0, 0);
        thisTime = getTimeOfDay();
    }

    public float getTimeOfDay() {
        float rotation = transform.localEulerAngles.x;

        // returns number between 0 -> 1 for the time of day
        return (rotation % 360) / 360.0f;
    }

    public bool isNewDay() {
        if(lastTime > 0.9f && thisTime < 0.1f)
            return true;
        else
            return false;
    }
   
}
