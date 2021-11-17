using UnityEngine;

public class Shotgun : Weapon
{
    protected override void AimedShoot()
    {
        Debug.Log("Shotgun straight PEW");
    }

    protected override void HipShoot()
    {
        Debug.Log("Shotgun hip PEW");
    }
}
