using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Characters.FirstPerson;

public class Terminal : MonoBehaviour
{
    [SerializeField]private GameObject terminalUI;
    private Session session;

    void Start() {
        session = GameObject.FindGameObjectWithTag("Session").GetComponent<Session>();

    }
 
    void Update()
    {
        if( (Input.GetButtonDown("Interact") || Input.GetButtonDown("Pause") ) && terminalUI.activeSelf)
        {  
            terminalUI.SetActive(false);
            session.lockCursor();
        }    
    }

    public void startTerminal() {
        if(!terminalUI.activeSelf) {
            terminalUI.SetActive(true);
            session.unlockCursor();
        } 
    }
}
