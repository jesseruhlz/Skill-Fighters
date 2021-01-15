using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaSystem : MonoBehaviour
{
    private float stamina;
    public int staminaMax = 100;
    public StaminaBar staminaBar;
    public float staminaRegen;

    // Start is called before the first frame update
    void Start()
    {
        stamina = staminaMax;
        staminaRegen = 5f;
        staminaBar.SetMaxStamina(staminaMax);
    }

    public void Update()
    {
        stamina += staminaRegen * Time.deltaTime;
    }

    public float GetStaminaNormalized()
    {
        return stamina / staminaMax;
    }

    public void AttackStamina(float staminaAmount)
    {
        stamina -= staminaAmount;
        if (stamina <= 0)
        {
            //cannot use attack
        }
        staminaBar.SetStamina(stamina);
    }
}
