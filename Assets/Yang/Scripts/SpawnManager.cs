using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] danceWallPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomDanceWall", 5, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomDanceWall()
    {
        int danceWallIndex = Random.Range(0, danceWallPrefabs.Length);
        Vector3 spawnPos = new Vector3((float)1538.5, 641, 100);
        Instantiate(danceWallPrefabs[danceWallIndex], spawnPos, danceWallPrefabs[danceWallIndex].transform.rotation);
    }
}
