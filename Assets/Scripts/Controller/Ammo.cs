using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerAmmo playerAmmo = other.GetComponent<PlayerAmmo>();

        if (playerAmmo != null)
        {
            playerAmmo.AmmoCollected();
            gameObject.SetActive(false);
        }
    }
}
