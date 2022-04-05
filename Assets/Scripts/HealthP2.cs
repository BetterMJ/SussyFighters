using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthP2 : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(3); // shows winner p1
        }
    }
}
