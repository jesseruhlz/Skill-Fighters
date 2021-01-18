using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaHandler2 : MonoBehaviour
{
    private Image barImage;
    private Stamina stamina;

    private void Awake()
    {
        barImage = transform.Find("bar").GetComponent<Image>();

        //barImage.fillAmount = .3f;
        stamina = new Stamina();
    }

    private void Update()
    {
        stamina.Update();
        barImage.fillAmount = stamina.GetStaminaNormalized();
    }
}

public class Stamina
{
    private float staminaAmt;
    private float staminaRegenAmt;
    public const int STAMINA_MAX = 100;

    public Stamina()
    {
        staminaAmt = 0;
        staminaRegenAmt = 30f;
    }

    public void Update()
    {
        staminaAmt += staminaRegenAmt * Time.deltaTime;
        staminaAmt = Mathf.Clamp(staminaAmt, 0f, STAMINA_MAX);
    }

    public void TrySpendStamina(int amount)
    {
        if (staminaAmt >= amount)
        {
            staminaAmt -= amount;
        }
    }

    public float GetStaminaNormalized()
    {
        return staminaAmt / STAMINA_MAX;
    }
}
