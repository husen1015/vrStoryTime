using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdQuizChapter : MonoBehaviour
{
 // QUIZ - the quiz that asks to help the butterflies wake up the flower
    public string ChapterEvent;

    public GameObject ColoredFlower;
    private FMOD.Studio.EventInstance storyInstance;

    bool isDone;

    bool isCheering;

    FlowerBehaviour flowerScript;
    // Start is called before the first frame update
    void Start()
    {
        // start dialog for player (what to do)
        storyInstance = FMODUnity.RuntimeManager.CreateInstance(ChapterEvent);
        storyInstance.start();
        flowerScript = ColoredFlower.GetComponent<FlowerBehaviour>();

        isCheering = false;
        isDone = false;
    }

    void FixedUpdate()
    {
        if(ColoredFlower.GetComponent<FlowerBehaviour>().opened == true && !isCheering)
        {
            storyInstance.release();
            storyInstance = FMODUnity.RuntimeManager.CreateInstance("event:/CorrectSound"); // well done audio
            storyInstance.start();
            isCheering = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        FMOD.Studio.PLAYBACK_STATE state;   
        storyInstance.getPlaybackState(out state);
        if(state == FMOD.Studio.PLAYBACK_STATE.STOPPED && isCheering)
        {
            if (isCheering && !isDone)
            {
                GetComponent<ForthQuizChapter>().enabled = true;
                this.enabled=false;
            }

        }

    }
}
