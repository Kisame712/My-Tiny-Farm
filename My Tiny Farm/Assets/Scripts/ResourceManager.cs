using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceManager : MonoBehaviour
{
    public int cash;

    public int waterAmount;
    public int compostAmount;
    public int ureaAmount;
    public int seedAmount;

    public TMP_Text waterText;
    public TMP_Text compostText;
    public TMP_Text ureaText;
    public TMP_Text seedText;
    public TMP_Text cashText;

    // Update is called once per frame
    void Update()
    {
        waterText.text = waterAmount.ToString();
        compostText.text = compostAmount.ToString();
        ureaText.text = ureaAmount.ToString();
        seedText.text = seedAmount.ToString();
        cashText.text = "$" + cash.ToString();

    }
}
