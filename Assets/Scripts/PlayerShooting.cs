using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Weapon[] startWeapons;
    private int _currentWeaponIndex = 0;
    
    public void TryShoot()
    {
        startWeapons[_currentWeaponIndex].TryShoot();
    }
}
