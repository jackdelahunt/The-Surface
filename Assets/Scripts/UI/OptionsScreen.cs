using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsScreen : MonoBehaviour
{
    [SerializeField] private Slider soundSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Toggle AAToggle;
    [SerializeField] private Toggle blurToggle;
    [SerializeField]private Animator animator;
    [SerializeField] private DifficultyButton difficultyButton;


    void Start()
    {
        animator = GetComponent<Animator>();

        resetOptionToPlayerPrefs();
    }

    public void slideIn() {
        resetOptionToPlayerPrefs();
        animator.SetTrigger("SlideIn");
    }

    public void slideOut() {
        animator.SetTrigger("SlideOut");
        saveOptions();
	}

	public void resetOptionToPlayerPrefs() {
		soundSlider.value = Settings.getSoundSetting();
		musicSlider.value = Settings.getMusicSetting();
        blurToggle.isOn = Settings.getBlurSetting();
        AAToggle.isOn = Settings.getAASetting();
        difficultyButton.index = (int)Settings.getDifficultySetting();
    }

	public void saveOptions() {
        Settings.setSoundSetting(soundSlider.value);
        Settings.setMusicSetting(musicSlider.value);
        Settings.setBlurSetting(blurToggle.isOn);
        Settings.setAASetting(AAToggle.isOn);
        Settings.setDifficultySetting((Difficulty)difficultyButton.index);
    }
}

public enum Difficulty {
    EASY,
    MEDUIM,
    HARD
}
