using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// lion stops to introduce butterfly 2, and butterfly 2 appears
/// </summary>
public class Chapter3 : MonoBehaviour
{

    public string ChapterEvent;
    public GameObject AppearingButterfly;

    public GameObject lion;
    public GameObject butterflies; // contains the butterflies animator

    private Animator lionAnimation;
    private Animator butterflyAnimator; // addition- play it when this chapter starts

    private FMOD.Studio.EventInstance storyInstance;

    // Start is called before the first frame update
    void Start()
    {
        butterflyAnimator = butterflies.GetComponent<Animator>();
        lionAnimation = lion.GetComponent<Animator>();
        lionAnimation.enabled = false;
        storyInstance = FMODUnity.RuntimeManager.CreateInstance(ChapterEvent);
        storyInstance.start();
        AppearingButterfly.SetActive(true);
        butterflyAnimator.SetBool("shouldMeet", true); //start the meetup animation
    }

    // Update is called once per frame, and here it will be used to check when the chapter should disbale itself
    // - or in other words, will finish.
    void Update()
    {
        FMOD.Studio.PLAYBACK_STATE state;   
        storyInstance.getPlaybackState(out state);
        if(state == FMOD.Studio.PLAYBACK_STATE.STOPPED)
        {
            GetComponent<Chapter4>().enabled = true;
            this.enabled=false;
        }
    }
}
