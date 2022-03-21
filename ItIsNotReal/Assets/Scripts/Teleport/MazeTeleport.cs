using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeTeleport : MonoBehaviour
{
    public GameObject player;
    public Transform corridorStart;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.SetPositionAndRotation(corridorStart.position, player.transform.rotation);
            Debug.Log("tepeado");
        }
    }
}
