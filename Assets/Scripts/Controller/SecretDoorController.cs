using UnityEngine;

public class SecretDoorController : MonoBehaviour
{
    public GameObject secretDoor;
    public string playerTag = "Player";
    public string keyTag = "Key";

    private bool isDoorOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (isDoorOpen)
                return;

            KeyItemController keyItem = other.GetComponentInChildren<KeyItemController>();

            if (keyItem != null && keyItem.CompareTag(keyTag))
            {
                Destroy(secretDoor);
                isDoorOpen = true;
            }
        }
    }
}
