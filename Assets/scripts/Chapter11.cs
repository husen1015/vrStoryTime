using DigitalRuby.RainMaker;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// butterflies continue to roam under the rain
/// </summary>
public class Chapter11 : MonoBehaviour
{
    //gameObjects
    public GameObject butterflies;
    public GameObject lion;

    //animators
    private Animator butterflyAnimator;
    private Animator lionAnimation;

    // Start is called before the first frame update
    void Start()
    {
        lionAnimation = lion.GetComponent<Animator>();
        butterflyAnimator = butterflies.GetComponent<Animator>();
        butterflyAnimator.enabled = true;
        lionAnimation.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        //fmod stuff
    }
}
