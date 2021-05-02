using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Debug.Log("Mouse clicked");
        SpawnNewDefender(GetSquareClicked());
        
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }

    private void SpawnNewDefender(Vector2 wPos)
    {
        GameObject newDefender = Instantiate(defender, wPos , Quaternion.identity) as GameObject;
    }

    
}
