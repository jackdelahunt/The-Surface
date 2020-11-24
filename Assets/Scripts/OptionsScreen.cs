using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScreen : MonoBehaviour
{
    [SerializeField]private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void slideIn() {;
        animator.SetTrigger("SlideIn");
    }

    public void slideOut() {
        animator.SetTrigger("SlideOut");
        saveOptions();
	}

	public void saveOptions() {

	}
}
