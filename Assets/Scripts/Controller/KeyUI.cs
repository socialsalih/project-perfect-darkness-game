using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyUI : MonoBehaviour
{
    public TextMeshProUGUI keyText;

    // Start is called before the first frame update
    void Start()
    {
        keyText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateKeyText(PlayerKey playerKey)
    {
        keyText.text = playerKey.NumberOfKeys.ToString();
    }


}