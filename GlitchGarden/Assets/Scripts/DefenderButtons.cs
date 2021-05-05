using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButtons : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {

        var buttons = FindObjectsOfType<DefenderButtons>();
        foreach(DefenderButtons button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().setSelectedDefender(defenderPrefab);

    }
}
