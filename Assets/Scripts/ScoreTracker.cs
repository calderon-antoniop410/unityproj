// ScoreTracker.cs
// Used in: Slide 13 (save a value), Slide 14 (load it back), Slide 15 (reset with DeleteKey)
//
// Note: the slide's screenshot Inspector showed a component named
// "Score Manager" attached via a script called ScoreManager, which doesn't
// match the class name used in the slide's code and body text (ScoreTracker).
// This file uses ScoreTracker throughout so the class name, the file name,
// and the Inspector component name all agree once it's attached in Unity.
//
// Gotcha (also called out on Slide 13): with Active Input Handling set to
// the new Input System, the old Input.GetKeyDown(KeyCode.Space) throws an
// exception. Use Keyboard.current.spaceKey.wasPressedThisFrame instead.

using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreTracker : MonoBehaviour
{
    private int score = 0;

    private void Start()
    {
        // Step 2 (Slide 14): load the saved value back.
        // The second argument (0) is the default used if "HighScore"
        // has never been saved before.
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        Debug.Log("Loaded HighScore: " + highScore);
        score = highScore;
    }

    private void Update()
    {
        // Step 1 (Slide 13): save a value whenever the score changes.
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            score += 100;
            Debug.Log("Score: " + score);
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.Save();
        }

        // Step 3 (Slide 15): reset with DeleteKey.
        // Bound to a separate test key (R) so it doesn't collide with
        // the Space-to-score binding above.
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            PlayerPrefs.DeleteKey("HighScore");
            // Or, to clear everything at once: PlayerPrefs.DeleteAll();
            score = 0;
            Debug.Log("HighScore deleted. GetInt will now fall back to its default (0).");
        }
    }
}
