using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderEntered : MonoBehaviour
{
    public GameObject self;
    public GameObject yellowGrabbableParent;
    public GameObject whiteGrabbableParent;
    private FMOD.Studio.EventInstance storyInstance;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("RedButtGrabbable"))
        {
            other.gameObject.SetActive(false);
            storyInstance = FMODUnity.RuntimeManager.CreateInstance("event:/CorrectSound"); // well done audio
            storyInstance.start();
            yellowGrabbableParent.SetActive(true);
            self.SetActive(false);
        }
        if(other.CompareTag("YellowButtGrabbable"))
        {
            other.gameObject.SetActive(false);
            storyInstance = FMODUnity.RuntimeManager.CreateInstance("event:/CorrectSound"); // well done audio
            storyInstance.start();
            whiteGrabbableParent.SetActive(true);
            self.SetActive(false);
        }
        if(other.CompareTag("WhiteButtGrabbable"))
        {
            other.gameObject.SetActive(false);
            storyInstance = FMODUnity.RuntimeManager.CreateInstance("event:/CorrectSound"); // well done audio
            storyInstance.start();
            gameManager.GetComponent<SecondQuizChapter>().enabled = false;
            gameManager.GetComponent<SecondQuizFinished>().enabled = true;
            self.SetActive(false);
        }
    }
}
