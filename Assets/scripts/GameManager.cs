using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    public GameObject redButt;
    public GameObject yellowButt;
    public GameObject Lion;

    private Animator animator;
    private bool reachedRedButt = false;
    private bool reachedYellowButt = false;
    private int Waiting_Time = 2; // used for pausing the lion walk animation until the conversation is over

    // Start is called before the first frame update
    void Start()
    {
        // Create a timer with a 5 second interval.
        animator = Lion.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //make the red butterfly appear
        if (!reachedRedButt & Lion.transform.position.x < 120 )
        {
            reachedRedButt = true;
            redButt.SetActive(true);
            //waitforConvo(5);
            StartCoroutine("waitXSeconds");
            
        }

        //make the yellow butterfly appear
        if (!reachedYellowButt & Lion.transform.position.x < 110)
        {
            Debug.Log("yellow");
            reachedYellowButt = true;
            yellowButt.SetActive(true);
            StartCoroutine("waitXSeconds");

        }
    }


    IEnumerator waitXSeconds()
    {
        yield return new WaitForSeconds(Waiting_Time);
        // SET BOOL TO FALSE WHEN Waiting_Time in SECONDS PASSED
        animator.SetBool("wait", false);
    }



}
