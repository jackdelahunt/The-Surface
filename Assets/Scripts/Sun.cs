using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    [SerializeField]private Gradient gradient;
    private Light light;
    public float timeMultiplier = 1f;
    private float lastTime = 0f;
    private float thisTime = 0f;

	private void Start() {
        light = GetComponent<Light>();
	}

	void Update() {
        lastTime = thisTime;
        transform.Rotate (timeMultiplier * Time.deltaTime, 0, 0);
        thisTime = getTimeOfDay();

        // light colour
        light.color = gradient.Evaluate(thisTime);
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
