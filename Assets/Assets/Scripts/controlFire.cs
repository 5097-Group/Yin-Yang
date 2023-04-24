// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.InputSystem.XR;
// using UnityEngine.XR;

// using UnityEngine;
// using UnityEngine.InputSystem;
// using InputDevice = UnityEngine.XR.InputDevice;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class controlFire : MonoBehaviour
{
    public ParticleSystem fire;
    public ParticleSystem rain;

    public AudioSource fireSound;
    public AudioSource rainSound;

    private UnityEngine.XR.InputDevice device;
    private InputAction primaryButtonAction;

    // Start is called before the first frame update
    void Start()
    {
        // Get a reference to the Oculus Quest controller device
        device = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);

        // Set up the primary button action
        primaryButtonAction = new InputAction(
            "PrimaryButton",
            InputActionType.Button,
            "<XRController>/primaryButton"
        );
        primaryButtonAction.performed += OnPrimaryButtonPress;
        primaryButtonAction.Enable();
    }

    public void OnPrimaryButtonPress(InputAction.CallbackContext context)
    {
        Debug.Log("Primary button pressed!");
        // Call your method or trigger an event here

        if (context.performed)
        {
            if (
                Physics.Raycast(
                    transform.position,
                    transform.forward,
                    out RaycastHit hit,
                    Mathf.Infinity
                )
            )
            {
                if (hit.collider.gameObject.tag == "Wood")
                {
                    if (!fire.isPlaying)
                    {
                        fire.Play();
                        fireSound.Play();
                    }
                    else
                    {
                        fire.Stop();
                        fireSound.Stop();
                    }
                }
                else if (hit.collider.gameObject.tag == "Cloud")
                {
                    if (!rain.isPlaying)
                    {
                        rain.Play();
                        rainSound.Play();
                    }
                    else
                    {
                        rain.Stop();
                        rainSound.Stop();
                    }
                }
            }
        }
    }

    private void OnDestroy()
    {
        primaryButtonAction.performed -= OnPrimaryButtonPress;
    }

    // private bool buttonPressed = false;

    // public GameObject raycastLine;



    // // Update is called once per frame
    // void Update()
    // {
    //     if (
    //         Physics.Raycast(
    //             transform.position,
    //             transform.forward,
    //             out RaycastHit hit,
    //             Mathf.Infinity
    //         )
    //     )
    //     {
    //         if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
    //         {
    //             if (hit.collider.gameObject.tag == "Wood")
    //             {
    //                 if (!fire.isPlaying) {
    //                     fire.Play();
    //                     fireSound.Play();
    //                 }
    //                 else {
    //                     fire.Stop();
    //                     fireSound.Stop();
    //                 }
    //             }
    //             else if (hit.collider.gameObject.tag == "Cloud")
    //             {
    //                 if (!rain.isPlaying) {
    //                     rain.Play();
    //                     rainSound.Play();
    //                 }
    //                 else {
    //                     rain.Stop();
    //                     rainSound.Stop();
    //                 }
    //             }
    //         }
    //     }
    // }
}
