using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will be responsible for how much health an object has and how much relative
// damage is done to an object
// Basic system with a positive number meaning that object is alive, and zero 
// meaning that the object is dead

public class HealthSystem : MonoBehaviour
{
    private int health;
    public int healthMax = 100;

    public HealthBar healthBar;

    /*
   public HealthSystem(int health)
    {
        //this.health = health;
        health = healthMax;
    }
    */

    void Start()
    {
        health = healthMax;
        healthBar.SetMaxHealth(healthMax);
    }

    public int GetHealth()
    {
        return health;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        
        if(health <= 0)
        {
            Die();
        }
        healthBar.SetHealth(health);
    }

    void Die()
    {
        //die animation and disable the plalyer
        Debug.Log("Enemy died");
    }

}
