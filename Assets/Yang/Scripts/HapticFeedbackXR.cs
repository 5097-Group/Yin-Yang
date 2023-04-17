// Import necessary namespaces

using System.Collections;
using UnityEngine;
using UnityEngine.XR;

public class HapticFeedbackXR : MonoBehaviour
{
    // Serialized fields for customizing haptic feedback in the inspector
    [SerializeField] private XRNode controllerNode; // The controller node, LeftHand or RightHand
    [SerializeField] private float duration = 0.1f; // Duration of the haptic feedback in seconds
    [SerializeField] private float frequency = 160.0f; // Frequency of the haptic feedback in hertz (ignored for Oculus controllers)
    [SerializeField] private float amplitude = 0.5f; // Amplitude (intensity) of the haptic feedback (range: 0-1)

    // Called when the hand controller enters a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider has the "Hole" tag
        if (other.CompareTag("Hole"))
        {
            // If it does, start the haptic feedback coroutine
            StartCoroutine(HapticCoroutine());
        }
    }

    // Coroutine for handling haptic feedback
    private IEnumerator HapticCoroutine()
    {
        // Get the InputDevice instance for the controller node
        InputDevice device = InputDevices.GetDeviceAtXRNode(controllerNode);
        
        // Declare a variable to store the haptic capabilities of the device
        HapticCapabilities capabilities;

        // Check if the device supports haptic feedback
        if (device.TryGetHapticCapabilities(out capabilities) && capabilities.supportsImpulse)
        {
            // Define the channel for sending the haptic impulse (0 is the default channel)
            uint channel = 0;
            
            // Send the haptic impulse to the device
            device.SendHapticImpulse(channel, amplitude, duration);
            
            // Wait for the duration of the haptic impulse
            yield return new WaitForSeconds(duration);
            
            // Stop the haptic impulse on the device
            // device.StopHapticImpulse(channel);
        }
    }
}
