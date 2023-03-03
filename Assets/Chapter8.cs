using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// butterflies try to enter the yellow flower
/// </summary>
public class Chapter8 : MonoBehaviour
{
    public GameObject yellowFlower;
    public GameObject butterflies;
    public GameObject lion;

    private GameObject whiteButt;
    private GameObject redButt;
    private GameObject yellowButt;
    private Vector3 flowerPos ;
    private Animator butterflyAnimator;
    private Animator lionAnimation;

    // Start is called before the first frame update
    void Start()
    {
        lionAnimation.enabled = false;

        whiteButt = butterflies.transform.GetChild(0).gameObject;
        yellowButt = butterflies.transform.GetChild(1).gameObject;
        redButt = butterflies.transform.GetChild(2).gameObject;
        butterflyAnimator = butterflies.GetComponent<Animator>();


        //position the butterflies around the flower
        flowerPos = yellowFlower.transform.position;
        whiteButt.transform.position = new Vector3(flowerPos.x, flowerPos.y, flowerPos.z - 2);
        redButt.transform.position = new Vector3(flowerPos.x, flowerPos.y, flowerPos.z + 2);
        yellowButt.transform.position = new Vector3(flowerPos.x + 1, flowerPos.y, flowerPos.z );
        whiteButt.transform.LookAt(yellowFlower.transform);
        redButt.transform.LookAt(yellowFlower.transform);
        yellowButt.transform.LookAt(yellowFlower.transform);
        butterflyAnimator.SetBool("shouldFloar", true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
