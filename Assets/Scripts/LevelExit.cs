using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class LevelExit : MonoBehaviour
{
    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GoToLevel2();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        GoToLevel2();
    }
}
