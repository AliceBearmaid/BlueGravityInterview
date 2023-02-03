using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    /// <summary>
    /// Returns the value of the sorting layer, using the y position as a reference.
    /// </summary>
    public static int GetSortingOrderValue(this Transform _transform)
    {
        return (int)Mathf.Ceil(_transform.position.y * 100);//Maybe just change to Round
    }
}
