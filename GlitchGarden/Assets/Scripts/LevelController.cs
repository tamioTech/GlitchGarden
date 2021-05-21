using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerKilled()
    {
        Debug.Log(numberOfAttackers);
        numberOfAttackers--;
        if(numberOfAttackers <= 0 && levelTimerFinished)
        {
            Debug.Log("End level now!");
            FindObjectOfType<LevelLoaderGG>().LoadLevel1();
        }
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
