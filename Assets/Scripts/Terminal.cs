using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Characters.FirstPerson;

public class Terminal : MonoBehaviour
{
    [SerializeField]private GameObject terminalUI;
    [SerializeField]private FirstPersonController firstPersonController;

    private bool active = false;

    public void toggleTerminal() {

        if(!active) {
            terminalUI.SetActive(true);
            firstPersonController.enabled = false;
            active = true;
        } else {
            terminalUI.SetActive(false);
            firstPersonController.enabled = true;
            active = false;
        }
    }
}
