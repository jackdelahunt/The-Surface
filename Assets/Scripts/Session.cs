﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Session : MonoBehaviour
{
	public void loadNext() {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(index + 1, LoadSceneMode.Single);
    }

    public void loadLast() {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(index - 1, LoadSceneMode.Single);
    }

    public void pauseGame(bool state) {
        Time.timeScale = state ? 0 : 1; 
    }

    public void closeGame() {
        StartCoroutine (playExitSound(GetComponent<AudioSource>()));
    }

    public IEnumerator playExitSound(AudioSource source){
        source.Play ();
        yield return new WaitWhile (()=> source.isPlaying);
        Application.Quit();

    }

    public bool getPauseState() {
        return Time.timeScale == 0 ? true : false;
    }

    public void lockCursor() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void unlockCursor() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
