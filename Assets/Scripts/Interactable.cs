using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public virtual void OnInteraction()
    {
        Debug.Log(gameObject.name);
    }
}


//Monokai Pro Tema
//Email: carl.christensen98@gmail.com