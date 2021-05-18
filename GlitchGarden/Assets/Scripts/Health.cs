using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;
    [SerializeField] int baseHealth = 5;

    public void DealBaseDamage(int damage)
    {
        baseHealth -= damage;
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            //GetComponent<StarDisplay>().AddStars(50);
            Debug.Log("Health < 0");
            TriggerDeathVFX();
            Destroy(gameObject);

        }
    }

    public int GetBaseHealth()
    {
        Debug.Log("basehealth: " + baseHealth);
        return baseHealth;
    }

    public float GetHealth()
    {
        return health;
    }

    public void ReplenishHealth()
    {
        health = 200;
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }

        GameObject deathVFXObject =  Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1);
    }

}