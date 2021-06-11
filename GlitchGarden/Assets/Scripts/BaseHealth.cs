using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        FindObjectOfType<BaseHealthDisplay>().DamageBase(1);
    }
}
