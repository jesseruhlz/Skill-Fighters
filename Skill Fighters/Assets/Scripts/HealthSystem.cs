using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will be responsible for how much health an object has and how much relative
// damage is done to an object
// Basic system with a positive number meaning that object is alive, and zero 
// meaning that the object is dead

public class HealthSystem 
{
    private int health;
    private int healthMax;

   public HealthSystem(int health)
    {
        this.health = health;
        health = healthMax;
    }

    public int GetHealth()
    {
        return health;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) health = 0;
    }

}
