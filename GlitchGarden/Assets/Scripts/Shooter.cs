using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;
    Animator animator;

    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
        animator.SetBool("IsAttacking", true);
    }

    public void Update()
    {

        if (IsAttackerInLane())
        {
            Debug.Log("Pew pew");
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            Debug.Log("sit and wait");
            animator.SetBool("IsAttacking", false);
        }
    }

    public void Fire()
    {
        
        Instantiate(projectile, gun.transform.position, Quaternion.identity);

    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs((spawner.transform.position.y - transform.position.y)) <= Mathf.Epsilon);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

}
