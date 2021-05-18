using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] int baseHealth;
    Text baseHealthText;

    // Start is called before the first frame update
    void Start()
    {
        baseHealth = GetComponent<Health>().GetBaseHealth();
        baseHealthText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        baseHealthText.text = baseHealth.ToString();
    }

}
