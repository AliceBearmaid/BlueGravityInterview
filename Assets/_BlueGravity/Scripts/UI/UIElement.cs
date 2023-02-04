using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIElement : MonoBehaviour
{
    [SerializeField] Animator anmtr;

    public virtual void Toggle(bool _on)
    {
        anmtr.SetBool("IsShown", _on);
    }
}
