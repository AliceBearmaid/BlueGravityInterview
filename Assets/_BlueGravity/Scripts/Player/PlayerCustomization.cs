using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomization : MonoBehaviour
{
    public StoreElement currentCustomization;
    [Header("Hats")]
    public SpriteRenderer hatFront;
    public SpriteRenderer hatBack;
    public SpriteRenderer hatSide;


    public void SetUpCustomization(StoreElement _customization)
    {
        currentCustomization = _customization;
        switch(currentCustomization.elementType)
        {
            case PlayerCustomizationType.Hat:
            {
                hatFront.sprite = _customization.front_Idle;
                hatBack.sprite = _customization.back_Idle;
                hatSide.sprite = _customization.side_Idle;
            }
            break;
        }
    }
}
