using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFruit : Interactable
{
    public AudioClip NomAudio;
    public override void OnInteraction()
    {
        GameObject.Find("Ghost").GetComponent<AudioSource>().PlayOneShot(NomAudio);
        Destroy(gameObject);
    }
}
