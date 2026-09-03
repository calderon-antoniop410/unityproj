using UnityEngine;

public class LifecycleLogger : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake called by " + gameObject.name);
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable called by " + gameObject.name);
    }

    private void Start()
    {
        Debug.Log("Start called by " + gameObject.name);
    }

    private void Update()
    {
        if(Time.frameCount < 3) Debug.Log("Update, frame " + Time.frameCount);
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable called by " + gameObject.name);
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy called by " + gameObject.name);
    }

}