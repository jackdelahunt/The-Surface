using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInteraction : MonoBehaviour
{

    [SerializeField]private GameObject interactObject;

     private bool isAxisInUse = false;
 
    void Update()
    {
        if( Input.GetAxisRaw("Interact") != 0)
        {
            if(isAxisInUse == false)
            {
                interactObject.SetActive(true);
                isAxisInUse = true;
            }
        }
        if( Input.GetAxisRaw("Interact") == 0)
        {
            isAxisInUse = false;
        }    
    }
}
