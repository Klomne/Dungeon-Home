using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : Interactable
{
    public GameObject toggleFire;
    public override void OnInteraction()
    {
        toggleFire.SetActive(!toggleFire.activeSelf);
    }
}
