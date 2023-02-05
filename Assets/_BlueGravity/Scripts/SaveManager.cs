using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager
{
    public static void SaveGold(int _step)
    {
        PlayerPrefs.SetInt("Gold",GetGold() + _step);
    }
    public static void SaveTotalGold(int _total)
    {
        PlayerPrefs.SetInt("Gold",_total);
    }
    public static int GetGold()
    {
        if (!PlayerPrefs.HasKey("Gold"))
        {
            SaveTotalGold(0);
        }    
        return PlayerPrefs.GetInt("Gold");

    }
}
