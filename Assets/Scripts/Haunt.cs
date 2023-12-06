using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Hover))]

public class Haunt : Interactable
{
    Hover hover;
    bool haunted;
    
    //Sound Play
    private AudioSource audioSource;
    public AudioClip[] shoot;
    private AudioClip shootClip;

    void Start()
    {
        hover = GetComponent<Hover>();
        hover.enabled = false;

        //Sound Play
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public override void OnInteraction()
    {
        //Sound Play
        int index = Random.Range(0, shoot.Length);
        shootClip = shoot[index];

        audioSource.clip = shootClip;
        audioSource.Play();
        
        //Haunted Code
        haunted = !haunted;
        hover.enabled = haunted;
    }
}
