using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the butterflies continue to the white flower
/// </summary>
public class Chapter9 : MonoBehaviour
{
    public GameObject butterflies;
    public GameObject lion;

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
        
    }
}
