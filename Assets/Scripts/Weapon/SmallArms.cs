using UnityEngine;

public class SmallArms : Weapon
{
    protected override void AimedShoot()
    {
        Instantiate(bulletPrefab, shotPoint.position, shotPoint.rotation);
    }

    protected override void HipShoot()
    {
        var rotation = shotPoint.eulerAngles;
        Random.InitState((int)(Time.deltaTime * 10000));
        var padding = Random.value * 2 - 1;
        rotation.z -= hipSpreadSemiAngle * padding;

        Instantiate(bulletPrefab, shotPoint.position, Quaternion.Euler(rotation));
    }
}
