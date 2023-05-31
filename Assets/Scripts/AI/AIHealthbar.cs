using UnityEngine;
using UnityEngine.UI;

public class AIHealthbar : MonoBehaviour
{
    public string name;
    public int maxHealth = 100;
    private int currentHealth;

    public Slider healthSlider;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthBar()
    {
        float healthPercentage = (float)currentHealth / maxHealth;
        healthSlider.value = healthPercentage;
    }

    private void Die()
    {
        // Enemy death logic
        Debug.Log(name + " has been defeated!");
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            int damageAmount = collision.gameObject.GetComponent<Bullet>().damageAmount;
            TakeDamage(damageAmount);

            Destroy(collision.gameObject);
        }
    }
}
