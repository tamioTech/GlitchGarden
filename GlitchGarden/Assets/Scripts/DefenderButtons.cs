using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButtons : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;

    private void Start()
    {
        LabelButtonWithCost();
    }

    private void LabelButtonWithCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if(!costText)
        {
            Debug.LogError(name + " has no cost, add some!");
        }
        else
        {
            costText.text = defenderPrefab.GetStarCost().ToString();
        }

    }

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
