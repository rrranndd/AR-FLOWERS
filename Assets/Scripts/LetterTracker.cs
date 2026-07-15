using UnityEngine;
using Vuforia;

public class LetterTracker : MonoBehaviour
{
    public string letter;

    private ObserverBehaviour observer;

    private void Start()
    {
        observer = GetComponent<ObserverBehaviour>();
    }

    public bool IsTracked()
    {
        if (observer == null)
            return false;

        return observer.TargetStatus.Status == Status.TRACKED;
    }
}