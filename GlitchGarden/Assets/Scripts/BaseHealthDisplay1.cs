using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealthDisplay1 : MonoBehaviour
{
    [SerializeField] string baseHealth = "10";
    Text baseHealthText;

    // Start is called before the first frame update
    void Start()
    {
        baseHealthText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        //DealBaseDamage(1);
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        Debug.Log("basehealth: " + baseHealth);
        baseHealthText.text = baseHealth;
       //baseHealthText.text = baseHealth.ToString();
    }

    //public void DealBaseDamage(int damageToBase)
    //{
    //    baseHealth -= damageToBase;
    //    UpdateDisplay();
    //}
}




