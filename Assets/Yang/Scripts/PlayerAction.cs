using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ActionCollider actionCollider = other.GetComponent<ActionCollider>();

        if (actionCollider != null)
        {
            // Award points for performing the correct action
            ScoreManager.Instance.AddScore(10);
        }
    }
}