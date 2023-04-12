using System;
using System.Collections;
using UnityEngine;

public class ActionCollider : MonoBehaviour
{
    public int scoreValue = 10;
    private bool hasTriggered = false;

    public static event Action<int> OnScoreIncremented;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called");

        if (other.CompareTag("Hole") && !hasTriggered)
        {
            hasTriggered = true;
            PlayerAction playerAction = GetComponent<PlayerAction>();

            if (playerAction != null)
            {
                OnScoreIncremented?.Invoke(scoreValue);
                StartCoroutine(ResetTriggerCoroutine());
            }
            else
            {
                Debug.Log("PlayerAction component not found on colliding object");
            }
        }
    }

    private IEnumerator ResetTriggerCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        hasTriggered = false;
    }
}