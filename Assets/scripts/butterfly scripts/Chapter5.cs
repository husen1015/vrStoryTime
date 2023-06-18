using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// butterfly 3 appears and is introduced with the 2 existing butterflies
/// </summary>
public class Chapter5 : MonoBehaviour
{
    // lion stops and yellow joins the gang
    public string ChapterEvent;
    public GameObject AppearingButterfly;

    public GameObject lion;
    public GameObject butterflies; 

    private Animator lionAnimation;
    private Animator butterflyAnimator; 

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
        butterflyAnimator.SetBool("shouldMeet2", true);

    }

    // Update is called once per frame, and here it will be used to check when the chapter should disbale itself
    // - or in other words, will finish.
    void Update()
    {
        FMOD.Studio.PLAYBACK_STATE state;   
        storyInstance.getPlaybackState(out state);
        if(state == FMOD.Studio.PLAYBACK_STATE.STOPPED)
        {
            GetComponent<Chapter6>().enabled = true;
            this.enabled=false;
        }
    }
}
