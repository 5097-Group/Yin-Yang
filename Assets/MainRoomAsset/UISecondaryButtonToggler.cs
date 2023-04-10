using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class UISecondaryButtonToggler : MonoBehaviour
{
    public GameObject uiElement;
    private XRController controller;

    void Start()
    {
        controller = GetComponent<XRController>();
        Debug.Log("get component" + controller);
    }

    void Update()
    {
        if (IsSecondaryButtonPressed())
        {
            ToggleUI();
        }
    }

    bool IsSecondaryButtonPressed()
    {
        return controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonPressed) && secondaryButtonPressed;
    }

    void ToggleUI()
    {
        uiElement.SetActive(!uiElement.activeSelf);
    }
}
