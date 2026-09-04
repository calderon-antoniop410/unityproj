using UnityEngine;

public class Pickup : MonoBehaviour
{
public class PlayerStats : MonoBehaviour
{
    public int score = 0;
}
    private PlayerStats stats;

    void Start()
    {
        Debug.Log("Score is: " + stats.score);
    }
}