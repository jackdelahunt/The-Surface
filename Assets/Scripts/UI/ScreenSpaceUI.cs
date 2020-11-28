using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenSpaceUI : MonoBehaviour
{
    private Session session;
    [SerializeField]private GameObject pauseMenu;
    [SerializeField] private TMP_Text currentLevelText;

    void Start() {
        session = GameObject.FindGameObjectWithTag("Session").GetComponent<Session>();
    }
    void Update() {
        pauseMenu.SetActive( session.getPauseState() );
        currentLevelText.SetText( ResourceManager.getAmount("Ship Upgrade").ToString());
    }
}
