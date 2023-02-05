using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class StoreUIElement : MonoBehaviour
{
    public int id;
    public int price;
    public bool bought;
    public bool isActive;
    public StoreElement storeElement;
    [Header("Components")]
    public Button btnMain;
    public GameObject priceTag;
    public Image icon;
    public TextMeshProUGUI txtPrice;
        
    private void Start()
    {
        SetUp();
    }
    void SetUp()
    {
        priceTag.SetActive(!bought);
        btnMain.interactable = !isActive;
        icon.sprite = storeElement.icon;
        price = storeElement.price;
        txtPrice.text = price.ToString();
    }
    public void BuyAndEquip()
    {
        if (!bought)
        {
            Buy();
        }
        if (bought)
        {
            Equip();
        }
        SetUp();
    }
    public void Buy()
    {
        if(SaveManager.GetGold()>=price)
        {
            bought = true;
            SaveManager.SaveGold(-price);
        }
    }

    public void Equip()
    {
        Player.instance.playerCustomization.SetUpCustomization(storeElement);
        StoreUI.instance.SelectElement(storeElement.elementType, id);
    }
}
