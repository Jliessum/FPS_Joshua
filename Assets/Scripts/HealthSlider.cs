using UnityEngine;

public class HealthSlider : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public HealthBar healthBar; 

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        healthBar.SetHealth(currentHealth);
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;

        // Make sure health doesn't exceed the maximum
        currentHealth = Mathf.Min(currentHealth, maxHealth);

        healthBar.SetHealth(currentHealth);
    }
}