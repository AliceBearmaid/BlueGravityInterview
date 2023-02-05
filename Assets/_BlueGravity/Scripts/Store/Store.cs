using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : Interactable
{
    public NonPlayableCharacter owner;
    public StoreUI storeUi;


    public override void Interact()
    {
        base.Interact();
        Player.instance.canMove = false;
    }
    public override void EndInteraction()
    {
        base.EndInteraction();
        Player.instance.canMove = true;
    }

}
