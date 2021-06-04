using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{

    float volumeSliderValue;

    private void Update()
    {

        if (volumeSliderValue > 0)
        {
            volumeSliderValue = GetComponent<Slider>().value;
            Debug.Log(volumeSliderValue);

        }
    }

        public void DefaultButtonPressed()
        {
            //TODO set back to default values
            Debug.Log("Default button pressed");
        }

}
