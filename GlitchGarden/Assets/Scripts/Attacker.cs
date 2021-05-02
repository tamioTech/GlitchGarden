using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{


    [SerializeField] [Range(0f, 5f)] float walkSpeed;
    float currentSpeed;

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Debug.Log("Attacker destroyed by: " + otherCollider);
        //Destroy(gameObject);
        
        
    }

}
