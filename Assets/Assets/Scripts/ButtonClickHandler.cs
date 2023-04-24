using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonClickHandler : MonoBehaviour, IPointerClickHandler
{
    public ParticleSystem fire;
    public ParticleSystem rain;

    public AudioSource fireSound;
    public AudioSource rainSound;

    public void OnPointerClick(PointerEventData eventData)
    {
        // Do something when the button is clicked
        if (
            Physics.Raycast(
                transform.position,
                transform.forward,
                out RaycastHit hit,
                Mathf.Infinity
            )
        )
        {
            if (hit.collider.gameObject.tag == "Wood")
            {
                if (!fire.isPlaying)
                {
                    fire.Play();
                    fireSound.Play();
                }
                else
                {
                    fire.Stop();
                    fireSound.Stop();
                }
            }
            else if (hit.collider.gameObject.tag == "Cloud")
            {
                if (!rain.isPlaying)
                {
                    rain.Play();
                    rainSound.Play();
                }
                else
                {
                    rain.Stop();
                    rainSound.Stop();
                }
            }
        }
    }
}
