using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter4 : MonoBehaviour
{
    // Red and White continue walking together
    private FMOD.Studio.EventInstance storyInstance;

    public string ChapterEvent;
    public GameObject lion;

    
    private Animator lionAnimation;

    // Start is called before the first frame update
    void Start()
    {
        lionAnimation = lion.GetComponent<Animator>();
        lionAnimation.enabled = true;
        storyInstance = FMODUnity.RuntimeManager.CreateInstance(ChapterEvent);
        storyInstance.start();
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
