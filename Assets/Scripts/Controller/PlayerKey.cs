using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerKey : MonoBehaviour
{
    public int NumberOfKeys { get; private set; }

    public UnityEvent<PlayerKey> OnKeyCollected;
    public UnityEvent<PlayerKey> OnDoorOpened;


    public void KeyCollected()
    {
        NumberOfKeys++;
        OnKeyCollected.Invoke(this);
    }
    public void DoorOpened()
    {
        NumberOfKeys--;
        OnDoorOpened.Invoke(this);
    }

}
