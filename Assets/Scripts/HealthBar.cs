using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	
    [SerializeField]private float maxWidth = 300f;
    [SerializeField] private GameObject player;
    private FirstPersonController controller;
    private float multiplier;
    private RectTransform bar;


void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bar = GetComponent<RectTransform>();
        controller = player.GetComponent<FirstPersonController>();
        multiplier = maxWidth / controller.maxHealth;
        bar.sizeDelta = new Vector2(controller.health * multiplier, bar.sizeDelta.y);

        InvokeRepeating("updateWidth", 0f, 0.1f);
    }

    void updateWidth() {
        bar.sizeDelta = new Vector2(controller.health * multiplier, bar.sizeDelta.y);
    }
}

