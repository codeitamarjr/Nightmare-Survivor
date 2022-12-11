using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;

    public HeathBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        /* Set the current health to the max health when the game starts */
        currentHealth = maxHealth;
        /* Set the max health of the health bar to the max health of the player */
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        /* If the player has no health, go to scene Game Over */
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    public void TakeDamage(int damage)
    {
        /* When the player takes damage, the current health will decrease by the amount of damage taken */
        currentHealth -= damage;

        /* Set the health bar to the current health */
        healthBar.SetHealth(currentHealth);
    }
}
