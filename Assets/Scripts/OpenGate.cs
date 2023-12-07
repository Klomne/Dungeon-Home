using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class OpenGate : Interactable
{
    public override void OnInteraction()
    {
        // EventTrigger trigger = GetComponentInParent<EventTrigger>();
        // EventTrigger.Entry entry = new EventTrigger.Entry();
        // entry.eventID = EventTriggerType.PointerClick;
        // entry.callback.AddListener( (eventData) => { Foo(); } );
        // trigger.delegates.Add(entry);
    }
}


//https://discussions.unity.com/t/how-do-you-add-an-ui-eventtrigger-by-script/125158/2
