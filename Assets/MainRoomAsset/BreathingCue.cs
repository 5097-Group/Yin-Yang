using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BreathingCue : MonoBehaviour
{
    
    // The duration of one complete breath cycle (in seconds)
    public float breathMinutes = 3.0f; 
    public float breathDuration = 4.0f;

    // The minimum and maximum scale of the visual cue
    public float minScale = 1.0f;
    public float maxScale = 2.0f;

    // The ease type to use for the breathing animation
    public iTween.EaseType easeType = iTween.EaseType.easeInOutQuad;

    // The initial scale of the visual cue
    private Vector3 initialScale;
    private DateTime startTime = DateTime.Now;



    // Start is called before the first frame update
    void Start()
    {
        // Store the initial scale of the visual cue
        initialScale = transform.localScale;
    }

    private void Update()
    {

    }

    public void ScaleUp()
    {
        TimeSpan elapsedTime = DateTime.Now - startTime;


        Hashtable args = new Hashtable();
        args.Add("name", "breathingAnimation");
        args.Add("time", breathDuration);
        args.Add("scale", initialScale * maxScale);
        args.Add("easetype", easeType);
        args.Add("looptype", "pingPong");
        args.Add("onstart", "ScaleUpHaptic");
        iTween.ScaleTo(gameObject, args);

        if (elapsedTime.TotalSeconds > breathMinutes * 60)
        {
            OnDisable();
        }
    }

    // Stop the breathing animation when the script is disabled or destroyed
    void OnDisable()
    {
        iTween.StopByName(gameObject, "breathingAnimation");
        transform.localScale = initialScale;
    }

    void ScaleUpHaptic()
    {
        Debug.Log("in scaleuphaptic, vibrate:");
    }

}