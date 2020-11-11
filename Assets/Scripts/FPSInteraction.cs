using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FPSInteraction : MonoBehaviour
{

    [SerializeField]private GameObject interactObject;
    [SerializeField]private GameObject terminalUI;
    [SerializeField]private GameObject pauseMenuUI;
    private Session session;
    private FirstPersonController controller;
    private bool wasPaused = false;


    void Start() {
        session = GameObject.FindGameObjectWithTag("Session").GetComponent<Session>();
        controller = GetComponent<FirstPersonController>();
    }
 
    void Update()
    {
        handleIfPaused();
        checkForPause();
        checkForInteraction();
    }

    void handleIfPaused() {
        bool pauseState = session.getPauseState();

        // dont ever do this again... 1/10 effort
        if(pauseState || wasPaused)
            controller.enabled = !pauseState;

        pauseMenuUI.SetActive(pauseState);

        wasPaused = pauseState;
    }

    void checkForPause() {
        if(Input.GetButtonDown("Pause") && !terminalUI.activeSelf) {
            bool state = session.getPauseState();
            session.pauseGame(!state);
        }
    }

    void checkForInteraction() {
        if( Input.GetButtonDown("Interact") && !terminalUI.activeSelf)
        {
            interactObject.SetActive(true);
        }  
    }
}
