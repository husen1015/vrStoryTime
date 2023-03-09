using DigitalRuby.RainMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the sky turns cloudy and rain starts to fall
/// </summary>
public class Chapter7 : MonoBehaviour
{

    public string ChapterEvent;
    public GameObject lion;
    public GameObject skyController;

    public GameObject flower1;
    public GameObject flower2;
    public GameObject rainController;
    private Animator lionAnimation;

    private FMOD.Studio.EventInstance storyInstance;

    // Start is called before the first frame update
    void Start()
    {

        skyController.GetComponent<SkyboxController>().fadeToCloudyWeather = true;
        rainController.SetActive(true);
        rainController.GetComponent<RainScript>().RainIntensity= 1;
        lionAnimation = lion.GetComponent<Animator>();
        lionAnimation.enabled = true;

        // close flowers because of rains
        flower1.GetComponent<FlowerBehaviour>().closeFlower();
        flower2.GetComponent<FlowerBehaviour>().closeFlower();
        //fmod stuff
        storyInstance = FMODUnity.RuntimeManager.CreateInstance(ChapterEvent);
        storyInstance.start();
    }

    // Update is called once per frame
    void Update()
    {
        //fmod stuff
        FMOD.Studio.PLAYBACK_STATE state;   
        storyInstance.getPlaybackState(out state);
        if(state == FMOD.Studio.PLAYBACK_STATE.STOPPED)
        {
            GetComponent<Chapter8>().enabled = true;
            this.enabled=false;
        }
    }
}
