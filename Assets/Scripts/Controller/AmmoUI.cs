using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AmmoUI : MonoBehaviour
{
    private TextMeshProUGUI ammoText;

    // Start is called before the first frame update
    void Start()
    {
        ammoText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateKeyText(PlayerAmmo playerAmmo)
    {
        ammoText.text = playerAmmo.NumberOfAmmos.ToString();
    }


}
