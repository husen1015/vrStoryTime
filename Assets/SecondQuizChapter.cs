using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondQuizChapter : MonoBehaviour
{
    // QUIZ - the quiz that asks to get the butterflies inside the flower, before knowing that the white butterfly can't come in
    // (this will be shown when the player comes in to put the white butterfly in the flower and triggers the dialog that says the white flower can't come in)
    // to make sure that the player chooses his butterflies correctly (and not the white one first) we'll make sure to show one butterfly at a time, and display
    // the next one after it's been dragged into the flower.

    public GameObject butterflies;
    public GameObject QuizButterflies;

    // Start is called before the first frame update
    void Start()
    {
        butterflies.SetActive(false); // disappear the butterflies
    }

    // Update is called once per frame
    void Update()
    {
        // lionAnimation.SetBool("FinishedChapter8", true);
    }
}
