using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public Vector2 LookingPoint;
    [HideInInspector] public bool IsAiming;
    private Vector2 _movement = Vector2.zero;
    public Vector2 Movement
    {
        get => _movement;
        set
        {
            var valueIsValid = CordIsValid(value.x) && CordIsValid(value.y);

            if (!valueIsValid)
                throw new UnityException("All cords of Movement Vector must be integer in range of [-1;1]");
            else
                _movement = value;

            bool CordIsValid(float x) => x == 0 || x == -1 || x == 1;
        }
    }

    [SerializeField] private float _speed, _aimingSpeedReduce;
    private float AimingSpeedReduce => (IsAiming ? _aimingSpeedReduce : 1);
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }

    private void Update()
    {
        LookRotate();
    }

    private void FixedUpdate()
    {
        _rb.velocity = _movement * (_speed * AimingSpeedReduce);
        MoveCamera();
    }

    private void LookRotate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var angle = Vector2.Angle(Vector2.right, mousePosition - transform.position);
        transform.eulerAngles = new Vector3(0f, 0f, transform.position.y < mousePosition.y ? angle : -angle);
    }

    private void MoveCamera()
    {
        var pos = transform.position;
        pos.z = -10;
        Camera.main.transform.position = pos;
    }
}
