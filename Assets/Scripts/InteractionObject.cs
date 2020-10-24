using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public void OnEnable() {
        Invoke("turnOff", 0.2f);
    }

    public void OnTriggerEnter(Collider col) {
        if(col.tag == "Terminal"){
            col.gameObject.GetComponent<Terminal>().startTerminal();
        }
    }

    public void turnOff() {
        gameObject.SetActive(false);
    }
}
