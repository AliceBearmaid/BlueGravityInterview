using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{
    [Header("Interactions")]
    public UnityEvent interactionEvents;
    public UnityEvent endEvents;


    public virtual void Interact()
    {
        interactionEvents.Invoke();
    }

    public virtual void EndInteraction()
    {
        endEvents.Invoke();
    }
}
