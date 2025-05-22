using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPosition : MonoBehaviour
{
    public Transform spawnPoint;
    BuildManager buildManager;
    
    void Start()
    {
        buildManager = FindObjectOfType<BuildManager>();
    }

    private void OnMouseDown()
    {
        if(buildManager.itemToPlace != null)
        {
            Instantiate(buildManager.itemToPlace, spawnPoint.position, spawnPoint.rotation);
            buildManager.itemToPlace = null;
            Destroy(gameObject);
        }
    }


}
