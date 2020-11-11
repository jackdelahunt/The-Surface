using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siren : MonoBehaviour
{
    [SerializeField]private BotManager botManager;
    private AudioSource siren;
    bool lightsSpinning = false;
    public float spinSpeed = 1f;
    public List<Transform> childrenTransforms;

    void Start()
    {
        botManager = GameObject.FindGameObjectWithTag("BotManager").GetComponent<BotManager>();
        siren = GetComponent<AudioSource>();

        childrenTransforms = new List<Transform>(transform.GetComponentsInChildren<Transform>());
        childrenTransforms.Remove(transform);
        InvokeRepeating("playSiren", 1f, 2f);
    }

    void Update() {
        spinThoseLightsMyBrotha();
    }

    private void playSiren() {
        if(botManager.getNumberOfBots() > 0) {
            if(!siren.isPlaying){
                siren.Play();
                lightsSpinning = true;
            }
        } else {
            if(siren.isPlaying) {
                siren.Stop();
                lightsSpinning = false;
            }
        }
    }

    private void spinThoseLightsMyBrotha() {
        if(lightsSpinning) {
            foreach(Transform t in childrenTransforms) {
                t.gameObject.SetActive(true);
                t.Rotate (0, spinSpeed * Time.deltaTime, 0);
            }
        } else {
            foreach(Transform t in childrenTransforms) {
                t.gameObject.SetActive(false);
            }
        }
    }

    public void populateChildren() {}
}

