using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    public GameObject whiteButt;
    public GameObject redButt;
    public GameObject yellowButt;
    public GameObject Lion;

    public GameObject flower1;

    public GameObject flower2;

    private Animator animator;
    private bool reachedRedButt = false;
    private bool reachedYellowButt = false;
    private int Waiting_Time = 20; // used for pausing the lion walk animation until the conversation is over

    // FMOD settingd
    private FMOD.Studio.EventInstance generalInstance;

    private FMOD.Studio.EventInstance storyInstance;

    // Story Settings
    List<string> ChaptersList = new List<string> { "event:/Story Part 1", "event:/Story Part 2" };
    int currChapter = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = Lion.GetComponent<Animator>();
        generalInstance = FMODUnity.RuntimeManager.CreateInstance("event:/Background music");
        generalInstance.start();

        // open flowers
        flower1.GetComponent<FlowerBehaviour>().openFlower();
        flower2.GetComponent<FlowerBehaviour>().openFlower();

    }

    // Update is called once per frame
    void Update()
    {

        // FMOD.Studio.PLAYBACK_STATE state;   
        // storyInstance.getPlaybackState(out state);
        // if(state == FMOD.Studio.PLAYBACK_STATE.STOPPED)
        // {
        //     loadNextChapter();
        //     animator.enabled=true;
        // }

        // //make the red butterfly appear
        // if (!reachedRedButt & Lion.transform.position.x < 120 )
        // {
        //     reachedRedButt = true;
        //     redButt.SetActive(true);
        //     //waitforConvo(5);
        //     StartCoroutine("waitXSeconds");

        // }

        // //make the yellow butterfly appear
        // if (!reachedYellowButt & Lion.transform.position.x < 110)
        // {
        //     Debug.Log("yellow");
        //     reachedYellowButt = true;
        //     yellowButt.SetActive(true);
        //     StartCoroutine("waitXSeconds");

        // }
    }





}