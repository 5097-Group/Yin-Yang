using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreathingCue : MonoBehaviour
{
    // The duration of one complete breath cycle (in seconds)
    public float breathDuration = 4.0f;

    // The minimum and maximum scale of the visual cue
    public float minScale = 1.0f;
    public float maxScale = 2.0f;

    // The ease type to use for the breathing animation
    public iTween.EaseType easeType = iTween.EaseType.easeInOutQuad;

    // Whether to loop the breathing animation
    public bool loop = true;

    // The initial scale of the visual cue
    private Vector3 initialScale;


    // Start is called before the first frame update
    void Start()
    {
        // Store the initial scale of the visual cue
        initialScale = transform.localScale;
        ScaleUp();
    }

    void ScaleUp()
    {
        Hashtable args = new Hashtable();
        args.Add("name", "breathingAnimation");
        args.Add("time", breathDuration);
        args.Add("scale", initialScale * maxScale);
        args.Add("easetype", easeType);
        args.Add("looptype", loop ? iTween.LoopType.loop : iTween.LoopType.none);
        args.Add("oncomplete", "ScaleDown");
        iTween.ScaleTo(gameObject, args);
    }

    // Stop the breathing animation when the script is disabled or destroyed
    void OnDisable()
    {
        iTween.StopByName(gameObject, "breathingAnimation");
        transform.localScale = initialScale;
    }

    void ScaleDown()
    {
        Hashtable args = new Hashtable();
        args.Add("name", "breathingAnimation");
        args.Add("time", breathDuration);
        args.Add("scale", transform.localScale);
        args.Add("easetype", easeType);
        args.Add("onComplete", "ScaleUp");
        iTween.ScaleTo(gameObject, args);
    }
}