using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAmmo : MonoBehaviour
{
    public int NumberOfAmmos { get; private set; }

    public UnityEvent<PlayerAmmo> OnAmmoCollected;


    public void AmmoCollected()
    {
        NumberOfAmmos++;
        OnAmmoCollected.Invoke(this);
    }

}
