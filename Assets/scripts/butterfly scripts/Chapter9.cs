using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the butterflies continue to the white flower
/// </summary>
public class Chapter9 : MonoBehaviour
{

    public string ChapterEvent;
    public GameObject butterflies;

    public GameObject ColoredFlower;

    public GameObject lion;


    private Animator butterflyAnimator;

    private FMOD.Studio.EventInstance storyInstance;

    private Animator lionAnimation;
    // Start is called before the first frame update
    void Start()
    {
        lionAnimation = lion.GetComponent<Animator>();
        //lionAnimation.SetBool("FinishedChapter8", true);
        lionAnimation.SetBool("FinishedChapter8", true);
        lionAnimation.SetBool("FinishedChapter9", false);

        ColoredFlower.GetComponent<FlowerBehaviour>().closeFlower();

        butterflyAnimator = butterflies.GetComponent<Animator>();
        butterflyAnimator.enabled = true;


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
            GetComponent<ThirdQuizChapter>().enabled = true;
            this.enabled=false;
        }
    }
}
