using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public GameObject settings;
    public GameObject credits;
    public void Play()
    {
        Debug.Log("algo");
    }

    public void ToggleSettings()
    {
        if (credits.activeInHierarchy)
            credits.SetActive(false);
        settings.SetActive(!settings.activeInHierarchy);
    }
    public void ToggleCredits()
    {
        if (settings.activeInHierarchy)
            settings.SetActive(false);
        credits.SetActive(!credits.activeInHierarchy);
    }

}
