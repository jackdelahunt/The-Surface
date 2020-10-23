using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public void Update() {
        if(gameObject.activeSelf) {
            gameObject.SetActive(false);
        }
    }

    public void OnEnable() {
        print("Enables");
    }

    public void OnTriggerEnter(Collider col) {
        if(col.tag == "Terminal"){
            col.gameObject.GetComponent<Terminal>().toggleTerminal();
        }
    }
}
