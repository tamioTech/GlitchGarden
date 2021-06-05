using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BaseHealthDisplay : MonoBehaviour
{

    [SerializeField] float baseHealth = 3;
    float lives;
    Text baseHealthText;

    // Start is called before the first frame update
    void Start()
    {
        lives = baseHealth - PlayerPrefsController.GetDifficulty();
        Debug.Log("baseHealh with difficulty setting: " + lives);
        baseHealthText = GetComponent<Text>();
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0)
        {
            FindObjectOfType<LevelController>().LoseLabel();
            YouLose();
        }
    }


    public void UpdateDisplay()
    {
        Debug.Log("lives: " + lives);
        baseHealthText.text = lives.ToString();
    }

    IEnumerator YouLose()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("End");

    }

    public void DamageBase(float damage)
    {
        lives -= damage;
        Debug.Log(lives);
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelLoaderGG>().GameOver();
        }
    }

    public float GetBaseHealth()
    {
        return lives;
    }

}
