using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.5f;
    [SerializeField] Slider difficultySlider;
    [SerializeField] float defaultDifficulty = 0;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
        Debug.Log("start default volume: " + volumeSlider.value);
        Debug.Log("MasterVolumeAtStartIs: " + PlayerPrefsController.GetMasterVolume());

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
        difficultySlider.value = defaultDifficulty;
        Debug.Log("new default vol: " + volumeSlider.value);
        Debug.Log("new default dif: " + difficultySlider.value);

    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        PlayerPrefsController.SetDifficulty(difficultySlider.value);
        FindObjectOfType<LevelLoaderGG>().MainMenuButtonPushed();
    }

}
