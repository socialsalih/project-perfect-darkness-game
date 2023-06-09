using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth;
    }

    public void TakeDamage(int amount1)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        currentHealth -= amount1;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(currentScene.name) ;
        }
    }
}
