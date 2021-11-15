using UnityEngine;

public class Thompson : Weapon
{
    protected override void Shoot()
    {
        var projectileGO = Instantiate(projectilePrefab, shotPoint.position, shotPoint.rotation);
        var projectileRb = projectileGO.GetComponent<Rigidbody2D>();

    }
}
