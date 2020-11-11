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
        //controller.enabled = true;
    }
 
    void Update()
    {
        pause();
        checkForInteraction();

        
        if(pauseMenuUI.activeSelf || terminalUI.activeSelf) {
            controller.enabled = false;
        } else {
            controller.enabled = true;
        }
        
    }

    void pause() {
        if(Input.GetButtonDown("Pause") && !session.getPauseState() && !terminalUI.activeSelf) {
            session.pauseGame(true);
            controller.enabled = false;
        }
    }

    void checkForInteraction() {
        if( Input.GetButtonDown("Interact") && !terminalUI.activeSelf)
        {
            interactObject.SetActive(true);
        }  
    }
}
