using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Blue Gravity/StoreElement")]
public class StoreElement : ScriptableObject
{
    public PlayerCustomizationType elementType;
    public int price;
    [Header("UI")]
    public Sprite icon;
    [Header("Character Sprites")]
    public Sprite front_Idle;
    public Sprite front_Step;
    public Sprite back_Idle;
    public Sprite back_Step;
    public Sprite side_Idle;
    public Sprite side_Step;
}
public enum PlayerCustomizationType
{
    Hat,
    Accessory
}