using UnityEngine;

public class NullRefDemo : MonoBehaviour
{
    private PlayerStats stats;

    void Start()
    {
        stats = GetComponent<PlayerStats>();
        Debug.Log("Score is: " + stats.score);
    }
}