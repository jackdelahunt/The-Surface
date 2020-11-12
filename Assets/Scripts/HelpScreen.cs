using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScreen : MonoBehaviour
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
    }
}
