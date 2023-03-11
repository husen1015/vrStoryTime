using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnter4C9 : MonoBehaviour
{
    public GameObject self;
    public GameObject redGrabbableParent;
    public GameObject yellowGrabbableParent;
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
        if(other.CompareTag("WhiteButtGrabbable"))
        {
            other.gameObject.SetActive(false);
            storyInstance = FMODUnity.RuntimeManager.CreateInstance("event:/CorrectSound"); // well done audio
            storyInstance.start();
            redGrabbableParent.SetActive(true);
            self.SetActive(false);
        }
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
            gameManager.GetComponent<ForthQuizChapter>().enabled = false;
            gameManager.GetComponent<ForthQuizFinished>().enabled = true;
            self.SetActive(false);
        }
    }
}
