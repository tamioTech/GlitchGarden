using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;

    private void OnMouseDown()
    {
        AttemptToPlaceDefenderAt(SnapToGrid(GetSquareClicked()));
        
    }

    public void  setSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;


    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        var StarDisplay = FindObjectOfType<StarDisplay>();
        int defenderCost = defender.GetStarCost();
        if (StarDisplay.HaveEnoughStars(defenderCost))
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

        if (defender) { Defender newDefender = Instantiate(defender, wPos, Quaternion.identity) as Defender; }
        Debug.Log("No defender selected");
        Debug.Log(wPos);
    }

    
}
