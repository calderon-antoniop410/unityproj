using UnityEngine;

public class BossEnemy : Enemy
{
    private void Start()
    {
        TakeDamage(25);
        TakeDamage(25);
        TakeDamage(25);
        TakeDamage(25);
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);

        if(health <= 25) Debug.Log(gameObject.name + " is a boss and enters rage mode!");
    }
}
