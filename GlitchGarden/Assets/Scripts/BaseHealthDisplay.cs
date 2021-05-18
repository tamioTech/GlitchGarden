using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BaseHealthDisplay : MonoBehaviour
{

    [SerializeField] int baseHealth = 12;
    Text baseHealthText;

    // Start is called before the first frame update
    void Start()
    {
        baseHealthText = GetComponent<Text>();
        baseHealthText.text = baseHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(baseHealth <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }


    public void UpdateDisplay()
    {
        baseHealthText.text = baseHealth.ToString();
    }

    public void DamageBase(int damage)
    {
        baseHealth -= damage;
        Debug.Log(baseHealth);
        UpdateDisplay();
    }

}
