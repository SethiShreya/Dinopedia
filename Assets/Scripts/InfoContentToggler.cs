using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoContentToggler : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject InfoPanel;
    

    public void togglerPanel()
    {
        //if panel is on then make it off and if panel is off then make it on
        if (isOn)
        {
            InfoPanel.SetActive(false);
            isOn = false;
        }
        else
        {
            InfoPanel.SetActive(true);
            isOn = true;
        }
    }
}
    

