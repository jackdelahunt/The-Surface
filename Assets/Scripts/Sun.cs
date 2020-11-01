using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float timeMultiplier = 1f;
    
    float sunInitialIntensity;
    
    void Update() {
        transform.Rotate (timeMultiplier * Time.deltaTime, 0, 0);
    }

    public float getTimeOfDay() {
        float rotation = UnityEditor.TransformUtils.GetInspectorRotation(transform).x;

        // returns number between 0 -> 1 for the time of day
        return (rotation % 360) / 360.0f;
    }
   
}
