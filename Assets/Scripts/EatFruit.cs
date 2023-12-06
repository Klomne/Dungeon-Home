using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFruit : Interactable
{
    public AudioClip nomAudio;
    public override void OnInteraction()
    {
        GameObject.Find("Ghost").GetComponent<AudioSource>().PlayOneShot(nomAudio);
        Destroy(gameObject);
    }
}
