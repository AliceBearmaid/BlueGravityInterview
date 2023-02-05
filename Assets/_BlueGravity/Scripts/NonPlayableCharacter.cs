using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayableCharacter : Interactable
{

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
