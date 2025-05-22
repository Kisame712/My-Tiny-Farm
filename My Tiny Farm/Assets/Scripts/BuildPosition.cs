using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildPosition : MonoBehaviour
{
    public Transform spawnPoint;
    BuildManager buildManager;
    public GameObject spawnSound;

    void Start()
    {
        buildManager = FindObjectOfType<BuildManager>();
    }

    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if(buildManager.itemToPlace != null)
            {
                Instantiate(buildManager.itemToPlace, spawnPoint.position, spawnPoint.rotation);
                Instantiate(spawnSound, spawnPoint.position, spawnPoint.rotation);
                buildManager.itemToPlace = null;
                Destroy(gameObject);
            }
        }
    }


}
