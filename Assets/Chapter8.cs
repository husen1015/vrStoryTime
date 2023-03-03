using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// butterflies try to enter the yellow flower. here the first interaction happens where the player can try to 
/// insert the butterflies into the flower
/// </summary>
public class Chapter8 : MonoBehaviour
{
    //gameObjects
    public GameObject yellowFlower;
    public GameObject butterflies;
    public GameObject lion;

    //gameObjects
    private GameObject whiteButt;
    private GameObject redButt;
    private GameObject yellowButt;
    private Vector3 flowerPos;

    //animators
    private Animator butterflyAnimator;
    private Animator lionAnimation;
    
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

        //turn the individual animators on- had to use individual animators in order to be able to change the butterfly's transform manually
        whiteButt.GetComponent<Animator>().enabled = true;
        redButt.GetComponent<Animator>().enabled = true;
        yellowButt.GetComponent<Animator>().enabled = true;



        //position the butterflies around the flower
        flowerPos = yellowFlower.transform.position;
        whiteButt.transform.position = new Vector3(flowerPos.x, flowerPos.y + 0.5f, flowerPos.z - 1);
        redButt.transform.position = new Vector3(flowerPos.x, flowerPos.y + 0.5f, flowerPos.z + 1);
        yellowButt.transform.position = new Vector3(flowerPos.x + 1, flowerPos.y + 0.5f, flowerPos.z );
        whiteButt.transform.LookAt(yellowFlower.transform);
        redButt.transform.LookAt(yellowFlower.transform);
        yellowButt.transform.LookAt(yellowFlower.transform);

    }

    // Update is called once per frame
    void Update()
    {

        //fmod stuff

        //temporary shift to chapter 8 until lucas implements passage through fmod
        if (FlowerBehaviour.isOpen)
        {
            whiteButt.GetComponent<Animator>().enabled = false;
            redButt.GetComponent<Animator>().enabled = false;
            yellowButt.GetComponent<Animator>().enabled = false;
            GetComponent<Chapter9>().enabled = true;
            this.enabled = false;
        }
    }
}
