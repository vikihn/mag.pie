using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour


{
    public float jumpForce = 5f;
    public float raycastDistance = 0.1f;
    public LayerMask groundLayer;

    public int speed;
    private float originalSpeed;
    Vector2 movement;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    private bool isGrounded;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSpeed = speed;
    }


    private void Update()
    {

        float x = Input.GetAxis("Horizontal");
        movement.x = x;

        // Perform ground check
        isGrounded = GroundCheck();

        if (isGrounded)
        {
            // Jump input
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Apply jump force
                rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        if (movement.x > 0) { spriteRenderer.flipX = false; }
        if (movement.x < 0) { spriteRenderer.flipX = true; }

    }

    private void FixedUpdate()
    {
        Move();

    }

    private void Move()
    {
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
    }
    
    private bool GroundCheck()
    {
        // Cast a ray downwards and check for collisions with the ground layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance, groundLayer);
        return hit.collider != null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SlowDownItem"))
        {
            speed -= 1;
        }

        if (collision.CompareTag("SpeedUpItem"))
        {
            speed += 3;
        }
    }
}


