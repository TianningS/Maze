using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody rb;

    public Vector3 MoveVec { get; private set;}

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0f, z) * moveSpeed;

        MoveVec = new Vector3(x, 0f, z) * moveSpeed;

        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);
    }
}

