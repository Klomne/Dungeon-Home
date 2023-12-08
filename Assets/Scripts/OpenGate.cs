using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class OpenGate : Interactable
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public override void OnInteraction()
    {
        animator.SetBool("open", true);
        Invoke(nameof(ChangeBool), 3);
    }

    private void ChangeBool()
    {
        animator.SetBool("open", false);

    }
}