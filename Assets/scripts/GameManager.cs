using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    public GameObject redButt;
    public GameObject Lion;

    private bool reachedRedButt = false;
    private Animator animator;
    private int Waiting_Time = 20;
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
            StartCoroutine("waitTenSeconds");
            
        }
    }

    //this function waits for 'time' seconds before continuing, it does so by simply being stuck in a loop. can make it more effeciently in the future
    void waitforConvo(int time)
    {
        //curr time
        DateTime start = DateTime.Now;
        DateTime end = start;

        //// while currTime - startTime < seconds wait
        //while ((end - start).TotalSeconds < time)
        //{
        //    //wait
        //    end = DateTime.Now;
        //}
        Debug.Log(start);

    }
    IEnumerator waitTenSeconds()
    {
        yield return new WaitForSeconds(Waiting_Time);
        // SET BOOL TO FALSE WHEN 5 SECONDS PASSED
        animator.SetBool("wait", false);
    }



}
