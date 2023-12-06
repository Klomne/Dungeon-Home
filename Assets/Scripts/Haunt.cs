using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Hover))]

public class Haunt : Interactable
{
    Hover hover;
    bool haunted;
    void Start()
    {
        hover = GetComponent<Hover>();
        hover.enabled = false;
    }

    public override void OnInteraction()
    {
        haunted = !haunted;
        hover.enabled = haunted;
    }
}
