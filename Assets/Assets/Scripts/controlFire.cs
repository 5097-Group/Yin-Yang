using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlFire : MonoBehaviour
{
    public GameObject fireObject;

    // private bool buttonPressed = false;

    // public GameObject raycastLine;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (
            Physics.Raycast(
                transform.position,
                transform.forward,
                out RaycastHit hit,
                Mathf.Infinity
            )
        )
        {
            if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
            {
                if (hit.collider.gameObject.tag == "Wood")
                {
                    Debug.LogFormat("fire object before switch: {0}", fireObject.activeSelf);
                    fireObject.SetActive(!fireObject.activeSelf);
                    Debug.LogFormat("fire object after switch: {0}", fireObject.activeSelf);
                }
            }
        }
    }
}
