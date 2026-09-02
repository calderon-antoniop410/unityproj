using UnityEngine;

public class LifecycleLogger : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake called");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable called");
    }

    private void Start()
    {
        Debug.Log("Start called");
    }

    private void Update()
    {
        if(Time.frameCount < 3) Debug.Log("Update, frame " + Time.frameCount);
    }

}