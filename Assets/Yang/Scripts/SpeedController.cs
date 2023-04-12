using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpeedController : MonoBehaviour
{
    public GameObject[] movingObjectPrefabs;
    public Slider speedSlider;
    public Button spawnButton;
    private bool spawning = false;

    void Start()
    {
        speedSlider.onValueChanged.AddListener(UpdateSpeed);
        // spawnButton.onClick.AddListener(ToggleSpawning);
    }

    
    
    IEnumerator SpawnObjectsWithDelay(float delay)
    {
        while (spawning)
        {
            for (int i = 0; i < movingObjectPrefabs.Length; i++)
            {
                GameObject movingObjectPrefab = movingObjectPrefabs[Random.Range(0, movingObjectPrefabs.Length)];
                GameObject spawnedObject = Instantiate(movingObjectPrefab, new Vector3(-74,(float)-4.8,24), Quaternion.Euler(0, 0, 0));
                MoveForward movingObjectScript = spawnedObject.GetComponent<MoveForward>();
                movingObjectScript.speed = speedSlider.value;

                // Wait for the specified delay
                yield return new WaitForSeconds(delay);
            }
        }
    }

    void UpdateSpeed(float newSpeed)
    {
        foreach (GameObject movingObjectPrefab in movingObjectPrefabs)
        {
            MoveForward movingObjectScript = movingObjectPrefab.GetComponent<MoveForward>();
            if (movingObjectScript != null)
            {
                movingObjectScript.speed = newSpeed;
            }
        }
    }

    void ToggleSpawning()
    {
        spawning = !spawning;

        if (spawning)
        {
            StartCoroutine(SpawnObjectsWithDelay(1.5f));
        }
    }
}