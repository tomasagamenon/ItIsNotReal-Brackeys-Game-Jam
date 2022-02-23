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
    private List<GameObject> lights;

    public override void Interact()
    {
        foreach(GameObject light in lights)
        {
            if (light.GetComponent<Renderer>().material == ligthOn)
                light.GetComponent<Renderer>().material = lightOff;
            else light.GetComponent<Renderer>().material = ligthOn;
        }
    }
}
