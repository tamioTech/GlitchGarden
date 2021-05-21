using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] GameObject winLabel;

    private void Start()
    {
        winLabel.SetActive(false);
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
        Debug.Log(numberOfAttackers);
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        Debug.Log(numberOfAttackers);
        if (numberOfAttackers <= 0 && levelTimerFinished)
        {
            Debug.Log("end level now");
            winLabel.SetActive(true);
            FindObjectOfType<LevelLoaderGG>().LevelComplete();
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
        foreach(AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }


}
