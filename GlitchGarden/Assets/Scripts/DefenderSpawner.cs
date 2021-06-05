using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    GameObject defenderParent;
    const string DEFENDER_PARENT_NAME = "Defenders";

    private void Start()
    {
        CreateDefenderParent();
    }

    private void CreateDefenderParent()
    {
        defenderParent = GameObject.Find(DEFENDER_PARENT_NAME);
        if(!defenderParent)
        {
            defenderParent = new GameObject(DEFENDER_PARENT_NAME);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log(defender);
        if (defender)
        {
            AttemptToPlaceDefenderAt(SnapToGrid(GetSquareClicked()));
        }
        Debug.Log("Defender Not Selected!");
    }

    public void  setSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        var StarDisplay = FindObjectOfType<StarDisplay>();
        int defenderCost = defender.GetStarCost();
       
        if (StarDisplay.HaveEnoughStars(defenderCost) && defender != null)
            {
                SpawnNewDefender(gridPos);
                StarDisplay.SpendStars(defenderCost);            
            }
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 rawWorldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return rawWorldPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnNewDefender(Vector2 wPos)
    {

        if (defender)
        {
            Defender newDefender = Instantiate(defender, wPos, Quaternion.identity) as Defender;
            newDefender.transform.parent = defenderParent.transform;
        }
        else
        {
            Debug.Log("No defender selected");
            Debug.Log(wPos);
        }

    }


    
}
