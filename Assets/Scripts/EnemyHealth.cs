using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Currency money;
    public int maxHealth = 100;
    public int currentHealth;
    private int currencyValue = 5;


    void Start()
    {
        money = Currency.money;
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
            money.AddCurrency(currencyValue);
        // Code to handle the enemy dying
        Destroy(gameObject);
    }
}
