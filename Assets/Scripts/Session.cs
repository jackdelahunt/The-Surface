using UnityEngine;
using UnityEngine.SceneManagement;

public class Session : MonoBehaviour
{
    public void loadNext() {

        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index + 1);
    }

    public void loadLast() {

        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index - 1);
    }

    public void pauseGame(bool state) {
        Time.timeScale = state ? 0 : 1;
        Cursor.visible = state;
        Cursor.lockState = state ? CursorLockMode.None : CursorLockMode.Locked;
    }

    public bool getPauseState() {
        return Time.timeScale == 0 ? true : false;
    }
}
