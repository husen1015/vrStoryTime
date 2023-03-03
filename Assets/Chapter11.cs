using DigitalRuby.RainMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the sun hears the butterflies' story and banished the rain away, the weather becomes pleasant again 
/// </summary>
public class Chapter11 : MonoBehaviour
{
    public GameObject skyController;
    public GameObject rainController;


    // Start is called before the first frame update
    void Start()
    {
        skyController.GetComponent<SkyboxController>().fadeToCloudyWeather = false;
        rainController.GetComponent<RainScript>().RainIntensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
