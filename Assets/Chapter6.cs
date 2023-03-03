using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the 3 butterflies roam a sunny and pleasant forest
/// </summary>
public class Chapter6 : MonoBehaviour
{
    public GameObject lion;
    public GameObject butterflies;

    private Animator lionAnimation;
    private Animator butterflyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        butterflyAnimator = butterflies.GetComponent<Animator>();
        lionAnimation = lion.GetComponent<Animator>();
        lionAnimation.enabled = true;
        butterflyAnimator.SetBool("shouldMeet2", false);
        //fmod stuff

    }

    // Update is called once per frame
    void Update()
    {

        //fmod stuff
        
        //temporary shift to chapter 7 until lucas implements passage through fmod
        if(lion.transform.localPosition.x < -30)
        {
            Debug.Log("ok");
            GetComponent<Chapter7>().enabled = true;
            this.enabled = false;
        }
    }
}
