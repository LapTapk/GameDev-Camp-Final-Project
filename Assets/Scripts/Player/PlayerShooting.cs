using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Weapon[] _weapons;
    private int _weaponIndex = 0;
    public Weapon CurrentWeapon => _weapons[_weaponIndex];

    public void SwitchWeapons(int weaponIndex)
    {
        if (weaponIndex >= _weapons.Length)
            throw new UnityException("WeaponIndex must be less than all weapos count.");

        CurrentWeapon.gameObject.SetActive(false);

        _weaponIndex = weaponIndex;

        CurrentWeapon.gameObject.SetActive(true);
    }
}
