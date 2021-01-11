using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // if 'Q' is pressed, it will trigger attack 1
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        }
        //will need 3 more keys for each attack type
    }

    void Attack()
    {
        // Play an attack animation
        // Detect enemies in range of attack
        // Apply damage to them
    }
}
