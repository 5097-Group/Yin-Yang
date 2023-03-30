using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedController : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Slider speedSlider;
    private float objectSpeed;

    void Start()
    {
        // Set the default object speed using the slider value
        objectSpeed = speedSlider.value;
        
        // Add a listener to the slider to update the objectSpeed when the slider value changes
        speedSlider.onValueChanged.AddListener(delegate { UpdateSpeed(); });
    }

    public void SpawnObject()
    {
        // Instantiate the object at the desired position
        GameObject spawnedObject = Instantiate(objectToSpawn, new Vector3(-74, (float)-4.8, 24), Quaternion.identity);
        
        // Apply the selected speed to the spawned object
        Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = new Vector3(0, 0, objectSpeed);
        }
    }

    void UpdateSpeed()
    {
        objectSpeed = speedSlider.value;
    }
}