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
            FindObjectOfType<LevelController>().LoseLabel();
            YouLose();
        }
    }


    public void UpdateDisplay()
    {
        baseHealthText.text = baseHealth.ToString();
    }

    IEnumerator YouLose()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("End");

    }

    public void DamageBase(int damage)
    {
        baseHealth -= damage;
        Debug.Log(baseHealth);
        UpdateDisplay();

        if (baseHealth <= 0)
        {
            FindObjectOfType<LevelLoaderGG>().GameOver();
        }
    }

    public int GetBaseHealth()
    {
        return baseHealth;
    }

}
