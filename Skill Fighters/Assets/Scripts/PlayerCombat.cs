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

    public int attackDamage = 10;

    // Update is called once per frame
    void Update()
    {
        // if 'Q' is pressed, it will trigger attack 1
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
            Debug.Log("Player has attacked with Q");
        }
        // will need 3 more keys for each attack type
    }

    void Attack()
    {
        // Play an attack animation
        // Detect enemies in range of attack
        // Apply damage to them

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //damage enemy
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit the enemy");
            enemy.GetComponent<HealthSystem>().Damage(attackDamage);
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
