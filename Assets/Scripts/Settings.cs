using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Settings
{
	public static readonly string soundKey = "sound";
	public static readonly string musicKey = "music";
	public static readonly string blurKey = "blur";
	public static readonly string AAKey = "antiAliasing";
	public static readonly string difficultyKey = "difficulty";
	public static readonly string fpsKey = "fps";

	public static float getSoundSetting() {
		if (!PlayerPrefs.HasKey(soundKey))
			PlayerPrefs.SetFloat(soundKey, 0.5f);

		return PlayerPrefs.GetFloat(soundKey);	
	}

	public static float getMusicSetting() {
		if (!PlayerPrefs.HasKey(musicKey))
			PlayerPrefs.SetFloat(musicKey, 0.5f);

		return PlayerPrefs.GetFloat(musicKey);
	}
	public static bool getBlurSetting() {
		if (!PlayerPrefs.HasKey(blurKey))
			PlayerPrefs.SetInt(blurKey, 1);

		return PlayerPrefs.GetInt(blurKey) == 1; 
	}

	public static bool getAASetting() {
		if (!PlayerPrefs.HasKey(AAKey))
			PlayerPrefs.SetInt(AAKey, 1);

		return PlayerPrefs.GetInt(AAKey) == 1;
	}

	public static Difficulty getDifficultySetting() {
		if (!PlayerPrefs.HasKey(difficultyKey))
			PlayerPrefs.SetInt(difficultyKey, (int)Difficulty.EASY);

		return (Difficulty)PlayerPrefs.GetInt(difficultyKey);
	}

	public static bool getFPSSetting() {
		if (!PlayerPrefs.HasKey(fpsKey))
			PlayerPrefs.SetInt(fpsKey, 1);

		return PlayerPrefs.GetInt(fpsKey) == 1;
	}

	// ******************************************

	public static void setSoundSetting(float value) {
		// make sure it exists, not a great way 
		getSoundSetting();
		PlayerPrefs.SetFloat(soundKey, value);
	}

	public static void setMusicSetting(float value) {
		// make sure it exists, not a great way 
		getMusicSetting();
		PlayerPrefs.SetFloat(musicKey, value);
	}

	public static void setBlurSetting(bool value) {

		// make sure it exists, not a great way 
		getBlurSetting();
		PlayerPrefs.SetInt(blurKey, value ? 1 : 0);
	}

	public static void setAASetting(bool value) {

		// make sure it exists, not a great way 
		getAASetting();
		PlayerPrefs.SetInt(AAKey, value ? 1 : 0);
	}

	public static void setDifficultySetting(Difficulty level) {
		PlayerPrefs.SetInt(difficultyKey, (int)level);
	}

	public static void setFPSSetting(bool value) {

		// make sure it exists, not a great way 
		getFPSSetting();
		PlayerPrefs.SetInt(fpsKey, value ? 1 : 0);
	}

}
