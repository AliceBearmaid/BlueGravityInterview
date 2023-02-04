using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreUIElement : MonoBehaviour
{
    public int price;
    public bool bought;
    public StoreElement storeElement;
    public void BuyAndEquip()
    {
        if(!bought)
        {
            Buy();
        }
        if(bought)
        {
            Equip();
        }
    }

    public void Buy()
    {

    }

    public void Equip()
    {

    }
}
