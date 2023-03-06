using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the 3 butterflies roam a sunny and pleasant forest
/// </summary>
public class Chapter6 : MonoBehaviour
{

    public string ChapterEvent;
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
        lionAnimation.enabled = true;
        butterflyAnimator.SetBool("shouldMeet2", false);
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
            GetComponent<Chapter7>().enabled = true;
            this.enabled=false;
        }
    }
}
