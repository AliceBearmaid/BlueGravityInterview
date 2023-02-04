using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveManager
{
    public static void SaveGold(int _step)
    {
        PlayerPrefs.SetInt("Gold",GetGold() + _step);
    }

    public static int GetGold()
    {
        if (!PlayerPrefs.HasKey("Gold"))
        {
            SaveGold(0);
        }    
        return PlayerPrefs.GetInt("Gold");

    }
}
