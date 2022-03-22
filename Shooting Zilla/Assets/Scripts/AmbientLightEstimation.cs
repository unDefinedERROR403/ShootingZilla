using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class AmbientLightEstimation : MonoBehaviour
{

    public ARCameraManager cameraManager;

    private Light lightComponent;

    public Text warningText;
   
   void OnEnable(){
       lightComponent = GetComponent<Light>();
       cameraManager.frameReceived += OnCameraFrameReceived;
   }

   void OnCameraFrameReceived(ARCameraFrameEventArgs camFrameEvent) {

       ARLightEstimationData led = camFrameEvent.lightEstimation;

       if(led.averageBrightness.HasValue)
       {
          lightComponent.intensity = led.averageBrightness.Value;
          if (led.averageBrightness.Value < 0.1f) {
              // show the warning
              warningText.gameObject.SetActive(true);
          }
          else
          {
              //Disable the warning text
               warningText.gameObject.SetActive(false);
          }
       }

       if(led.averageColorTemperature.HasValue)
       {
          lightComponent.colorTemperature = led.averageColorTemperature.Value;
       }
   }   

    void OnDisable()
   {
        cameraManager.frameReceived -= OnCameraFrameReceived;   
    }
 }
