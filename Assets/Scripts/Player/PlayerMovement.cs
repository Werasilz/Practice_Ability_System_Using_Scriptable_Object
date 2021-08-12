using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float normalAcceleration = 100;

    public float acceleration;
    [HideInInspector] public Vector2 movementInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        acceleration = normalAcceleration;
    }

    private void FixedUpdate()
    {
        movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity += movementInput * acceleration * Time.fixedDeltaTime;
    }
}
