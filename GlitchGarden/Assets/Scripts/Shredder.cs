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

        Destroy(collision.gameObject);
    }
}
