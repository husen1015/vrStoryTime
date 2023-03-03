using DigitalRuby.RainMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the sun hears the butterflies' story and banishes the rain away, the weather becomes pleasant again 
/// </summary>
public class Chapter12 : MonoBehaviour
{
    public GameObject skyController;
    public GameObject rainController;
    public GameObject butterflies;

    private Animator butterflyAnimator;


    // Start is called before the first frame update
    void Start()
    {
        //return weather back to sunny
        skyController.GetComponent<SkyboxController>().fadeToCloudyWeather = false;
        rainController.GetComponent<RainScript>().RainIntensity = 0;
        butterflyAnimator = butterflies.GetComponent<Animator>();
        butterflyAnimator.SetBool("shouldCelebrate", true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
