using UnityEngine;

public class PlayerWeaponSwitch : MonoBehaviour
{
    public GameObject knife;
    public GameObject pistol;
    public GameObject rifle;
    public Animator playerAnimator;

    private GameObject currentWeapon;
    private string currentWeaponTag;

    private void Start()
    {
        // Set the initial weapon
        SwitchWeapon("Knife");
    }

    private void Update()
    {
        // Check for weapon switch input
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchWeapon("Knife");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchWeapon("Pistol");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchWeapon("Rifle");
        }
    }

    private void SwitchWeapon(string weaponTag)
    {
        // Disable the current weapon
        if (currentWeapon != null)
        {
            currentWeapon.SetActive(false);
        }

        // Enable the new weapon
        switch (weaponTag)
        {
            case "Knife":
                currentWeapon = knife;
                break;
            case "Pistol":
                currentWeapon = pistol;
                break;
            case "Rifle":
                currentWeapon = rifle;
                break;
            default:
                currentWeapon = null;
                break;
        }

        // Set the current weapon tag
        currentWeaponTag = weaponTag;

        // Play the corresponding animation
        if (currentWeapon != null)
        {
            currentWeapon.SetActive(true);
            playerAnimator.SetTrigger(currentWeaponTag);
        }
    }
}
