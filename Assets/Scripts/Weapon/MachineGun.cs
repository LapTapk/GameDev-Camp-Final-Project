using UnityEngine;

public class MachineGun : Weapon
{
    protected override void AimedShoot()
    {
        Instantiate(bulletPrefab, shotPoint.position, shotPoint.rotation);
    }
    protected override void HipShoot()
    {
        //TODO
        var rotation = shotPoint.eulerAngles;
        var inLeftDeviation = Mathf.Ceil(Random.value * 2 - 1);
        //rotation.z -= hipSpreadSemiAngle * (inLeftDeviation ? 1 : -1);

        Instantiate(bulletPrefab, shotPoint.position, Quaternion.Euler(rotation));
    }
}
