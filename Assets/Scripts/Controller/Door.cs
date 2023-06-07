using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerKey playerKey = other.GetComponent<PlayerKey>();

        if (playerKey != null)
        {
            playerKey.DoorOpened();
            gameObject.SetActive(false);
        }
    }

}
