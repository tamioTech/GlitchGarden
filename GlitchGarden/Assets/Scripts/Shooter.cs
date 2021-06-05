using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    GameObject projectileParent;
    const string PROJECTILE_PARENT_NAME = "Projectiles";
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;
    Animator animator; 

    private void Start()
    {
        CreateProjectileParent();
        SetLaneSpawner();
        animator = GetComponent<Animator>();
        animator.SetBool("IsAttacking", true);
    }

    private void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
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

        GameObject newProjectile = Instantiate(projectile, transform.position, Quaternion.identity)
            as GameObject;
        newProjectile.transform.parent = projectileParent.transform;


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


}
