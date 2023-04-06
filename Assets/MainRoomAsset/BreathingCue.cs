using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using System.Collections.Generic;

public class BreathingCue : MonoBehaviour
{
    public Text breathModeText;

    public void StartBreathMode()
    {
        StartCoroutine(ScaleSphere());
    }

    IEnumerator ScaleSphere()
    {
        float timer = 0f;
        float duration = 180f; // 3 minutes
        float cycleDuration = 6f; // 3 seconds up + 3 seconds down
        float halfCycleDuration = cycleDuration / 2;
        float scaleFactor = 0.5f;
        Vector3 initialScale = transform.localScale;

        while (timer < duration)
        {
            timer += Time.deltaTime;
            float cycleTimer = timer % cycleDuration;

            float lerpValue;
            if (cycleTimer < halfCycleDuration)
            {
                lerpValue = cycleTimer / halfCycleDuration; // Range: 0 to 1
                if (breathModeText.text != "Breathe In")
                {
                    breathModeText.text = "Breathe In";
                    //SendHapticImpulseToControllers(0.5f);
                }
            }
            else
            {
                lerpValue = (cycleTimer - halfCycleDuration) / halfCycleDuration; // Range: 0 to 1
                lerpValue = 1 - lerpValue; // Invert the range: 1 to 0
                if (breathModeText.text != "Breathe Out")
                {
                    breathModeText.text = "Breathe Out";
                    
                }
            }

            transform.localScale = initialScale * (1 + (scaleFactor * lerpValue));
            yield return null;
        }

        breathModeText.text = "";
        //OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
        transform.localScale = initialScale;



    }

    void SendHapticImpulseToControllers(float amplitude)
    {
        var devices = new List<UnityEngine.XR.InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Left, devices);
        InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Right, devices);

        foreach (var controller in devices)
        {
            controller.SendHapticImpulse(0, amplitude, 3f);
        }
    }

}
