using UnityEngine;

public class background : MonoBehaviour
{
    [Header("Set in inspector")]
    public float speed = 30;


    private Vector3 StartPos;
    private float camera;


    private void Start()
    {
        float camera = Input.GetAxis("Horizontal");
    }

    private void Update()
    {
        Vector3 position = transform.position;
        float camera = Input.GetAxis("Horizontal");
        position.x = camera * speed * Time.deltaTime;
        transform.position = position;
    }
}
