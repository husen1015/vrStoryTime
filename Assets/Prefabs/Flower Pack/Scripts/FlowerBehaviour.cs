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

    public GameObject colliderObj;
    public static bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }



    public void openFlower()
    {
        leaf1.GetComponent<TwoLayerLeaf>().OpenLeaf();
        leaf2.GetComponent<TwoLayerLeaf>().OpenLeaf();
        leaf3.GetComponent<TwoLayerLeaf>().OpenLeaf();
        leaf4.GetComponent<TwoLayerLeaf>().OpenLeaf();
        leaf5.GetComponent<TwoLayerLeaf>().OpenLeaf();
        leaf6.GetComponent<TwoLayerLeaf>().OpenLeaf();
        leaf7.GetComponent<TwoLayerLeaf>().OpenLeaf();
        leaf8.GetComponent<TwoLayerLeaf>().OpenLeaf();
        leaf9.GetComponent<TwoLayerLeaf>().OpenLeaf();
        isOpen = true;
    }

    public void closeFlower()
    {
        leaf1.GetComponent<TwoLayerLeaf>().CloseLeaf();
        leaf2.GetComponent<TwoLayerLeaf>().CloseLeaf();
        leaf3.GetComponent<TwoLayerLeaf>().CloseLeaf();
        leaf4.GetComponent<TwoLayerLeaf>().CloseLeaf();
        leaf5.GetComponent<TwoLayerLeaf>().CloseLeaf();
        leaf6.GetComponent<TwoLayerLeaf>().CloseLeaf();
        leaf7.GetComponent<TwoLayerLeaf>().CloseLeaf();
        leaf8.GetComponent<TwoLayerLeaf>().CloseLeaf();
        leaf9.GetComponent<TwoLayerLeaf>().CloseLeaf();
        isOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("yellowButt") || other.gameObject.CompareTag("redButt"))
        {
            openFlower();
        }
        else
        {
            //to do - add animation fot close flower
            closeFlower();
        }
    }




}
