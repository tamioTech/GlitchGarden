using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Debug.Log("Mouse clicked");
        //SpawnNewDefender(GetSquareClicked());
        SpawnNewDefender(SnapToGrid(GetSquareClicked()));
        
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
        GameObject newDefender = Instantiate(defender, wPos , Quaternion.identity) as GameObject;
        Debug.Log(wPos);
    }

    
}
