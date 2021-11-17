using UnityEngine;

public class EnemieLife : CharacterLife
{
    protected override void Die()
    {
        Destroy(gameObject);
    }
}