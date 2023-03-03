using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter10 : MonoBehaviour
{
    //gameObjects
    public GameObject butterflies;
    public GameObject lion;
    public GameObject whiteFlower;

    //animators
    private Animator butterflyAnimator;
    private Animator lionAnimation;

    //butterflies
    private GameObject whiteButt;
    private GameObject redButt;
    private GameObject yellowButt;

    private Vector3 flowerPos;

    // Start is called before the first frame update
    void Start()
    {
        lionAnimation = lion.GetComponent<Animator>();
        butterflyAnimator = butterflies.GetComponent<Animator>();
        butterflyAnimator.enabled = false;
        lionAnimation.enabled = false;

        whiteButt = butterflies.transform.GetChild(0).gameObject;
        yellowButt = butterflies.transform.GetChild(1).gameObject;
        redButt = butterflies.transform.GetChild(2).gameObject;

        //position the butterflies around the flower
        flowerPos = whiteFlower.transform.position;
        whiteButt.transform.position = new Vector3(flowerPos.x, flowerPos.y + 0.5f, flowerPos.z - 1);
        redButt.transform.position = new Vector3(flowerPos.x, flowerPos.y + 0.5f, flowerPos.z + 1);
        yellowButt.transform.position = new Vector3(flowerPos.x + 1, flowerPos.y + 0.5f, flowerPos.z);
        whiteButt.transform.LookAt(whiteFlower.transform);
        redButt.transform.LookAt(whiteFlower.transform);
        yellowButt.transform.LookAt(whiteFlower.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
