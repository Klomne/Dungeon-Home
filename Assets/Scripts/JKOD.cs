using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JKOD : Interactable
{
    public bool �ppen = false;
    public float hastighet = 1f;
    public float minY = 0;
    public float maxY = 2f;

    public override void OnInteraction()
    {
        �ppen = !�ppen;
        Debug.Log("Hej");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 nyPos = transform.position;
        nyPos.y = �ppen ? maxY : minY;
        transform.position = Vector3.MoveTowards(transform.position, nyPos, hastighet * Time.deltaTime);
    }
}