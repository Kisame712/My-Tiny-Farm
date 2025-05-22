using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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

    public GameObject buildPosition;
    public GameObject removingItemSound;

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

    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Instantiate(buildPosition, transform.position - new Vector3(0, 1f, 0f), transform.rotation);
            Instantiate(removingItemSound, transform.position, transform.rotation);
            Destroy(gameObject);

        }
    }
}
