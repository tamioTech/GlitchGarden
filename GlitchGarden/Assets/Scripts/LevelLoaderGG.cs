using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;







public class LevelLoaderGG : MonoBehaviour
{

    [SerializeField] AudioClip quitGameButtonSound;
    [SerializeField] AudioClip startButtonSound;
    [SerializeField] [Range(0,1)] float startButtonVolume = 1.0f;
    [SerializeField] [Range(0, 1)] float quitButtonVolume = 1.0f;
    [SerializeField] int scenePosition;
    [SerializeField] int timeToWait = 3;

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
        SceneManager.LoadScene(0);
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
        SceneManager.LoadScene(0);
        //StartCoroutine(LoadMainMenu());
    }

    public void QuitButtonPressed()
    {
        Debug.Log("Where ya goin' boi!? Mama raised no quitter!");
        AudioSource.PlayClipAtPoint(quitGameButtonSound, Camera.main.transform.position, quitButtonVolume);
    }

}
