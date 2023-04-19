using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMoveForward : MonoBehaviour
{
    public float speed = 0.2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.forward * (speed * Time.deltaTime)));
    }
}
