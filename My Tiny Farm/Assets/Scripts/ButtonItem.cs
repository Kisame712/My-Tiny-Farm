using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonItem : MonoBehaviour
{
    public FoodItem foodItem;

    Button button;

    ResourceManager resourceManager;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        resourceManager = FindObjectOfType<ResourceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(resourceManager.waterAmount < foodItem.waterCost || resourceManager.compostAmount < foodItem.compostCost || resourceManager.ureaAmount < foodItem.ureaCost || resourceManager.seedAmount < foodItem.seedCost)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
        
    }
}
