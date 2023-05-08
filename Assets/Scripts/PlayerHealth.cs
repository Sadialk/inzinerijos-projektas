using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public GameOverScreen gameOver;
    private bool _isDead;
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

        if (currentHealth <= 0 && !_isDead)
        {
            Die(); 
        }
    }

    public void Die()
    {
        _isDead = true;
        gameOver.gameOver();
    }
    void UpdateHealthText()
    {
        if(currentHealth<=0)
            healthText.text=0.ToString();//"0";
        else
            healthText.text = currentHealth.ToString(); // Update the health UI text to display the player's current health
    }
}
