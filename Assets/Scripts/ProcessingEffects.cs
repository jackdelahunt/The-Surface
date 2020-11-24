using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ProcessingEffects : MonoBehaviour
{

    [SerializeField]private PostProcessVolume volume;
	[SerializeField] private MotionBlur motionBlurSetting = null;
	public float shutterAngle = 300f;

	private void Start() {
		volume = GetComponent<PostProcessVolume>();
		volume.profile.TryGetSettings<MotionBlur>(out motionBlurSetting);

		if(motionBlurSetting != null) {

			if (Settings.getBlurSetting())
				motionBlurSetting.shutterAngle.value = shutterAngle;
			else
				motionBlurSetting.active = false;
		}
	}

}
