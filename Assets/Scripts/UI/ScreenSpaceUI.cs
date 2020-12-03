using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenSpaceUI : MonoBehaviour
{
    private Session session;
    private Spawner spawner;
    [SerializeField]private GameObject pauseMenu;
    [SerializeField] private TMP_Text currentLevelText;
    [SerializeField] private TMP_Text currentWave;
    [SerializeField] private TMP_Text fpsCounter;

    private bool showFPS = false;

    void Start() {
        showFPS = Settings.getFPSSetting();
        session = GameObject.FindGameObjectWithTag("Session").GetComponent<Session>();
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
        updateWave();

        fpsCounter.enabled = showFPS;
    }
    void Update() {
        pauseMenu.SetActive( session.getPauseState() );
        currentLevelText.SetText( ResourceManager.getAmount("Ship Upgrade").ToString());
        if(fpsCounter.enabled)
            fpsCounter.SetText( Mathf.RoundToInt(1 / Time.deltaTime).ToString() );
    }

    public void updateWave() {
        currentWave.text = spawner.wave.ToString();
	}
}
