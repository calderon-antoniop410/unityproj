using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected int health = 100;
    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log(gameObject.name + " took " + amount + " damage.");
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(gameObject.name + " healed " + amount + " health.");
    }
}