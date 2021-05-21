using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] float minSpawnDelay = .5f;
    [SerializeField] float maxSpawnDelay = 2f;
    [SerializeField] Attacker[] attackerPrefabArray;

    bool spawn = true;
    

    IEnumerator Start()
    {
        
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }


    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
        Debug.Log("spawn = " + spawn);
        
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate(
            myAttacker, transform.position, transform.rotation
            ) as Attacker;
        newAttacker.transform.parent = transform;
    }
}
