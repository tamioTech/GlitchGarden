using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start default volume: " + volumeSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found...did you start from the splash screen?");
        }
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
        Debug.Log(volumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<LevelLoaderGG>().MainMenuButtonPushed();
    }

}
