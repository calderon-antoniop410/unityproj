using UnityEngine;

public class Enemy : Character
{
    void Start()
    {
        TakeDamage(60);
        TakeDamage(60);
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        if (health <= 0) Debug.Log(gameObject.name + " defeated.");
    }

    // public Character otherCharacter;

    // void TestAccess()
    // {
    //     otherCharacter.health = 9999;
    // }
}