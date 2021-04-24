using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class LevelLoaderGG : MonoBehaviour
{

    [SerializeField] AudioClip quitGameButtonSound;
    [SerializeField] AudioClip startButtonSound;

    public void StartButtonPushed()
    {
        Debug.Log("Great jooooorb!");
        AudioSource.PlayClipAtPoint(startButtonSound, Camera.main.transform.position);
    }

    public void QuitButtonPressed()
    {
        Debug.Log("Where you goin' boi!? Mama raised no quitter!");
        AudioSource.PlayClipAtPoint(quitGameButtonSound, Camera.main.transform.position);
    }
}
