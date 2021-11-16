using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _mover;
    
    private bool ShotActivated => Input.GetMouseButton(0);

    private void Awake()
    {
        _mover = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
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
