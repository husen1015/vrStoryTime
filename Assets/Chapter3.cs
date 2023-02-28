using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour
{
    // lion stops to introduce butterfly 2, and butterfly 2 appears

    public string ChapterEvent;
    public GameObject AppearingButterfly;

    public GameObject lion;

    private Animator lionAnimation;

    private FMOD.Studio.EventInstance storyInstance;

    // Start is called before the first frame update
    void Start()
    {
        lionAnimation = lion.GetComponent<Animator>();
        lionAnimation.enabled = false;
        storyInstance = FMODUnity.RuntimeManager.CreateInstance(ChapterEvent);
        storyInstance.start();
        AppearingButterfly.SetActive(true);
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
