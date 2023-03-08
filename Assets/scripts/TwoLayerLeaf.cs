using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoLayerLeaf : MonoBehaviour
{

    public GameObject outerleaf;
    public GameObject innerleaf;
    public float animCutoff = 10;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenLeaf()
    {
        Debug.Log("Calling open...");
        string[] animations = {"LowerLeafAnimation", "UpperLeafAnim"};
        StartCoroutine("startAfterTime", animations);
    }

    IEnumerator startAfterTime(string[] animations)
    {
        Debug.Log("Opening...");
        float randomNumber = Random.Range(0, animCutoff);
        yield return new WaitForSeconds(randomNumber / animCutoff);
 
        outerleaf.GetComponent<Animator>().Play(animations[0],  -1, 0f);

        randomNumber = Random.Range(0, animCutoff);
        yield return new WaitForSeconds(randomNumber / animCutoff);

        innerleaf.GetComponent<Animator>().Play(animations[1],  -1, 0f);
    }

    public void CloseLeaf()
    {
        string[] animations = {"Lower Leaf Close Animation", "CloseAnim"};
        StartCoroutine("startAfterTime", animations);
    }
}
