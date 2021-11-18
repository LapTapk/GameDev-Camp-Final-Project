using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private int _leadBallAmount;

    protected override void AimedShoot()
    {
        HipShoot();
    }

    protected override void HipShoot()
    {
        for (int i = 0; i < _leadBallAmount; i++)
        {
            var rotation = shotPoint.eulerAngles;
            var padding = Random.value * 2 - 1;
            rotation.z -= hipSpreadSemiAngle * padding;

            Instantiate(bulletPrefab, shotPoint.position, Quaternion.Euler(rotation));
        }
    }
}
