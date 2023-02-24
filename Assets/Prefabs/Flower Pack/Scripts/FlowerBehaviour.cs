using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBehaviour : MonoBehaviour
{

    public GameObject leaf1;
    public GameObject leaf2;
    public GameObject leaf3;
    public GameObject leaf4;
    public GameObject leaf5;
    public GameObject leaf6;
    public GameObject leaf7;
    public GameObject leaf8;
    public GameObject leaf9;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void openFlower()
    {
        leaf1.GetComponent<TwoLayerLeaf>().StartAnim();
        leaf2.GetComponent<TwoLayerLeaf>().StartAnim();
        leaf3.GetComponent<TwoLayerLeaf>().StartAnim();
        leaf4.GetComponent<TwoLayerLeaf>().StartAnim();
        leaf5.GetComponent<TwoLayerLeaf>().StartAnim();
        leaf6.GetComponent<TwoLayerLeaf>().StartAnim();
        leaf7.GetComponent<TwoLayerLeaf>().StartAnim();
        leaf8.GetComponent<TwoLayerLeaf>().StartAnim();
        leaf9.GetComponent<TwoLayerLeaf>().StartAnim();
    }

    private void OnTriggerEnter(Collider other)
    {
        openFlower();
    }


}
