using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HapticFeedbackXR : MonoBehaviour
{
    // Declare public variables for specifying the controller characteristics, duration, amplitude, and frequency of the haptic feedback
    public InputDeviceCharacteristics controllerCharacteristics;
    public float duration = 0.1f;
    public float amplitude = 0.5f;
    // public float frequency = 100f;

    // Declare a private InputDevice variable to store the target device
    private InputDevice targetDevice;

    // The Start method is called when the script is first initialized
    private void Start()
    {
        // Create a list to store the devices found with the specified controller characteristics
        List<InputDevice> devices = new List<InputDevice>();
        
        // Get the devices with the specified characteristics and store them in the list
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        // If at least one device is found, assign the first device in the list to the targetDevice variable and log its name
        if (devices.Count > 0)
        {
            targetDevice = devices[0];
            Debug.Log("Found device: " + targetDevice.name);
        }
    }

    // Declare a public method to trigger the haptic impulse on the controller
    public void TriggerHapticImpulse()
    {
        // Check if the target device is valid
        if (targetDevice.isValid)
        {
            // Send the haptic impulse to the target device with the specified amplitude and duration
            targetDevice.SendHapticImpulse(0, amplitude, duration);
        }
    }
}