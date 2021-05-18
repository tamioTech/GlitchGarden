using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        float health = GetComponent<Health>().GetHealth();
        Debug.Log(health);

        if (health <100)
        {
            GetComponent<Health>().ReplenishHealth();
        }

        //GetComponent<BaseHealthDisplay1>().BaseDamaged(1);
        //Destroy(collision.gameObject);
        
    }
}
