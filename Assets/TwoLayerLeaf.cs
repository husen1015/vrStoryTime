using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoLayerLeaf : MonoBehaviour
{

    public GameObject outerleaf;
    public GameObject innerleaf;
    public float animCutoff = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAnim()
    {
        StartCoroutine("startAfterTime");
    }

    IEnumerator startAfterTime()
    {
        float randomNumber = Random.Range(0, animCutoff);
        yield return new WaitForSeconds(randomNumber / animCutoff);
 
        outerleaf.GetComponent<Animator>().enabled = true;

        randomNumber = Random.Range(0, animCutoff);
        yield return new WaitForSeconds(randomNumber / animCutoff);

        innerleaf.GetComponent<Animator>().enabled = true;
    }
}
