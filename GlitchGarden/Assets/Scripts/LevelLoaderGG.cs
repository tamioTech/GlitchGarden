using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;







public class LevelLoaderGG : MonoBehaviour
{

    [SerializeField] AudioClip quitGameButtonSound;
    [SerializeField] AudioClip startButtonSound;
    [SerializeField] AudioClip levelCompleteSound;
    [SerializeField] AudioClip optionsMenuButtonSound;
    [SerializeField] [Range(0,1)] float optionsMenuButtonVolume = 1.0f;
    [SerializeField] [Range(0,1)] float startButtonVolume = 1.0f;
    [SerializeField] [Range(0,1)] float quitButtonVolume = 1.0f;
    [SerializeField] [Range(0,1)] float levelCompleteVolume = 1.0f;
    [SerializeField] int scenePosition;
    [SerializeField] int timeToWait = 1;
    

    void Start ()
    {
        scenePosition = SceneManager.GetActiveScene().buildIndex;
        if (scenePosition == 0)
        {
            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(scenePosition + 1);
    }

    IEnumerator LoadMainMenu()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(1);
    }

    public void StartButtonPushed()
    {
        Debug.Log("Great jooooorb!");
        AudioSource.PlayClipAtPoint(startButtonSound, Camera.main.transform.position, startButtonVolume);
        StartCoroutine(LoadNextScene());
    }

    public void MainMenuButtonPushed()
    {
        Debug.Log("main menu button pushed");
        //SceneManager.LoadScene(0);
        StartCoroutine(LoadMainMenu());
    }

    public void QuitButtonPressed()
    {
        Debug.Log("Where ya goin' boi!? Mama raised no quitter!");
        AudioSource.PlayClipAtPoint(quitGameButtonSound, Camera.main.transform.position, quitButtonVolume);
    }

    public void OptionsMenuButtonPressed()
    {
        AudioSource.PlayClipAtPoint(optionsMenuButtonSound, Camera.main.transform.position, optionsMenuButtonVolume);
        SceneManager.LoadScene("OptionsMenu");
    }

    public void BackButtonPressed()
    {
        AudioSource.PlayClipAtPoint(optionsMenuButtonSound, Camera.main.transform.position, optionsMenuButtonVolume);
        SceneManager.LoadScene(1);
    }

    IEnumerator LevelCompleted()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene("Level 1");
    }

    public void LevelComplete()
    {
        //AudioSource.PlayClipAtPoint(levelCompleteSound, Camera.main.transform.position, levelCompleteVolume);
        StartCoroutine(LevelCompleted());
    }

    public void GameOver()
    {
        StartCoroutine(GameOverDelay());
    }

    IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene("GameOver");

    }


}
