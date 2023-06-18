using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  butterflies try to take shelter in the white flower. white flower only allowes the white butterfly in
/// </summary>
public class Chapter10 : MonoBehaviour
{

    public string ChapterEvent;
    public GameObject butterflies;

    public GameObject WhiteFlower;

    public GameObject lion;


    private Animator butterflyAnimator;

    private FMOD.Studio.EventInstance storyInstance;

    private Animator lionAnimation;
    // Start is called before the first frame update
    void Start()
    {
        lionAnimation = lion.GetComponent<Animator>();
        lionAnimation.SetBool("FinishedChapter9", true);

        WhiteFlower.GetComponent<FlowerBehaviour>().closeFlower();

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
            GetComponent<Chapter11>().enabled = true;
            this.enabled=false;
        }
    }
}
