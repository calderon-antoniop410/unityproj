// ScoreTrackerWithName.cs
// Used in: Slide 17, Extra Challenge (PlayerPrefs)
//
// Extends ScoreTracker.cs with a string value (a player name) saved via
// PlayerPrefs.SetString and loaded via GetString. Uses PlayerPrefs.HasKey
// to tell "never saved before" apart from "saved, but happens to be empty,"
// so we don't load a blank name on someone's very first run.

using UnityEngine;
using UnityEngine.InputSystem;

public class ScoreTrackerWithName : MonoBehaviour
{
    private int score = 0;
    private string playerName = "Player";

    private void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        score = highScore;

        // Check before loading, rather than loading blindly, so a
        // first-time player gets a sensible default instead of "".
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            playerName = PlayerPrefs.GetString("PlayerName");
        }
        else
        {
            playerName = "Player";
        }

        Debug.Log("Welcome back, " + playerName + "! High score: " + highScore);
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            score += 100;
            Debug.Log(playerName + "'s score: " + score);
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.SetString("PlayerName", playerName);
            PlayerPrefs.Save();
        }

        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            PlayerPrefs.DeleteKey("HighScore");
            PlayerPrefs.DeleteKey("PlayerName");
            score = 0;
            playerName = "Player";
            Debug.Log("Save data deleted. Both values will fall back to their defaults.");
        }
    }
}
