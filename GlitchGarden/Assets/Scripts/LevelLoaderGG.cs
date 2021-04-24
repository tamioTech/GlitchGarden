using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class LevelLoaderGG : MonoBehaviour
{

    [SerializeField] AudioClip quitGameButtonSound;

    public void StartButtonPushed()
    {
        Debug.Log("Great jooooorb!");
    }

    public void QuitButtonPressed()
    {
        Debug.Log("Where you goin' boi!? Mama raised no quitter!");
        AudioSource.PlayClipAtPoint(quitGameButtonSound, Camera.main.transform.position);
    }
}
