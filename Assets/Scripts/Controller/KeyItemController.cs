using UnityEngine;
using UnityEngine.UI;

public class KeyItemController : MonoBehaviour
{
    public string playerTag = "Player";
    public string keyTag = "Key";
    public GameObject keyUI;

    private int keyCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (other.GetComponentInChildren<KeyItemController>() != null)
            {
                if (other.GetComponentInChildren<KeyItemController>().CompareTag(keyTag))
                {
                    Destroy(gameObject);
                    keyCount++;
                    UpdateKeyUI();
                }
            }
        }
    }

    private void UpdateKeyUI()
    {
        keyUI.GetComponentInChildren<Text>().text = "Keys: " + keyCount.ToString();
    }
}
