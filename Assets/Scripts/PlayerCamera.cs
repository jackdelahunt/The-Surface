using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private PostProcessLayer processLayer = null;

	private void Start() {
		processLayer = GetComponent<PostProcessLayer>();

		if(processLayer != null) {
			processLayer.antialiasingMode = Settings.getAASetting() ? PostProcessLayer.Antialiasing.FastApproximateAntialiasing : PostProcessLayer.Antialiasing.None;
		}
	}
}
