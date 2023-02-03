using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Blue Gravity/Dialogue", fileName = "Dialogue")]
public class Dialogue : ScriptableObject
{
    public Sprite protrait;
    [TextArea]
    public string message;
    public string sender;
    public Color nameTagColor;

}
