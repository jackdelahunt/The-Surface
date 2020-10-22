using UnityEngine;
using UnityEngine.SceneManagement;

public class Session : MonoBehaviour
{
    public void loadNext() {
        SceneManager.LoadScene("Mission Control");
    }
}
