using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    float baseHealth;

    private void Start()
    {
        baseHealth = FindObjectOfType<BaseHealthDisplay>().GetBaseHealth();
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
        Debug.Log(numberOfAttackers);
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        FindObjectOfType<BaseHealthDisplay>().UpdateDisplay();
        Debug.Log(numberOfAttackers);
        Debug.Log("basehealth: " + baseHealth);
        if (numberOfAttackers <= 0 && levelTimerFinished && baseHealth > 0)
        {
            Debug.Log("end level now");
            winLabel.SetActive(true);
            FindObjectOfType<LevelLoaderGG>().LevelComplete();
        }
    }

    public void LoseLabel()
    {
        loseLabel.SetActive(true);
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
