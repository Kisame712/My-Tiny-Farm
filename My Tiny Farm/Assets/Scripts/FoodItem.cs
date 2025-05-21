using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
    ResourceManager resourceManager;

    public int waterCost;
    public int compostCost;
    public int ureaCost;
    public int seedCost;

    public int cashGeneratedPerCycle;
    public float timeBetweenCycles;
    float nextCycleTime;

    void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
        resourceManager.waterAmount -= waterCost;
        resourceManager.compostAmount -= compostCost;
        resourceManager.ureaAmount -= ureaCost;
        resourceManager.seedAmount -= seedCost;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextCycleTime)
        {
            nextCycleTime = Time.time + timeBetweenCycles;
            resourceManager.cash += cashGeneratedPerCycle;
        }
    }
}
