using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject uiPanel;
    public BreathingCue breathingCue;

    public void startBreath()
    {
        uiPanel.SetActive(false);
        Debug.Log("try breathingCue");
        breathingCue.ScaleUp();
    }
}
