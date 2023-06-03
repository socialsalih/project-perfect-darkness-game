using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerKey playerKey = other.GetComponent<PlayerKey>();

        if (playerKey != null)
        {
            playerKey.KeyCollected();
            gameObject.SetActive(false);
        }
    }

}