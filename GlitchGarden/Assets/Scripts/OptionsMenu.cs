using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{

    [SerializeField] [Range(0,1)] float volumeSliderValue = 1.0f;

    private void Update()
    {
        volumeSliderValue = GetComponent<Slider>().value;
        Debug.Log(volumeSliderValue);
    }

    public void DefaultButtonPressed()
    {
        //TODO set back to default values
        Debug.Log("Default button pressed"); 
    }


}
