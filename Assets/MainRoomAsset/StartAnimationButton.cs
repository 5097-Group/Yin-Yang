using UnityEngine;
using UnityEngine.UI;

public class StartAnimationButton : MonoBehaviour
{
    public Animator targetAnimator;
    public void StartAnimation()
    {
        if (targetAnimator != null)
        {
            targetAnimator.SetTrigger("BuddyStart");
        }
    }
}