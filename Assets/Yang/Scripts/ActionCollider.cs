using System;
using System.Collections;
using UnityEngine;

public class ActionCollider : MonoBehaviour
{
    public int maxScoreValue = 10;
    public float maxDistance = 1.0f; // The maximum distance for a perfect score
    private bool hasTriggered = false;
    public HapticFeedbackXR hapticFeedback;

    public static event Action<int> OnScoreIncremented;

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("OnTriggerEnter called");

        if (other.CompareTag("Hole") && !hasTriggered)
        {
            hasTriggered = true;
            GameObject[] playerHands = GameObject.FindGameObjectsWithTag("PlayerHand");

            if (playerHands.Length > 0)
            {
                int totalScore = 0;

                foreach (GameObject playerHand in playerHands)
                {
                    int score = CalculateScore(playerHand.transform.position, other.transform.position);
                    totalScore += score;
                }

                OnScoreIncremented?.Invoke(totalScore);
                StartCoroutine(ResetTriggerCoroutine());
                
                // Trigger haptic feedback
                hapticFeedback.TriggerHapticImpulse();
            }
            else
            {
                // Debug.Log("HandTarget GameObjects not found");
            }
        }
    }

    private int CalculateScore(Vector3 playerHandPosition, Vector3 holePosition)
    {
        // Calculate the distance between playerHand and hole
        float distance = Vector3.Distance(playerHandPosition, holePosition);

        // Map the distance to a score between 0 and maxScoreValue
        int score = Mathf.RoundToInt(maxScoreValue * (1f - Mathf.Clamp01(distance / maxDistance)));

        return score;
    }

    private IEnumerator ResetTriggerCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        hasTriggered = false;
    }
}