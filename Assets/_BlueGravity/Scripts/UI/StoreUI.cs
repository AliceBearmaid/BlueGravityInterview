using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StoreUI : UIElement
{
    public static StoreUI instance;
    [Header("Components")]
    [SerializeField] StoreUICategory[] categories;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance.gameObject);
        }
    }


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
    public StoreUICategory GetCategory(PlayerCustomizationType _type)
    {
        for (int i = 0; i < categories.Length; i++)
        {
            if (categories[i].type == _type)
            {
                return categories[i];
            }
        }
        return null;
    }
    public void SelectElement(PlayerCustomizationType _type, int _id)
    {
        StoreUICategory category = GetCategory(_type);

        for (int i = 0; i < category.children.Length; i++)
        {
            category.children[i].GetComponent<Button>().interactable = i != _id;
            category.children[i].GetComponent<StoreUIElement>().isActive = i == _id;
        }
    }

}
[System.Serializable]
public class StoreUICategory
{
    public PlayerCustomizationType type;
    public Button tag;
    public GameObject categoryContainer;
    public GameObject[] children;

}