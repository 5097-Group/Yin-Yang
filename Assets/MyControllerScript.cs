using UnityEngine;
using UnityEngine.InputSystem;

public class MyControllerScript : MonoBehaviour
{
    private InputAction primaryButtonAction;

    private void Awake()
    {
        primaryButtonAction = new InputAction("PrimaryButtonPress", InputActionType.Button, "<Mouse>/leftButton");
        primaryButtonAction.Enable();
        primaryButtonAction.performed += OnPrimaryButtonPress;
    }

    private void OnPrimaryButtonPress(InputAction.CallbackContext context)
    {
        Debug.Log("Primary button pressed!");
        // Call your method or trigger an event here
    }

    private void OnDestroy()
    {
        primaryButtonAction.performed -= OnPrimaryButtonPress;
    }
}
