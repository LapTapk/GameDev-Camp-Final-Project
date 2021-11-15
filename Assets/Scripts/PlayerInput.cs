using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _mover;
    private PlayerShooting _shooter;
    
    private bool ShotActivated => Input.GetMouseButton(0);

    private void Awake()
    {
        _mover = GetComponent<PlayerMovement>();
        _shooter = GetComponent<PlayerShooting>();
    }

    private void Update()
    {
        if(ShotActivated)
            _shooter.TryShoot();

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
    }
}
