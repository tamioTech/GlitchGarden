using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Level time in seconds")]
    [SerializeField] int levelTime = 10;

    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        Debug.Log(GetComponent<Slider>().value);
        if(GetComponent<Slider>().value >= 1)
        {
            Debug.Log("timer finished");
        }
    }

    private void TimerFinished()
    {
        Debug.Log("timer finished");
        //GetComponent<LevelLoaderGG>().StartCoroutine(load)
    }

}
