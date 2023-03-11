using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondQuizFinished : MonoBehaviour
{
    public string ChapterEvent;
    public GameObject butterflies;





    private FMOD.Studio.EventInstance storyInstance;
    // Start is called before the first frame update
    void Start()
    {
        // continue story and flower response
        storyInstance = FMODUnity.RuntimeManager.CreateInstance(ChapterEvent);
        storyInstance.start();
        
        butterflies.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        FMOD.Studio.PLAYBACK_STATE state;   
        storyInstance.getPlaybackState(out state);
        if(state == FMOD.Studio.PLAYBACK_STATE.STOPPED)
        {
            GetComponent<Chapter9>().enabled = true;
            this.enabled=false;
        }
    }
}
