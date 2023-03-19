using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100; // The player's starting health
    public int currentHealth; // The player's current health

    public TMP_Text healthText; 

    void Start()
    {
        currentHealth = startingHealth; 
        UpdateHealthText(); 
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; 
        UpdateHealthText(); 

        if (currentHealth <= 0)
        {
            Die(); 
        }
    }

    public void Die()
    {
        //implement this method
    }

    void UpdateHealthText()
    {
        healthText.text = currentHealth.ToString(); // Update the health UI text to display the player's current health
    }
}
