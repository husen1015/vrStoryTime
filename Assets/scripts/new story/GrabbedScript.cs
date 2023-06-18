using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbedScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlaceholderCube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCube()
    {
        PlaceholderCube.SetActive(true);
    }

    public void HideCube()
    {
        PlaceholderCube.SetActive(false);
    }
}
