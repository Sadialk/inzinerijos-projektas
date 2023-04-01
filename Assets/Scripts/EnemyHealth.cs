using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private int currencyValue;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Add currency to the player
        Currency playerCurrency = FindObjectOfType<Currency>();
        if (playerCurrency != null)
        {
            playerCurrency.AddCurrency(currencyValue);
        }

        // Code to handle the enemy dying
        Destroy(gameObject);
    }
}
