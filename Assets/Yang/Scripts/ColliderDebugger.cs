using UnityEngine;

public class ColliderDebugger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called for: " + other.gameObject.name);
    }
}