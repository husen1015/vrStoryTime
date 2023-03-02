using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Red and White continue walking together
/// </summary>
public class Chapter4 : MonoBehaviour
{
    
    private FMOD.Studio.EventInstance storyInstance;

    public string ChapterEvent;
    public GameObject lion;
    public GameObject butterflies; // contains the butterflies animator

    private Animator lionAnimation;
    private Animator butterflyAnimator; // addition- play it when this chapter starts
    // Start is called before the first frame update
    void Start()
    {
        butterflyAnimator = butterflies.GetComponent<Animator>();
        lionAnimation = lion.GetComponent<Animator>();
        lionAnimation.enabled = true;
        storyInstance = FMODUnity.RuntimeManager.CreateInstance(ChapterEvent);
        storyInstance.start();
        butterflyAnimator.SetBool("shouldMeet", false);
    }

    // Update is called once per frame
    void Update()
    {
        FMOD.Studio.PLAYBACK_STATE state;   
        storyInstance.getPlaybackState(out state);
        if(state == FMOD.Studio.PLAYBACK_STATE.STOPPED)
        {
            GetComponent<Chapter5>().enabled = true;
            this.enabled=false;
        }
    }
}
