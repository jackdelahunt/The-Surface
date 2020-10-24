using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Characters.FirstPerson;

public class Terminal : MonoBehaviour
{
    [SerializeField]private GameObject terminalUI;
    [SerializeField]private FirstPersonController firstPersonController;
 
    void Update()
    {
        if( Input.GetButtonDown("Interact")  && terminalUI.activeSelf)
        {  
            firstPersonController.enabled = true;
            terminalUI.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }    
    }

    public void startTerminal() {
        if(!terminalUI.activeSelf) {
            firstPersonController.enabled = false;
            terminalUI.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        } 
    }
}
