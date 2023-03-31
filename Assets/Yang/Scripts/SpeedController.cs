using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpeedController : MonoBehaviour
{
    public GameObject[] movingObjectPrefabs;
    public Slider speedSlider;
    public Button spawnButton;
    private float objectSpeed;

    void Start()
    {
        objectSpeed = speedSlider.value;
        speedSlider.onValueChanged.AddListener(UpdateSpeed);
        spawnButton.onClick.AddListener(() => StartCoroutine(SpawnObjectsWithDelay(2.0f)));
    }

    void UpdateSpeed(float newSpeed)
    {
        objectSpeed = newSpeed;
    }

    IEnumerator SpawnObjectsWithDelay(float delay)
    {
        foreach (GameObject movingObjectPrefab in movingObjectPrefabs)
        {
            GameObject spawnedObject = Instantiate(movingObjectPrefab, new Vector3(-74,(float)-4.8,24), Quaternion.identity);
            spawnedObject.transform.Translate(-Vector3.forward * (objectSpeed * Time.deltaTime));

            // Wait for the specified delay
            yield return new WaitForSeconds(delay);
        }
    }
}