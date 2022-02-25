using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : Interactable
{
    [SerializeField]
    private Material ligthOn;
    [SerializeField]
    private Material lightOff;
    [SerializeField]
    private List<GameObject> lightsRoof;
    [SerializeField]
    private List<GameObject> lights;
    [SerializeField]
    private List<GameObject> darkness;

    public override void Interact()
    {
        int numOfLight = 0;
        foreach (GameObject light in lightsRoof)
        {
            if (lights[numOfLight].activeSelf == true)
            {
                light.GetComponentInChildren<Renderer>().material = lightOff;
                lights[numOfLight].SetActive(false);
                darkness[numOfLight].SetActive(true);
            }
            else
            {
                light.GetComponentInChildren<Renderer>().material = ligthOn;
                lights[numOfLight].SetActive(true);
                darkness[numOfLight].SetActive(false);
            }
            numOfLight++;
        }
    }
}
