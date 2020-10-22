using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class ResourceScreen : MonoBehaviour
{

    [SerializeField]private TMP_Text[] amounts;

    // Update is called once per frame
    public void tick()
    {
        amounts[0].text = Math.Round(ResourceManager.getAmount("Iron"), 2).ToString();
        amounts[1].text =  Math.Round(ResourceManager.getAmount("Oxygen"), 2).ToString();
        amounts[2].text =  Math.Round(ResourceManager.getAmount("Power"), 2).ToString();
        amounts[3].text =  Math.Round(ResourceManager.getAmount("Water"), 2).ToString();
        amounts[4].text =  Math.Round(ResourceManager.getAmount("Manpower"), 2).ToString();
    }
}
