using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _mover;
    private PlayerShooting _shooter;
    
    private bool ShotActivated => Input.GetMouseButton(0);
    private bool IsAiming => Input.GetMouseButton(1);
    private bool ReloadActivated => Input.GetKeyDown(KeyCode.R);

    private void Awake()
    {
        _mover = GetComponent<PlayerMovement>();
        _shooter = GetComponent<PlayerShooting>();
    }

    private void Update()
    {
        if (ShotActivated)
            _shooter.CurrentWeapon.TryShoot(IsAiming);

        if (ReloadActivated)
            _shooter.CurrentWeapon.TryReload();

        if (Input.GetKeyDown(KeyCode.Alpha1))
            _shooter.SwitchWeapons(0);
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            _shooter.SwitchWeapons(1);
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            _shooter.SwitchWeapons(2);

        SetMovement();
        SetLookingPoint();
    }

    private void SetLookingPoint()
    {
        var mouseScreenPos = Input.mousePosition;
        _mover.LookingPoint = Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }

    private void SetMovement()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");
        _mover.Movement = new Vector2(x, y);
        _mover.IsAiming = IsAiming;
    }
}
