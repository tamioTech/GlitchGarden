using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] float projectileSpeed = 7.0f;
    [SerializeField] float spinSpeed = 500.0f;
    [SerializeField] float damageAmount = 50;


    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime, Space.World);
        transform.RotateAround(transform.localPosition, Vector3.forward, -spinSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Debug.Log("Zucchini hit: " + otherCollider.name);
        

        //reduce health
        //var health = otherCollider.GetComponent<Health>();
        //health.DealDamage(damageAmount);
        //Destroy(otherCollider.gameObject);

    }
}
