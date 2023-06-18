using DigitalRuby.RainMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// butterflies continue to roam under the rain
/// </summary>
public class Chapter11 : MonoBehaviour
{
    public string ChapterEvent;
    public GameObject skyController;
    public GameObject rainController;
    public GameObject butterflies;

    private Animator butterflyAnimator;

    private FMOD.Studio.EventInstance storyInstance;

    // Start is called before the first frame update
    void Start()
    {

        storyInstance = FMODUnity.RuntimeManager.CreateInstance(ChapterEvent);
        storyInstance.start();
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
