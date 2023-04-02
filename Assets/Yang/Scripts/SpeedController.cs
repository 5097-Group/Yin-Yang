using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpeedController : MonoBehaviour
{
    public GameObject[] movingObjectPrefabs;
    public Slider speedSlider;
    public Button spawnButton;

    void Start()
    {
        speedSlider.onValueChanged.AddListener(UpdateSpeed);
        spawnButton.onClick.AddListener(() => StartCoroutine(SpawnObjectsWithDelay(2.0f)));
    }

    IEnumerator SpawnObjectsWithDelay(float delay)
    {
        foreach (GameObject movingObjectPrefab in movingObjectPrefabs)
        {
            GameObject spawnedObject = Instantiate(movingObjectPrefab, new Vector3(-74,(float)-4.8,24), Quaternion.Euler(0, 0, 0));
            MoveForward movingObjectScript = spawnedObject.GetComponent<MoveForward>();
            movingObjectScript.speed = speedSlider.value;

            // Wait for the specified delay
            yield return new WaitForSeconds(delay);
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
}