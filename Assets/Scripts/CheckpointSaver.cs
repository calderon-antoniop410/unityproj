using UnityEngine;
using UnityEngine.InputSystem;

public class CheckpointSaver : MonoBehaviour
{
    [SerializeField] 
    private int checkpointNumber = 0;

    private void Start()
    {
        // Loads saved checkpoint on start (defaults to 0 if key does not exist)
        
        // code for exercise 10
        // PlayerPrefs.DeleteKey("PlayerCheckpoint");
        // PlayerPrefs.Save();

        int loadedCheckpoint = PlayerPrefs.GetInt("PlayerCheckpoint", 0);
        Debug.Log("Loaded Checkpoint: " + loadedCheckpoint);
    }

    // Called automatically via Player Input (Send Messages) when Interact fires
    public void OnInteract(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Checkpoint activated");

            PlayerPrefs.SetInt("PlayerCheckpoint", checkpointNumber);
            PlayerPrefs.Save();

            Debug.Log("Saved Checkpoint Number: " + checkpointNumber);
        }
    }
}