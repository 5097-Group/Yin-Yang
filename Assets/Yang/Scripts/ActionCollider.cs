using System.Collections;
using UnityEngine;

public class ActionCollider : MonoBehaviour
{
    public int scoreValue = 10;
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called");

        if (other.CompareTag("Hole") && !hasTriggered)
        {
            hasTriggered = true;
            PlayerAction playerAction = GetComponent<PlayerAction>();

            if (playerAction != null)
            {
                // Award points for performing the correct action
                ScoreManager.Instance.AddScore(scoreValue);
                Debug.Log("Score incremented: " + scoreValue + " | Object: " + gameObject.name);

                // Start the coroutine to reset the hasTriggered flag after a small delay
                StartCoroutine(ResetTriggerCoroutine());
            }
            else
            {
                Debug.Log("PlayerAction component not found on colliding object");
            }
        }
    }

    // Coroutine to reset the hasTriggered flag after a small delay
    IEnumerator ResetTriggerCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        hasTriggered = false;
    }
}