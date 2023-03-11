using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the butterflies continue to the white flower
/// </summary>
public class Chapter9 : MonoBehaviour
{

    public string ChapterEvent;
    public GameObject butterflies;

    public GameObject ColoredFlower;

    public GameObject lion;


    private Animator butterflyAnimator;

    private FMOD.Studio.EventInstance storyInstance;

    private Animator lionAnimation;
    // Start is called before the first frame update
    void Start()
    {
        lionAnimation = lion.GetComponent<Animator>();
        lionAnimation.SetBool("FinishedChapter8", true);

        ColoredFlower.GetComponent<FlowerBehaviour>().closeFlower();

        butterflyAnimator = butterflies.GetComponent<Animator>();
        butterflyAnimator.enabled = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        //fmod stuff

        //Debug.Log(lion.transform.localPosition.x);

        //temporary shift to chapter 10 until lucas implements passage through fmod
        // if (lion.transform.localPosition.x <= -39)
        // {
            
        //     GetComponent<Chapter10>().enabled = true;
        //     this.enabled = false;
        // }
    }
}
