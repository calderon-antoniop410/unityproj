using UnityEngine;

public class TriggerLogger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{gameObject.name} collided with {collision.gameObject.name}");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"{gameObject.name} triggerered by {other.gameObject.name}");
    }
}