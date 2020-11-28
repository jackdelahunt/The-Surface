using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBarScript : MonoBehaviour
{
    [SerializeField] private float requiredManpower;
	[SerializeField] private RectTransform progressBar;
	[SerializeField] private Session session;
	public float maxWidth = 300f;
	private float multiplier;

	private void Start() {
		session = GameObject.FindGameObjectWithTag("Session").GetComponent<Session>();
		progressBar = GetComponent<RectTransform>();
		multiplier = maxWidth / requiredManpower;
		InvokeRepeating("updateProgressBar", 0f, 0.3f);
	}

	public void updateProgressBar() {
		progressBar.sizeDelta = new Vector2(ResourceManager.getAmount("Manpower") * multiplier, progressBar.sizeDelta.y);

		if(ResourceManager.getAmount("Manpower") >= requiredManpower) {
			session.unlockCursor();
			session.loadScene(3);
		}
	}
}
