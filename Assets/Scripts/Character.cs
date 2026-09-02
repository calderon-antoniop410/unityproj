using UnityEngine;

public class Character : MonoBehaviour
{
    public int health = 100;
    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log(gameObject.name + " took " + amount + " damage.");
    }
}