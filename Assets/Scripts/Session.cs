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
}
