using UnityEngine;

public class CanvasFollowCamera : MonoBehaviour
{
    public Camera targetCamera;
    public float distanceFromCamera = 2f;
    public Vector3 offset = new Vector3(0, 0, 0);

    void Update()
    {
        if (targetCamera != null)
        {
            transform.position = targetCamera.transform.position + targetCamera.transform.forward * distanceFromCamera + offset;
            transform.rotation = targetCamera.transform.rotation;
        }
    }
}
