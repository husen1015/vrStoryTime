using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{
    public float rotationSpeed;

    private Material skybox;
    public bool fadeToCloudyWeather = false;
    private float tFactor = 0.6f; // time factor
    private float sunnyValue = 0.6f; // upper limit for sunny weather
    private float cloudyValue = 0.3f; //lower limit for cloudy weather
    private float fadeSpeed = 0.1f; 
    // Start is called before the first frame update
    void Start()
    {
        skybox = RenderSettings.skybox;
        skybox.SetColor("_Tint", new Color(161, 153, 153, 1));
    }

    // Update is called once per frame
    void Update()
    {

        skybox.SetFloat("_Rotation", skybox.GetFloat("_Rotation") + Time.deltaTime * rotationSpeed);

        if(fadeToCloudyWeather && tFactor >= cloudyValue) // fade to cloudy weather
        {
            tFactor -= Time.deltaTime * fadeSpeed;
            skybox.SetColor("_Tint", new Color(tFactor, tFactor, tFactor, 1));

        }
        else if(!fadeToCloudyWeather && tFactor <= sunnyValue)// fade to sunny weather
        {
            tFactor += Time.deltaTime * fadeSpeed;
            skybox.SetColor("_Tint", new Color(tFactor, tFactor, tFactor, 1));
        }
    }
}
