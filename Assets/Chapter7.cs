using DigitalRuby.RainMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the sky turns cloudy and rain starts to fall
/// </summary>
public class Chapter7 : MonoBehaviour
{
    public GameObject lion;
    public GameObject skyController;
    public GameObject rainController;

    // Start is called before the first frame update
    void Start()
    {
        skyController.GetComponent<SkyboxController>().fadeToCloudyWeather = true;
        rainController.GetComponent<RainScript>().RainIntensity= 1;

        //fmod stuff
    }

    // Update is called once per frame
    void Update()
    {
        //fmod stuff

        //temporary shift to chapter 8 until lucas implements passage through fmod
        if (lion.transform.localPosition.x <= -32)
        {
            GetComponent<Chapter8>().enabled = true;
            this.enabled = false;
        }
    }
}
