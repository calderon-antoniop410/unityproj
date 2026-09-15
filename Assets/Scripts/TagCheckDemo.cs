using UnityEngine;

public class TagCheckDemo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Hit an enemy");
        }
    }
}