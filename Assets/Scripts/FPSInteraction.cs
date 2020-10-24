using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInteraction : MonoBehaviour
{

    [SerializeField]private GameObject interactObject;
    [SerializeField] private GameObject terminalUI;
 
    void Update()
    {
        if( Input.GetButtonDown("Interact") && !terminalUI.activeSelf)
        {
            interactObject.SetActive(true);
        }  
    }
}
