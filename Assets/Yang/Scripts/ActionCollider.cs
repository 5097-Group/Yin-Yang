using UnityEngine;

public class ActionCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called");

        if (other.CompareTag("Hole"))
        {
            PlayerAction playerAction = GetComponent<PlayerAction>();

            if (playerAction != null)
            {
                // Award points for performing the correct action
                ScoreManager.Instance.AddScore(10);
            }
            else
            {
                Debug.Log("PlayerAction component not found on colliding object");
            }
        }
    }
}