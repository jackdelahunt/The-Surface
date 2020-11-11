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
        if(state) {
            unlockCursor();
        } else {
            lockCursor();
        }
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
