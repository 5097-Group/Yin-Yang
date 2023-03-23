using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] danceWallPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        DisableWalls();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableWalls()
    {
        InvokeRepeating("SpawnRandomDanceWall", 0, 1.5f);

    }

    public void DisableWalls()
    {
        CancelInvoke();
    }

    void SpawnRandomDanceWall()
    {
        int danceWallIndex = Random.Range(0, danceWallPrefabs.Length);
        Vector3 spawnPos = new Vector3(-74,-7,30);
        //Vector3 spawnPos = new Vector3(transform.position);
        Instantiate(danceWallPrefabs[danceWallIndex], spawnPos, danceWallPrefabs[danceWallIndex].transform.rotation);
    }
}