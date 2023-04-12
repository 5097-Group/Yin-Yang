using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private int currentScore = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        ActionCollider.OnScoreIncremented += AddScore;
    }

    private void OnDisable()
    {
        ActionCollider.OnScoreIncremented -= AddScore;
    }

    public void AddScore(int value)
    {
        currentScore += value;
        Debug.Log("Score incremented: " + value + " | Current score: " + currentScore);
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }
}