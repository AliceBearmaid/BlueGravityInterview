using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StoreUI : UIElement
{
    bool isActive;
    [Header("Components")]
    [SerializeField] StoreUICategory[] categories;

    public override void Toggle(bool _on)
    {
        base.Toggle(_on);
        if(_on)
        {
            SelectCategory(PlayerCustomizationType.Hat);
        }    
    }

    public void SelectCategory(int _type)
    {
        SelectCategory((PlayerCustomizationType)_type);
    }

    public void SelectCategory(PlayerCustomizationType _type)
    {
        for (int i = 0; i < categories.Length; i++)
        {
            if (categories[i].type == _type)
            {
                categories[i].tag.interactable = false;
                categories[i].categoryContainer.gameObject.SetActive(true);
            }
            else
            {
                categories[i].tag.interactable = true;
                categories[i].categoryContainer.gameObject.SetActive(false);
            }
        }
    }
    


}
[System.Serializable]
public class StoreUICategory
{
    public PlayerCustomizationType type;
    public Button tag;
    public GameObject categoryContainer;
}