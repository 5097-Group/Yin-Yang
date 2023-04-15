using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlFire : MonoBehaviour
{
    public ParticleSystem fire;
    public ParticleSystem rain;
    
    public AudioSource fireSound;
    public AudioSource rainSound;

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
                    if (!fire.isPlaying) {
                        fire.Play();
                        fireSound.Play();
                    }
                    else {
                        fire.Stop();
                        fireSound.Stop();
                    }
                }
                else if (hit.collider.gameObject.tag == "Cloud")
                {
                    if (!rain.isPlaying) {
                        rain.Play();
                        rainSound.Play();
                    }
                    else {
                        rain.Stop();
                        rainSound.Stop();
                    }
                }
            }
        }
    }
}
