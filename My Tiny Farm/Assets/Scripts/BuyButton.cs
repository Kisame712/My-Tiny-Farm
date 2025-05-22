using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public int requiredCash;
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
        if(resourceManager.cash < requiredCash)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }

    public void OnClick(int index)
    {
        switch (index)
        {
            case 0: 
                resourceManager.waterAmount += 5;
                resourceManager.cash -= 10;
                break;
            case 1:
                resourceManager.compostAmount += 5;
                resourceManager.cash -= 20;
                break;
            case 2:
                resourceManager.ureaAmount += 5;
                resourceManager.cash -= 20;
                break;
            case 3:
                resourceManager.seedAmount += 5;
                resourceManager.cash -= 40;
                break;
        }
    }
}
