using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject redButt;
    public GameObject Lion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Lion.transform.position.x < 120)
        {
            redButt.SetActive(true);
        }
    }
}
