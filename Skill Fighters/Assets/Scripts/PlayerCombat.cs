using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Transform attackPoint;
    public float attackRange = 0.5f;
    // this is the layer of the object that the player wants to hit
    // in this case when making player2 layer we will assign it to this
    public LayerMask enemyLayers;

    // Amount each attack does to player2/enemy
    public int attackDamage1 = 10;
    public int attackDamage2 = 25;
    public int attackDamage3 = 50;

    // Amount each attack uses up stamina
    public int attack2Stamina = 10;
    public int attack3Stamina = 35;

    //public HealthBar healthbar;

    // Update is called once per frame
    void Update()
    {
        // if 'Q' is pressed, it will trigger attack 1
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack1();
            Debug.Log("Player has attacked with Q");
        }
        // will need 3 more keys for each attack type

        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack2();
            Debug.Log("Player has attacked with E");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Attack3();
            Debug.Log("Player has attacked with R");
        }

    }

    void Attack1()
    {
        // Play an attack animation
        // Detect enemies in range of attack
        // Apply damage to them

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //damage enemy
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit the enemy");
            enemy.GetComponent<HealthSystem>().Damage(attackDamage1);
        }
    }

    void Attack2()
    {
        // Play an attack animation
        // Detect enemies in range of attack
        // Apply damage to them

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //damage enemy
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit the enemy");
            enemy.GetComponent<HealthSystem>().Damage(attackDamage2);
        }
        GetComponent<StaminaSystem>().AttackStamina(attack2Stamina);
    }

    void Attack3()
    {
        // Play an attack animation
        // Detect enemies in range of attack
        // Apply damage to them

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //damage enemy
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit the enemy");
            enemy.GetComponent<HealthSystem>().Damage(attackDamage3);
        }
    }

    // this is used to print the attack radius in the editor so we can easily adjust the settings
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
