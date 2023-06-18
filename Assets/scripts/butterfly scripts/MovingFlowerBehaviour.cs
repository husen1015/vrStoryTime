using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFlowerBehaviour : MonoBehaviour
{
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
        if(!other.CompareTag("Terrain") && !other.CompareTag("whiteButt") && !other.CompareTag("redButt") && !other.CompareTag("yellowButt"))
        {
            this.GetComponent<Rigidbody>().useGravity = true; // Enable
            this.GetComponent<Rigidbody>().isKinematic = false; // Disable
        }
    }
}
