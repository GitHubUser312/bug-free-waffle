using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] 
    private float moveSpeed = 10.0f;

    [SerializeField]
    float minX = -2.311f;

    [SerializeField]
    float maxX = 2.271f;

    private Rigidbody2D rb;
    private float moveInput;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        // Apply movement only along X-axis
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        Vector2 clampedPosition = rb.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        rb.position = clampedPosition;
    }
}
