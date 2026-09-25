using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
// The exact scene name as listed in Build Settings
    private const string PauseSceneName = "PauseMenuUI"; 
    
    // Tracks whether the game is currently paused
    private bool isPaused = false;

    void Update()
    {
        // Toggle when ESC is pressed
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f; // Freezes all 2D physics and time-based movements
        SceneManager.LoadScene(PauseSceneName, LoadSceneMode.Additive);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Unfreezes the game back to normal speed
        SceneManager.UnloadSceneAsync(PauseSceneName);
    }
}
