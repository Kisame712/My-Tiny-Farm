using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager : MonoBehaviour
{

    public Material skyboxMaterial;

    private float rotationSpeed = 0f;
    private float timeScale = 2.5f;
    public float nightExposure;
    public float dayExposure;

    public float timeBetweenChange;
    float nextChangeTime;
    bool isDay = false;

    private static readonly int Rotation = Shader.PropertyToID("_Rotation");
    private static readonly int Exposure = Shader.PropertyToID("_Exposure");


    void Update()
    {
        rotationSpeed += Time.deltaTime;
        skyboxMaterial.SetFloat(Rotation, rotationSpeed * timeScale);
        if(Time.time > nextChangeTime)
        {
            nextChangeTime = Time.time + timeBetweenChange;
            if (isDay)
            {
                skyboxMaterial.SetFloat(Exposure, nightExposure);
                isDay = false;
            }
            else
            {
                skyboxMaterial.SetFloat(Exposure, dayExposure);
                isDay = true;
            }

        }
        
        
    }
}
