using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Session : MonoBehaviour
{

	public void Update() {
        print(Settings.getDifficultySetting());
	}
	public void loadNext() {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index + 1, LoadSceneMode.Single);
    }

    public void loadScene(int index) {
        SceneManager.LoadScene(index, LoadSceneMode.Single);
	}

    public void loadLast() {
        int index = SceneManager.GetActiveScene().buildIndex;
        print("Loading last: " + index);
        SceneManager.LoadScene(index - 1, LoadSceneMode.Single);
    }

    public void pauseGame(bool state) {
        Time.timeScale = state ? 0 : 1; 
    }

    public void closeGame() {
        StartCoroutine (playExitSound(GetComponent<AudioSource>()));
    }

    private IEnumerator playExitSound(AudioSource source){
        source.Play ();
        yield return new WaitWhile (()=> source.isPlaying);
        Application.Quit();
    }

    public bool getPauseState() {
        return Time.timeScale == 0;
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
