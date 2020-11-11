using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSpaceUI : MonoBehaviour
{
    private Session session;
    [SerializeField]private GameObject pauseMenu;

    void Start() {
        session = GameObject.FindGameObjectWithTag("Session").GetComponent<Session>();
    }
    void Update() {
        pauseMenu.SetActive( session.getPauseState() );
    }
}
