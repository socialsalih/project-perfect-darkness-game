using UnityEngine;
using UnityEngine.UI;

public class AmmoItemController : MonoBehaviour
{
    public string playerTag = "Player";
    public string ammoTag = "Ammo";
    public int ammoIncreaseAmount = 10;
    public GameObject ammoUI;

    private int ammoCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (other.GetComponentInChildren<AmmoItemController>() != null)
            {
                if (other.GetComponentInChildren<AmmoItemController>().CompareTag(ammoTag))
                {
                    Destroy(gameObject);
                    ammoCount += ammoIncreaseAmount;
                    UpdateAmmoUI();
                }
            }
        }
    }

    private void UpdateAmmoUI()
    {
        ammoUI.GetComponentInChildren<Text>().text = "Ammo: " + ammoCount.ToString();
    }
}
